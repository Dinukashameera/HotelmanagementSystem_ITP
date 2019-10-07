using customerManagementITP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace GYM
{
    public partial class GymManagementForm : MetroFramework.Forms.MetroForm
    {

        SqlConnection sqlcon = DBConnection.getConnection();  //create db connection
        GymUsage gymUsage = new GymUsage();
        Trainer trainer = new Trainer();
        GymSupplier supplier = new GymSupplier();
        GymEquipment equipment = new GymEquipment();
        int gymUseId = 0;
        int TrainerEmpID = 0;
        int supplierEntryId = 0;
        int equipmentId = 0;


        public GymManagementForm()
        {
            InitializeComponent();
            initializeGymUserComponents();
            initializeGymTrainerComponents();
            initializeGymSupplierComponents();
            initializeGymEquipmentsComponents();
            initializeChangableValuesComponents();

            fillDBOperationsDataGridView();


        }

        private void GymManagementForm_Load(object sender, EventArgs e)
        {
            autoCompleteGymSupplierSearch();
            autoCompleteGymEquipmentSearch();
            autoCompleteGymTrainerSearch();
        }


        public void initializeChangableValuesComponents()
        {
            txtCurrentValFeePerAdult.Text = Convert.ToString(GymCharges.returnGymCharges("Fee Per Adult"));
            txtCurrentValFeePerChild.Text = Convert.ToString(GymCharges.returnGymCharges("Fee Per Child"));
            txtCurrentValTrainerBasicSal.Text = Convert.ToString(GymCharges.returnGymCharges("Trainer Basic Salary"));
            txtCurrentValDiscountPercentage.Text = Convert.ToString(GymCharges.returnGymCharges("Discount Percentage"));
            txtCurrentValTrainerFee.Text = Convert.ToString(GymCharges.returnGymCharges("Trainer Fee"));

            numNewValFeePerAdult.Text = "";
            numNewValFeePerChild.Text = "";
            numNewValTrainerBasicSal.Text = "";
            numNewValDiscountPercentage.Text = "";
            numNewValTrainerFee.Text = "";

        }



        public void initializeGymUserComponents() {
            fillcmbRoom();
            fillGymUsageDataGridView();
            tab.SelectedTab = gymUsageTabPage;  //set first tab of TabControl
            metroTabControl2.SelectedTab = dailyReportTabPage;

            cmbGenderTrainer.SelectedIndex = 0;//set default value to first index of unbound items

            cmbNationalityGymUsage.SelectedIndex = 0;
            btnDeleteGymUsage.Enabled = false;
        }

        public void initializeGymTrainerComponents()
        {
            fillTrainerDataGridView();
            btnDeleteTrainers.Enabled = false;
            cmbGenderTrainer.SelectedIndex = 0;
            predictNextGymTrainerID(); // predict next EMP_ID
        }

        public void predictNextGymTrainerID()
        {
            //retreive last employee ID from data base
            int LastEmpID = 0;
            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("SELECT TOP 1 Emp_ID FROM Emplyoees ORDER BY Emp_ID DESC", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();
            try
            {
                LastEmpID = Convert.ToInt32(sqlDr["Emp_ID"]);
            }
            catch (Exception ex)
            {
                LastEmpID = 0;  //if there are no entries set LastSuppID to 0
            }
            sqlDr.Close();
            DBConnection.closeDBConnection();



            txtIDTrainer.Text = Convert.ToString(LastEmpID + 1);
        }

        public void initializeGymEquipmentsComponents()
        {
            fillcmbSupplierEquipment();
            btnDeleteGymEquipments.Enabled = false;
            fillGymEquipmentsDataGridView();

            //in order to disallow editing of total
            TotPriceGymEquipments.ReadOnly = true;
            TotPriceGymEquipments.Controls.RemoveAt(0);
            TotPriceGymEquipments.Increment = 0;
        }



        public void fillcmbRoom()
        {
            try
            {
                DBConnection.openDBConnection();
                SqlCommand sqlcmd1 = new SqlCommand("select * from Accomodation where status = 'Occupied' ", sqlcon);   //create SqlCommand object by using SELECT query
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmbRoomGymUsage.ValueMember = "accID";
                cmbRoomGymUsage.DisplayMember = "accID";
                cmbRoomGymUsage.DataSource = dt;
                DBConnection.closeDBConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n Error has been risen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void resetGymUser()
        {
            cmbRoomGymUsage.SelectedIndex = 0;
            cmbNationalityGymUsage.SelectedIndex = 0;
            //txtUsedHoursGymUsers.Text = "";
            numOfAdultsGymUsage.Value = 0;
            numOfChildrenGymUsage.Value = 0;
            numOfFemalesGymUsage.Value = 0;
            numOfMalesGymUsage.Value = 0;
            //txtUsedMinutesGymUsers.Text = "";
            chkNeedTrainerGymUsage.Checked = false;
            btnSaveGymUsage.Text = "SUBMIT";
            btnDeleteGymUsage.Enabled = false;
        }


        public void resetGymTrainer()
        {
            cmbGenderTrainer.SelectedIndex = 0;
            txtFirstNameTrainer.Text = "";
            txtLastNameTrainer.Text = "";
            txtNICTrainer.Text = "";
            txtIDTrainer.Text = "";
            dateDOBTrainer.Value = DateTime.Today;
            txtAddressLine1Trainer.Text = "";
            txtAddressLine2Trainer.Text = "";
            txtCityTrainer.Text = "";
            txtContactNoTrainer.Text = "";
            txtEmailTrainer.Text = "";
            dateHiredTrainer.Value = DateTime.Today;
            txtIDTrainer.Enabled = true;
            btnAddTrainers.Text = "ADD";
            btnDeleteTrainers.Enabled = false;

            predictNextGymTrainerID();  //predict next EMP_ID
        }


        private void GvGymUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvGymUsage.CurrentRow.Index != -1)
                {
                    gymUseId = Convert.ToInt32(gvGymUsage.CurrentRow.Cells[0].Value.ToString());
                    cmbRoomGymUsage.Text = gvGymUsage.CurrentRow.Cells[2].Value.ToString();
                    numOfAdultsGymUsage.Text = gvGymUsage.CurrentRow.Cells[3].Value.ToString();
                    numOfChildrenGymUsage.Text = gvGymUsage.CurrentRow.Cells[4].Value.ToString();
                    numOfMalesGymUsage.Text = gvGymUsage.CurrentRow.Cells[5].Value.ToString();
                    numOfFemalesGymUsage.Text = gvGymUsage.CurrentRow.Cells[6].Value.ToString();

                    if (gvGymUsage.CurrentRow.Cells[7].Value.ToString() == "True")
                    {
                        chkNeedTrainerGymUsage.Checked = true;
                    }
                    else
                    {
                        chkNeedTrainerGymUsage.Checked = false;
                    }

                    //txtUsedHoursGymUsers.Text = gvGymUsers.CurrentRow.Cells[8].Value.ToString();
                    //txtUsedMinutesGymUsers.Text = gvGymUsers.CurrentRow.Cells[9].Value.ToString();
                    cmbNationalityGymUsage.Text = gvGymUsage.CurrentRow.Cells[8].Value.ToString();


                    btnSaveGymUsage.Text = "UPDATE";
                    btnDeleteGymUsage.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n***Invalid operation***", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void fillTrainerDataGridView()
        {
            trainer.SearchText = txtSearchGymTrainers.Text.Trim().ToString();
            DataTable dt = trainer.viewOrSearch();
            gvGymTrainers.DataSource = dt;
            //gvGymTrainers.Columns[0].Visible = false;

        }

        private void GvGymTrainers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvGymTrainers.CurrentRow.Index != -1)
                {
                    TrainerEmpID = Convert.ToInt32(gvGymTrainers.CurrentRow.Cells[0].Value.ToString());  //in order to updating
                    txtIDTrainer.Text = gvGymTrainers.CurrentRow.Cells[0].Value.ToString();


                    txtFirstNameTrainer.Text = gvGymTrainers.CurrentRow.Cells[1].Value.ToString();
                    txtLastNameTrainer.Text = gvGymTrainers.CurrentRow.Cells[2].Value.ToString();
                    txtNICTrainer.Text = gvGymTrainers.CurrentRow.Cells[3].Value.ToString();
                    dateDOBTrainer.Text = gvGymTrainers.CurrentRow.Cells[4].Value.ToString();

                    cmbGenderTrainer.Text = gvGymTrainers.CurrentRow.Cells[5].Value.ToString();

                    txtEmailTrainer.Text = gvGymTrainers.CurrentRow.Cells[6].Value.ToString();
                    txtContactNoTrainer.Text = gvGymTrainers.CurrentRow.Cells[7].Value.ToString();
                    txtAddressLine1Trainer.Text = gvGymTrainers.CurrentRow.Cells[8].Value.ToString();
                    txtAddressLine2Trainer.Text = gvGymTrainers.CurrentRow.Cells[9].Value.ToString();
                    txtCityTrainer.Text = gvGymTrainers.CurrentRow.Cells[10].Value.ToString();
                    dateHiredTrainer.Text = gvGymTrainers.CurrentRow.Cells[13].Value.ToString();


                    btnAddTrainers.Text = "UPDATE";
                    btnDeleteTrainers.Enabled = true;
                    txtIDTrainer.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n***Invalid operation***", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void fillSupplierDataGridView() {
            supplier.SearchText = txtSearchGymSuppliers.Text.Trim().ToString();
            DataTable dt = supplier.viewOrSearch();
            gvGymSupplier.DataSource = dt;
            gvGymSupplier.Columns[0].Visible = false;

        }

        public void fillDBOperationsDataGridView()
        {

            DBConnection.openDBConnection();
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewGymDBOperations", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            gvGymDBOperations.DataSource = dt;
            gvGymDBOperations.Columns[0].Visible = false;
            DBConnection.closeDBConnection();
        }

        private void BtnDeleteDbLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to delete all records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("delete from Gym_DBOperations", sqlcon);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Deleted All Records Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

                fillDBOperationsDataGridView();
            }
        }


        private void GvGymSupplier_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                supplierEntryId = Convert.ToInt32(gvGymSupplier.CurrentRow.Cells[0].Value.ToString());

                txtIDGymSupplier.Text = gvGymSupplier.CurrentRow.Cells[1].Value.ToString();
                txtNameGymSupplier.Text = gvGymSupplier.CurrentRow.Cells[2].Value.ToString();
                txtAddressGymSupplier.Text = gvGymSupplier.CurrentRow.Cells[3].Value.ToString();
                txtContactNoGymSupplier.Text = gvGymSupplier.CurrentRow.Cells[4].Value.ToString();
                txtEmailGymSupplier.Text = gvGymSupplier.CurrentRow.Cells[5].Value.ToString();

                btnDeleteGymSuppliers.Enabled = true;
                txtIDGymSupplier.Enabled = false;
                btnAddGymSuppliers.Text = "UPDATE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n***Invalid operation***", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initializeGymSupplierComponents()
        {
            fillSupplierDataGridView();
            predictNextGymSupplierID(); //to predict Next Gym Supplier ID
            btnDeleteGymSuppliers.Enabled = false;
        }

        public void predictNextGymSupplierID() {


            //retreive last supplier ID from data base
            int LastSuppID= 0;
            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("SELECT TOP 1 supplierId FROM Gym_Supplier ORDER BY entryId DESC", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();
            try
            {
                LastSuppID = Convert.ToInt32(sqlDr["supplierId"]);
            }
            catch (Exception ex) {
                LastSuppID = 0;  //if there are no entries set LastSuppID to 0
            }
            sqlDr.Close();
            DBConnection.closeDBConnection();



            txtIDGymSupplier.Text = Convert.ToString(LastSuppID+1);

        }


        public void resetGymSupplier()
        {
            txtNameGymSupplier.Text = "";
            txtIDGymSupplier.Text = "";
            txtAddressGymSupplier.Text = "";
            txtContactNoGymSupplier.Text = "";
            txtEmailGymSupplier.Text = "";
            btnDeleteGymSuppliers.Enabled = false;
            btnAddGymSuppliers.Text = "ADD";
            txtIDGymSupplier.Enabled = true;

            predictNextGymSupplierID(); //to predict Next Gym Supplier ID

        }

        public void fillcmbSupplierEquipment(){
            try
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("Select * from Gym_Supplier", sqlcon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                cmbSupplierGymEquipment.DisplayMember = "supplierId";
                cmbSupplierGymEquipment.ValueMember = "supplierId";
                cmbSupplierGymEquipment.DataSource = dt;

                DBConnection.closeDBConnection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void resetGymEquipments() {
            txtBrandGymEquipments.Text = "";
            txtTypeGymEquipments.Text = "";
            txtModelNoGymEquipments.Text = "";
            cmbSupplierGymEquipment.Text = "";
            UnitPriceGymEquipments.Value = 0;
            QuantityGymEquipments.Value = 1;
            TotPriceGymEquipments.Value = 0;
            dateGymEquipmentsPurchased.Value = DateTime.Today;
            btnDeleteGymEquipments.Enabled = false;
            btnAddGymEquipments.Text = "ADD";
        }



        public void fillGymEquipmentsDataGridView() {
            equipment.SearchText = txtSearchGymEquipments.Text.Trim().ToString();
            DataTable dt = equipment.viewOrSearch();
            gvGymEquipments.DataSource = dt;
            gvGymEquipments.Columns[0].Visible = false;

        }


        private void GvGymEquipments_DoubleClick(object sender, EventArgs e)
        {
            equipmentId = Convert.ToInt32(gvGymEquipments.CurrentRow.Cells[0].Value.ToString());

            txtBrandGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[1].Value.ToString();
            txtTypeGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[2].Value.ToString();
            txtModelNoGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[3].Value.ToString();
            UnitPriceGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[4].Value.ToString();
            QuantityGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[5].Value.ToString();
            TotPriceGymEquipments.Text = gvGymEquipments.CurrentRow.Cells[6].Value.ToString();
            cmbSupplierGymEquipment.Text = gvGymEquipments.CurrentRow.Cells[7].Value.ToString();
            dateGymEquipmentsPurchased.Text = gvGymEquipments.CurrentRow.Cells[8].Value.ToString();

            btnDeleteGymEquipments.Enabled = true;
            btnAddGymEquipments.Text = "UPDATE";

        }

        private void BtnSaveGymUsage_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoomGymUsage.Text == "" || (numOfAdultsGymUsage.Text == "0" && numOfChildrenGymUsage.Text == "0") || (numOfFemalesGymUsage.Text == "0" && numOfMalesGymUsage.Text == "0") || cmbNationalityGymUsage.Text == "")
                {
                    MessageBox.Show("Invalid Insertion Of Details. \nPlease Check again and Sumbit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((numOfAdultsGymUsage.Value + numOfChildrenGymUsage.Value) != (numOfMalesGymUsage.Value + numOfFemalesGymUsage.Value))
                {
                    MessageBox.Show("Addition of Number of Adults and Number of Children should be equal to addtion of Number of Males and Number of Females. \nPlease Check again and Sumbit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (btnSaveGymUsage.Text == "SUBMIT")
                    {

                        gymUsage.RoomId = cmbRoomGymUsage.Text.Trim().ToString();
                        gymUsage.NumOfAdults = Convert.ToInt32(numOfAdultsGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfChildren = Convert.ToInt32(numOfChildrenGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfFemales = Convert.ToInt32(numOfFemalesGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfMales = Convert.ToInt32(numOfMalesGymUsage.Text.Trim().ToString());
                        gymUsage.NeedTrainer = chkNeedTrainerGymUsage.Checked;
                        gymUsage.Nationality = cmbNationalityGymUsage.Text.Trim().ToString();

                        gymUsage.save();


                        resetGymUser();
                        fillGymUsageDataGridView();

                    }
                    else if (btnSaveGymUsage.Text == "UPDATE")
                    {
                        gymUsage.RoomId = cmbRoomGymUsage.Text.Trim().ToString();
                        gymUsage.NumOfAdults = Convert.ToInt32(numOfAdultsGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfChildren = Convert.ToInt32(numOfChildrenGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfFemales = Convert.ToInt32(numOfFemalesGymUsage.Text.Trim().ToString());
                        gymUsage.NumOfMales = Convert.ToInt32(numOfMalesGymUsage.Text.Trim().ToString());
                        gymUsage.NeedTrainer = chkNeedTrainerGymUsage.Checked;
                        gymUsage.Nationality = cmbNationalityGymUsage.Text.Trim().ToString();

                        gymUsage.update(gymUseId);


                        resetGymUser();
                        fillGymUsageDataGridView();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n***Please Re check the input details are correct***", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDeleteGymUsage_Click(object sender, EventArgs e)
        {
            try
            {
                gymUsage.delete(gymUseId);
                resetGymUser();
                fillGymUsageDataGridView();
                gymUseId = 0;
                btnDeleteGymUsage.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nError has been risen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

/*        private void BtnSearchGymUsers_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillGymUsageDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void TxtSearchGymUsers_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                e.SuppressKeyPress = true; //stop 'Ding' sound generated by system
                try
                {
                    fillGymUsageDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TxtSearchGymUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                e.SuppressKeyPress = true; //stop 'Ding' sound generated by system
                try
                {
                    fillGymUsageDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResetGymUsage_Click(object sender, EventArgs e)
        {
            resetGymUser();
        }

        public void fillGymUsageDataGridView()
        {
            gymUsage.SearchText = txtSearchGymUsers.Text.Trim().ToString();
            DataTable dt = gymUsage.viewOrSearch();
            gvGymUsage.DataSource = dt;
            gvGymUsage.Columns[0].Visible = false;

        }


        private void TxtSearchGymTrainers_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                e.SuppressKeyPress = true; //stop 'Ding' sound generated by system
                try
                {
                    fillTrainerDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

/*        private void BtnSearchGymTrainers_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillTrainerDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void BtnAddTrainers_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDTrainer.Text == "" || txtFirstNameTrainer.Text == "" || txtLastNameTrainer.Text == "" || dateDOBTrainer.Value == null || cmbGenderTrainer.Text == "" || txtCityTrainer.Text == "" || txtAddressLine1Trainer.Text == "" || dateHiredTrainer.Text == "" || (txtEmailTrainer.Text == "" && txtContactNoTrainer.Text == ""))
                {
                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtFirstNameTrainer.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("First name should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtLastNameTrainer.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Last name should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtCityTrainer.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("City should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtContactNoTrainer.Text.Length != 10 )
                {
                    MessageBox.Show("Contact number should have only 10 numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNICTrainer.Text.Length != 10 && txtNICTrainer.Text.Length != 12)
                {
                    MessageBox.Show("NIC should have only 10 or 12 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidEmail(txtEmailTrainer.Text))
                {
                    MessageBox.Show("Email is not in correct structure", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    if (btnAddTrainers.Text.ToString() == "ADD")
                    {
                        trainer.EmpID = txtIDTrainer.Text.Trim().ToString();
                        trainer.FName = txtFirstNameTrainer.Text.Trim().ToString();
                        trainer.LName = txtLastNameTrainer.Text.Trim().ToString();
                        trainer.NIC1 = txtNICTrainer.Text.Trim().ToString();
                        trainer.DOB1 = dateDOBTrainer.Value.ToString();
                        trainer.AddLine1 = txtAddressLine1Trainer.Text.Trim().ToString();
                        trainer.AddLine2 = txtAddressLine2Trainer.Text.Trim().ToString();
                        trainer.City = txtCityTrainer.Text.Trim().ToString();
                        trainer.Gender = cmbGenderTrainer.Text.Trim().ToString();
                        trainer.ContactNum = txtContactNoTrainer.Text.Trim().ToString();
                        trainer.Email = txtEmailTrainer.Text.Trim().ToString();
                        trainer.TrainerhiredDate = dateHiredTrainer.Value.ToString();

                        trainer.save();

                    }
                    else if (btnAddTrainers.Text.ToString() == "UPDATE")
                    {
                        trainer.FName = txtFirstNameTrainer.Text.Trim().ToString();
                        trainer.LName = txtLastNameTrainer.Text.Trim().ToString();
                        trainer.NIC1 = txtNICTrainer.Text.Trim().ToString();
                        trainer.DOB1 = dateDOBTrainer.Value.ToString();
                        trainer.AddLine1 = txtAddressLine1Trainer.Text.Trim().ToString();
                        trainer.AddLine2 = txtAddressLine2Trainer.Text.Trim().ToString();
                        trainer.City = txtCityTrainer.Text.Trim().ToString();
                        trainer.Gender = cmbGenderTrainer.Text.Trim().ToString();
                        trainer.ContactNum = txtContactNoTrainer.Text.Trim().ToString();
                        trainer.Email = txtEmailTrainer.Text.Trim().ToString();
                        trainer.TrainerhiredDate = dateHiredTrainer.Value.ToString();

                        trainer.update(TrainerEmpID);

                    }
                    fillTrainerDataGridView();
                    resetGymTrainer();
                    fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                }
                predictNextGymTrainerID();  //predict next EMP_ID
                autoCompleteGymTrainerSearch();  // to refresh the autocompleted list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteTrainers_Click_1(object sender, EventArgs e)
        {
            try
            {
                trainer.delete(TrainerEmpID);
                resetGymTrainer();
                fillTrainerDataGridView();
                TrainerEmpID = 0;
                btnDeleteTrainers.Enabled = false;

                fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                predictNextGymTrainerID();  //predict next EMP_ID
                autoCompleteGymTrainerSearch();  // to refresh the autocompleted list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nError has been risen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearTrainers_Click_1(object sender, EventArgs e)
        {
            resetGymTrainer();
        }

        private void BtnAddSuppliers_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtNameGymSupplier.Text == "" || txtIDGymSupplier.Text == "" || txtAddressGymSupplier.Text == "" || txtContactNoGymSupplier.Text == "" || txtEmailGymSupplier.Text == "")
                {
                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtNameGymSupplier.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("First name should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtContactNoGymSupplier.Text.Length != 10)
                {
                    MessageBox.Show("Contact number should have only 10 numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidEmail(txtEmailGymSupplier.Text))
                {
                    MessageBox.Show("Email is not in correct structure", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    if (btnAddGymSuppliers.Text == "ADD")
                    {
                        supplier.Name = txtNameGymSupplier.Text.Trim().ToString();
                        supplier.Id = txtIDGymSupplier.Text.Trim().ToString();
                        supplier.Address = txtAddressGymSupplier.Text.Trim().ToString();
                        supplier.ContactNum = txtContactNoGymSupplier.Text.Trim().ToString();
                        supplier.Email = txtEmailGymSupplier.Text.Trim().ToString();

                        supplier.save();

                        
                    }
                    else if (btnAddGymSuppliers.Text == "UPDATE")
                    {

                        supplier.Name = txtNameGymSupplier.Text.Trim().ToString();
                        supplier.Id = txtIDGymSupplier.Text.Trim().ToString();
                        supplier.Address = txtAddressGymSupplier.Text.Trim().ToString();
                        supplier.ContactNum = txtContactNoGymSupplier.Text.Trim().ToString();
                        supplier.Email = txtEmailGymSupplier.Text.Trim().ToString();

                        supplier.update(supplierEntryId);

                        
                        //fillSupplierDataGridView();
                    }

                    fillSupplierDataGridView();
                    resetGymSupplier();
                    fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                }
                predictNextGymSupplierID(); //to update next supp ID
                autoCompleteGymSupplierSearch(); //to refresh autocomlplete the list
                fillcmbSupplierEquipment();  //in order to update suppliers in equipments
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message + "\n\nThis Supplier ID is already Exist. \n\nPlease Re check the input details", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteSuppliers_Click_1(object sender, EventArgs e)
        {
            try
            {
                supplier.delete(supplierEntryId);
                resetGymSupplier();
                fillSupplierDataGridView();
                supplierEntryId = 0;
                btnDeleteGymSuppliers.Enabled = false;

                fillcmbSupplierEquipment();  //in order to update suppliers in equipments
                fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                predictNextGymSupplierID(); //to predict Next Gym Supplier ID
                autoCompleteGymSupplierSearch(); //to refresh autocomlplete the list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not delete this supplier until avilability of equipments which are provided by this suppiler", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearSuppliers_Click_1(object sender, EventArgs e)
        {
            resetGymSupplier();
        }

        private void TxtSearchGymSuppliers_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                e.SuppressKeyPress = true; //stop 'Ding' sound generated by system
                try
                {
                    fillSupplierDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

/*        private void BtnSearchGymSuppliers_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillSupplierDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void TxtSearchGymEquipments_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {

                try
                {
                    fillGymEquipmentsDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

/*        private void BtnSearchGymEquipments_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillGymEquipmentsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void BtnAddEquipments_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtBrandGymEquipments.Text == "" || txtTypeGymEquipments.Text == "" || txtModelNoGymEquipments.Text == "")
                {
                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtBrandGymEquipments.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Brand name should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtTypeGymEquipments.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Type should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (QuantityGymEquipments.Value == 0 || TotPriceGymEquipments.Value == 0)
                {
                    MessageBox.Show("Please enter unit price and quantity correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    if (btnAddGymEquipments.Text == "ADD")
                    {
                        equipment.BrandName = txtBrandGymEquipments.Text.Trim().ToString();
                        equipment.Type = txtTypeGymEquipments.Text.Trim().ToString();
                        equipment.ModelNumber = txtModelNoGymEquipments.Text.Trim().ToString();
                        equipment.Supplierid = cmbSupplierGymEquipment.Text.Trim().ToString();
                        equipment.UnitPrice = Convert.ToDouble(UnitPriceGymEquipments.Text.Trim().ToString());
                        equipment.Quantity = Convert.ToInt32(QuantityGymEquipments.Text.Trim().ToString());
                        equipment.TotalPrice = Convert.ToDouble(TotPriceGymEquipments.Text.Trim().ToString());
                        equipment.Purchaseddate = dateGymEquipmentsPurchased.Value.ToString();

                        equipment.save();
                    }
                    else if (btnAddGymEquipments.Text == "UPDATE")
                    {
                        equipment.BrandName = txtBrandGymEquipments.Text.Trim().ToString();
                        equipment.Type = txtTypeGymEquipments.Text.Trim().ToString();
                        equipment.ModelNumber = txtModelNoGymEquipments.Text.Trim().ToString();
                        equipment.Supplierid = cmbSupplierGymEquipment.Text.Trim().ToString();
                        equipment.UnitPrice = Convert.ToDouble(UnitPriceGymEquipments.Text.Trim().ToString());
                        equipment.Quantity = Convert.ToInt32(QuantityGymEquipments.Text.Trim().ToString());
                        equipment.TotalPrice = Convert.ToDouble(TotPriceGymEquipments.Text.Trim().ToString());
                        equipment.Purchaseddate = dateGymEquipmentsPurchased.Value.ToString();

                        equipment.update(equipmentId);

                    }
                    fillGymEquipmentsDataGridView();
                    resetGymEquipments();
                    fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                }
                autoCompleteGymEquipmentSearch();  // to refresh the autocompleted list

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteEquipments_Click_1(object sender, EventArgs e)
        {
            try
            {
                equipment.delete(equipmentId);
                fillGymEquipmentsDataGridView();
                resetGymEquipments();

                fillDBOperationsDataGridView(); // to refresh DBOperation grid view
                autoCompleteGymEquipmentSearch();  // to refresh the autocompleted list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearEquipments_Click_1(object sender, EventArgs e)
        {
            resetGymEquipments();
        }

        //in order to allow letters only
        private void TxtFirstNameTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtTypeGymEquipments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtBrandGymEquipments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtNameGymSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtCityTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtLastNameTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //in order to avoid entering special characters
        private void TxtModelNoGymEquipments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back  && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers and letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //NIC validation
        private void TxtNICTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.V && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers and captial V", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //in order to allow only Numerics
        private void TxtContactNoGymSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtIDTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TxtIDGymSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TxtContactNoTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }



        //to display total when click the txtbox
        private void UnitPriceGymEquipments_ValueChanged(object sender, EventArgs e)
        {
            calcGymEquipmentTotal();
        }

        private void QuantityGymEquipments_ValueChanged(object sender, EventArgs e)
        {
            calcGymEquipmentTotal();
        }


        //to display total when click the txtbox
        public void calcGymEquipmentTotal() {
            int qty = Convert.ToInt32(QuantityGymEquipments.Value);
            double unitPrice = Convert.ToDouble(UnitPriceGymEquipments.Value);

            TotPriceGymEquipments.Value = Convert.ToDecimal(qty * unitPrice);
        }




        private void BtnChangeValFeePerAdult_Click_1(object sender, EventArgs e)
        {
            if (numNewValFeePerAdult.Text == "")
            {
                MessageBox.Show("Please Enter New Value Before Change", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numNewValFeePerAdult.Value < 0)
            {
                MessageBox.Show("This value can not be negative", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double newAdultFee = Convert.ToDouble(numNewValFeePerAdult.Text);

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("changeGymChargeValues", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@description_", "Fee Per Adult");
                sqlcmd.Parameters.AddWithValue("@charge", newAdultFee);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Updated Fee Per Adult Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

                numNewValFeePerAdult.Text = "";
                initializeChangableValuesComponents();  //to refresh and show updated value
                //gymUsage.FeePerAdult = GymCharges.returnGymCharges("Fee Per Adult"); //to refresh updated value
            }
        }

        private void BtnChangeValFeePerChild_Click_1(object sender, EventArgs e)
        {
            if (numNewValFeePerChild.Text == "")
            {
                MessageBox.Show("Please Enter New Value Before Change", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numNewValFeePerChild.Value < 0)
            {
                MessageBox.Show("This value can not be negative", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                double newChildFee = Convert.ToDouble(numNewValFeePerChild.Text);

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("changeGymChargeValues", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@description_", "Fee Per Child");
                sqlcmd.Parameters.AddWithValue("@charge", newChildFee);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Updated Fee Per Child Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

                numNewValFeePerChild.Text = "";
                initializeChangableValuesComponents();  //to refresh and show updated value
                //gymUsage.FeePerChild = GymCharges.returnGymCharges("Fee Per Child"); //to refresh updated value
            }
        }

        private void BtnChangeValTrainerBasicSal_Click_1(object sender, EventArgs e)
        {
            if (numNewValTrainerBasicSal.Text == "")
            {
                MessageBox.Show("Please Enter New Value Before Change", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numNewValTrainerBasicSal.Value < 0)
            {
                MessageBox.Show("This value can not be negative", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                double newTrainerBasicSalary = Convert.ToDouble(numNewValTrainerBasicSal.Text);

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("changeGymChargeValues", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@description_", "Trainer Basic Salary");
                sqlcmd.Parameters.AddWithValue("@charge", newTrainerBasicSalary);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Updated Trainer's Basic Salary Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

                numNewValTrainerBasicSal.Text = "";
                initializeChangableValuesComponents();  //to refresh and show updated value

                trainer.TrainerBasicSalary = GymCharges.returnGymCharges("Trainer Basic Salary"); //to refresh updated value

            }
        }

        private void BtnChangeValDiscountPercentage_Click_1(object sender, EventArgs e)
        {
            if (numNewValDiscountPercentage.Text == "")
            {
                MessageBox.Show("Please Enter New Value Before Change", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numNewValDiscountPercentage.Value > 100)
            {
                MessageBox.Show("This value can not exceed 100", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numNewValDiscountPercentage.Value < 0)
            {
                MessageBox.Show("This value can not be negative", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                double newDiscountPercentage = Convert.ToDouble(numNewValDiscountPercentage.Text);

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("changeGymChargeValues", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@description_", "Discount Percentage");
                sqlcmd.Parameters.AddWithValue("@charge", newDiscountPercentage);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Updated Discount Percentage Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

                numNewValDiscountPercentage.Text = "";
                initializeChangableValuesComponents();  //to refresh and show updated value
                //gymUsage.DiscountPercentage = GymCharges.returnGymCharges("Discount Percentage");  //to refresh updated value
            }
            
        }

        private void BtnChangeValTrainerFee_Click_1(object sender, EventArgs e)
        {
                if (numNewValTrainerFee.Text == "")
                {
                    MessageBox.Show("Please Enter New Value Before Change", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numNewValTrainerFee.Value < 0 )
                {
                    MessageBox.Show("This value can not be negative", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    double newTrainerFee = Convert.ToDouble(numNewValTrainerFee.Text);

                    DBConnection.openDBConnection();

                    SqlCommand sqlcmd = new SqlCommand("changeGymChargeValues", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    sqlcmd.Parameters.AddWithValue("@description_", "Trainer Fee");
                    sqlcmd.Parameters.AddWithValue("@charge", newTrainerFee);

                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Trainer Fee Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBConnection.closeDBConnection();

                    numNewValTrainerFee.Text = "";
                    initializeChangableValuesComponents();  //to refresh and show updated value
                    //gymUsage.TrainerFee = GymCharges.returnGymCharges("Trainer Fee"); //to refresh updated value
            }
            
        }

        //disallow spaces
        private void TxtEmailTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Spaces are disallowed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtEmailGymSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Spaces are disallowed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //search while typing
        private void TxtSearchGymUsers_TextChanged(object sender, EventArgs e)
        {
            fillGymUsageDataGridView();
        }

        private void TxtSearchGymTrainers_TextChanged(object sender, EventArgs e)
        {
            fillTrainerDataGridView();
        }

        private void TxtSearchGymSuppliers_TextChanged(object sender, EventArgs e)
        {
            
            fillSupplierDataGridView();
        }

        private void TxtSearchGymEquipments_TextChanged(object sender, EventArgs e)
        {
            fillGymEquipmentsDataGridView();
        }


        //view report form
/*        private void BtnViewReportGymUsage_Click(object sender, EventArgs e)
        {
            GymUsageReportForm gymUsageReportForm = new GymUsageReportForm();
            gymUsageReportForm.Show();
        }*/


        //autoCompleteGymSearches
        public void autoCompleteGymSupplierSearch() {
            
            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("SELECT name_ from Gym_Supplier", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            while (sqlDr.Read())
            {
                autoComplete.Add(sqlDr.GetString(0));
            }
            txtSearchGymSuppliers.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchGymSuppliers.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchGymSuppliers.AutoCompleteCustomSource = autoComplete;


            sqlDr.Close();
            DBConnection.closeDBConnection();
        }

        public void autoCompleteGymTrainerSearch()
        {

            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("SELECT First_Name from Emplyoees", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            while (sqlDr.Read())
            {
                autoComplete.Add(sqlDr.GetString(0));
            }
            txtSearchGymTrainers.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchGymTrainers.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchGymTrainers.AutoCompleteCustomSource = autoComplete;


            sqlDr.Close();
            DBConnection.closeDBConnection();
        }

        public void autoCompleteGymEquipmentSearch()
        {

            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("SELECT brandName  from Gym_Equipments", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            while (sqlDr.Read())
            {
                autoComplete.Add(sqlDr.GetString(0));
            }
            txtSearchGymEquipments.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchGymEquipments.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchGymEquipments.AutoCompleteCustomSource = autoComplete;


            sqlDr.Close();
            DBConnection.closeDBConnection();
        }

        private void DateTimePicker1Gym_ValueChanged(object sender, EventArgs e)
        {

            foreach (var series_1 in chartGymDailyNationality.Series)
            {
                series_1.Points.Clear();
            }

            foreach (var series_2 in chartGymDailyGender.Series)
            {
                series_2.Points.Clear();
            }

            DBConnection.openDBConnection();

            String date = dateTimePicker1Gym.Value.ToString("yyyy/MM/dd");
            date = date.Replace("/", "-");

            SqlCommand sqlCommand1 = new SqlCommand("select count(nationality) from Gym_Usage where usedDate like '%" + date + "%' group by nationality", sqlcon);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            Series series1 = new Series();

            try
            {
                while (sqlDataReader1.Read())
                {
                    chartGymDailyNationality.Series[0].Points.AddY(sqlDataReader1.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data for this day");
            }

            sqlDataReader1.Close();

            /*            DBConnection.closeDBConnection();


                        DBConnection.openDBConnection();*/

            SqlCommand sqlCommand = new SqlCommand("select SUM(numberOfFemale) AS NumFemale,SUM(numberOfMale) AS NumMale from Gym_Usage where usedDate like '%" + date + "%' ", sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Series series = new Series();

            try
            {
                while (sqlDataReader.Read())
                {
                    chartGymDailyGender.Series[0].Points.AddY(sqlDataReader.GetInt32(0));
                    chartGymDailyGender.Series[0].Points.AddY(sqlDataReader.GetInt32(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data for this day");
            }


            DBConnection.closeDBConnection();
        }


        private void DateTimePicker2Gym_ValueChanged(object sender, EventArgs e)
        {

            foreach (var series_1 in chartGymMonthlyNationality.Series)
            {
                series_1.Points.Clear();
            }

            foreach (var series_2 in chartGymMonthlyGender.Series)
            {
                series_2.Points.Clear();
            }



            DBConnection.openDBConnection();

            String date = dateTimePicker1Gym.Value.ToString("yyyy/MM");
            date = date.Replace("/", "-");


            SqlCommand sqlCommand1 = new SqlCommand("select count(nationality) from Gym_Usage where usedDate like '%" + date + "%' group by nationality", sqlcon);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            Series series1 = new Series();
            try
            {
                while (sqlDataReader1.Read())
                {
                    chartGymMonthlyNationality.Series[0].Points.AddY(sqlDataReader1.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data for this month");
            }

            /*            label25.Visible = true;
                        label26.Visible = true;*/
            sqlDataReader1.Close();

            SqlCommand sqlCommand = new SqlCommand("select SUM(numberOfFemale) AS NumFemale,SUM(numberOfMale) AS NumMale from Gym_Usage where usedDate like '%" + date + "%'", sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Series series = new Series();

            try
            {
                while (sqlDataReader.Read())
                {
                    chartGymMonthlyGender.Series[0].Points.AddY(sqlDataReader.GetInt32(0));
                    chartGymMonthlyGender.Series[0].Points.AddY(sqlDataReader.GetInt32(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data for this month");
            }

            label28.Visible = true;
            label29.Visible = true;

            DBConnection.closeDBConnection();
        }

        private void DemoBtnGymUsage_Click(object sender, EventArgs e)
        {
            cmbRoomGymUsage.SelectedIndex = 2;
            cmbNationalityGymUsage.SelectedIndex = 1;

            numOfAdultsGymUsage.Value = 2;
            numOfChildrenGymUsage.Value = 3;
            numOfMalesGymUsage.Value = 4;
            numOfFemalesGymUsage.Value = 1;

            chkNeedTrainerGymUsage.Checked = true;
        }

        private void DemoBtnGymTrainer_Click(object sender, EventArgs e)
        {
            txtFirstNameTrainer.Text = "Dinuka";
            txtLastNameTrainer.Text = "Shameera";
            txtNICTrainer.Text = "199712367432";
            dateDOBTrainer.Text = "20-sep-01";
            txtAddressLine1Trainer.Text = "Nisala Villa";
            txtAddressLine2Trainer.Text = "2nd cross road";
            txtCityTrainer.Text = "Battaramulla";
            cmbGenderTrainer.SelectedIndex = 1;
            txtContactNoTrainer.Text = "0774566543";
            txtEmailTrainer.Text = "dinuka@outlook.com";
            dateHiredTrainer.Text = "23-sep-18";
        }

        private void DemoBtnGymSupplier_Click(object sender, EventArgs e)
        {
            txtNameGymSupplier.Text = "Dinuka Shameera";
            txtAddressGymSupplier.Text = "Nisala Villa,2nd cross road,Makola"; 
            txtContactNoGymSupplier.Text = "01123454356";
            txtEmailGymSupplier.Text = "dinuka@outlook.com";

        }

        private void DemoBtnGymEquipment_Click(object sender, EventArgs e)
        {
            txtBrandGymEquipments.Text = "Quantum";
            txtModelNoGymEquipments.Text = "Q211";
            txtTypeGymEquipments.Text = "Dumbell";
            cmbSupplierGymEquipment.SelectedIndex = 1;
            UnitPriceGymEquipments.Value = 1000;
            QuantityGymEquipments.Value = 5;
            TotPriceGymEquipments.Value = 5000;
            dateGymEquipmentsPurchased.Text = "20-sep-19";

        }

        private void BtnViewReportGymUsage_Click(object sender, EventArgs e)
        {
            GetGymUsageReportForm getGymUsageReportForm = new GetGymUsageReportForm();
            getGymUsageReportForm.Show();
        }
    }
}