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
using customerManagementITP;

namespace SPA
{
    public partial class spaForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlcon = DBConnection.getConnection();
        Spa_Appointment appointment = new Spa_Appointment();
        Spa_Customer_Charges customer_Charges = new Spa_Customer_Charges();
        Spa_Service service = new Spa_Service();
        Spa_Employee Spa_Employee = new Spa_Employee();
        Spa_Products products = new Spa_Products();
        Spa_Equipment equipment = new Spa_Equipment();
        Spa_Supplier supplier = new Spa_Supplier();

        int serviceID = 0;
        int productId = 0;
        int equipmentId = 0;
        int paymentID = 0;
        int supplierId = 0;
        String Emp_ID = "";
        String appointmentID = "";
      
        public spaForm()
        {
            InitializeComponent();
            InitializeValuesForcmbAppoinment();
            InitializeValuesForcmbProductSupplierName();
            InitializeValuesForcmbEquipmentSupNames();
            InitializeValuesForcmbAppointmentNum();

            //Show DataSet
            DataViewSearchProduct();
            DataViewSearchEquipment();
            DataViewsSearchSupplier();
            DataViewSearchEmployee();
            DataViewsSearchService();
            DataViewSearchCustomerCharges();
            DataViewsSearchAppointent();

            
            nextEmployeetId();
            nextAppointmentId();


            txtUnitPriceProductSpa.Text = "0";
            txtUnitPriceEquipmentSpa.Text = "0";
        }
       
        //Appoinment
        public void InitializeValuesForcmbAppoinment() {

            try
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("select * from Accomodation where status = 'occupied' ", sqlcon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                cmbRoomNumSpa.ValueMember = "accID"; //accommodation id access to the cmbRoomNumber from Accommodation table
                cmbRoomNumSpa.DisplayMember = "accID";
                cmbRoomNumSpa.DataSource = dt;

                cmbCustomerType.SelectedIndex = 0;  //set customer type to Local as default value
                btnDeleteAppointment.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally {
                DBConnection.closeDBConnection();
            }
    }
        private void CmbRoomNumSpa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String roomId = cmbRoomNumSpa.Text.ToString();
            String custID = "";

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("select customer_id from Accomodation where accID = '" + roomId + "'", sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            sqlDataReader.Read();

            custID = Convert.ToString(sqlDataReader["customer_id"]);

            txtCustIDAppoinments.Text = custID;

            sqlDataReader.Close();

            DBConnection.closeDBConnection();

        }
        private void BtnSaveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAppoinmentIDSpa.Text.Trim() == "" || cmbRoomNumSpa.Text.Trim() == "" || txtCustIDAppoinments.Text.Trim() == "" || cmbCustomerType.Text.Trim() == ""
                    || txtCustomerName.Text.Trim() == "" || txtCustomerContactNumer.Text.Trim() == "" || numOfCustomerSpa.Text.Trim() == "" || cbFootMassage.Text.Trim() == ""
                    || numFootMassage.Text.Trim() == "" || cbHeadMassage.Text.Trim() == "" || numHeadMassage.Text.Trim() == "" || cbFullBodyMassage.Text.Trim() == ""
                    || numFullBodyMassage.Text.Trim() == "" || cbFacial.Text.Trim() == "" || numFacial.Text.Trim() == "" || dateAppoinmentSpa.Text.Trim() == "") 
                {
                    MessageBox.Show("Please enter details!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (txtCustomerContactNumer.Text.Length != 10)
                {
                    MessageBox.Show("Please Check Again!\n\nContact number should have only 10 numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    DBConnection.openDBConnection();


                    if (btnSaveAppointment.Text == "SAVE")
                    {
                        appointment.AppointmentNum = txtAppoinmentIDSpa.Text.Trim();
                        appointment.RoomNumber = cmbRoomNumSpa.Text.Trim();
                        appointment.CustomerId = int.Parse(txtCustIDAppoinments.Text.Trim());
                        appointment.Nationality = cmbCustomerType.Text.Trim();
                        appointment.CustomerName = txtCustomerName.Text.Trim();
                      
                        appointment.CustomerContactNumber = txtCustomerContactNumer.Text.Trim();

                        appointment.NeedHeadMassage = cbHeadMassage.Checked;

                        if (cbHeadMassage.Checked == true)
                        {
                            appointment.NumOfCumtomheadMassage_ = Convert.ToInt32(numHeadMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomheadMassage_ = 0;
                        }

                        appointment.NeedFootMassage = cbFootMassage.Checked;

                        if (cbFootMassage.Checked == true)
                        {
                            appointment.NumOfCumtomFootMassage_ = Convert.ToInt32(numFootMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFootMassage_ = 0;
                        }

                        appointment.NeedFullBodyMassage = cbFullBodyMassage.Checked;

                        if (cbFullBodyMassage.Checked == true)
                        {
                            appointment.NumOfCumtomFullBodyMassage_ = Convert.ToInt32(numFullBodyMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFullBodyMassage_ = 0;
                        }

                        appointment.NeedFacial = cbFacial.Checked;

                        if (cbFacial.Checked == true)
                        {
                            appointment.NumOfCumtomFacial_ = Convert.ToInt32(numFacial.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFacial_ = 0;
                        }

                        appointment.TotalnumOfCustomer = int.Parse(numOfCustomerSpa.Text.Trim());
                        appointment.AppointmentDate = dateAppoinmentSpa.Value.ToString();

                        appointment.saveAppointment();
                    }
                    else if (btnSaveAppointment.Text == "UPDATE")
                    {
                        appointment.AppointmentNum = txtAppoinmentIDSpa.Text.Trim();
                        appointment.RoomNumber = cmbRoomNumSpa.Text.Trim();
                        appointment.CustomerId = int.Parse(txtCustIDAppoinments.Text.Trim());
                        appointment.Nationality = cmbCustomerType.Text.Trim();
                        appointment.CustomerName = txtCustomerName.Text.Trim();                      
                        appointment.CustomerContactNumber = txtCustomerContactNumer.Text.Trim();

                        appointment.NeedHeadMassage = cbHeadMassage.Checked;

                        if (cbHeadMassage.Checked == true)
                        {
                            appointment.NumOfCumtomheadMassage_ = Convert.ToInt32(numHeadMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomheadMassage_ = 0;
                        }

                        appointment.NeedFootMassage = cbFootMassage.Checked;

                        if (cbFootMassage.Checked == true)
                        {
                            appointment.NumOfCumtomFootMassage_ = Convert.ToInt32(numFootMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFootMassage_ = 0;
                        }

                        appointment.NeedFullBodyMassage = cbFullBodyMassage.Checked;

                        if (cbFullBodyMassage.Checked == true)
                        {
                            appointment.NumOfCumtomFullBodyMassage_ = Convert.ToInt32(numFullBodyMassage.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFullBodyMassage_ = 0;
                        }

                        appointment.NeedFacial = cbFacial.Checked;

                        if (cbFacial.Checked == true)
                        {
                            appointment.NumOfCumtomFacial_ = Convert.ToInt32(numFacial.Text.Trim());
                        }
                        else
                        {
                            appointment.NumOfCumtomFacial_ = 0;
                        }

                        appointment.TotalnumOfCustomer = int.Parse(numOfCustomerSpa.Text.Trim());
                        appointment.AppointmentDate = dateAppoinmentSpa.Value.ToString();

                        appointment.AppointmentUpdate(appointmentID);
                    }
                    DataViewsSearchAppointent();
                    AppointmentReset();
                    InitializeValuesForcmbAppointmentNum();
                    nextAppointmentId();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void NumHeadMassage_Click(object sender, EventArgs e)
        {
            cbHeadMassage.Checked = true;
        }

        private void NumFootMassage_Click(object sender, EventArgs e)
        {
            cbFootMassage.Checked = true;
        }
        private void NumFacial_Click(object sender, EventArgs e)
        {
            cbFacial.Checked = true;
        }
        private void NumFullBodyMassage_Click(object sender, EventArgs e)
        {
            cbFullBodyMassage.Checked = true;
        }
        private void TxtCustomerContactNumer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//validation for customer contact number
            {
                e.Handled = true;
            }
        }
        private void TxtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //validation for customer name 
            {
                e.Handled = true;
            }
        }
        void DataViewsSearchAppointent()
        {
            appointment.AppointmentSearchText = txtSearchAppointmentSpa.Text.Trim();
            DataTable table = appointment.AppointmentDataView();
            dtGridAppointmentSpa.DataSource = table;
            
        }
        
    private void BtnSearchAppointmentSpa_Click(object sender, EventArgs e)
        {
            try
            {
                DataViewsSearchAppointent();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DtGridAppointment(object sender, EventArgs e)
        {
            if (dtGridAppointmentSpa.CurrentRow.Index != -1)
            {
                appointmentID = dtGridAppointmentSpa.CurrentRow.Cells[0].Value.ToString();

                txtAppoinmentIDSpa.Text = dtGridAppointmentSpa.CurrentRow.Cells[0].Value.ToString();
                cmbRoomNumSpa.Text = dtGridAppointmentSpa.CurrentRow.Cells[1].Value.ToString();
                txtCustIDAppoinments.Text = dtGridAppointmentSpa.CurrentRow.Cells[2].Value.ToString();          
                cmbCustomerType.Text = dtGridAppointmentSpa.CurrentRow.Cells[3].Value.ToString();
                txtCustomerName.Text = dtGridAppointmentSpa.CurrentRow.Cells[4].Value.ToString();
                txtCustomerContactNumer.Text = dtGridAppointmentSpa.CurrentRow.Cells[5].Value.ToString();
                numOfCustomerSpa.Text = dtGridAppointmentSpa.CurrentRow.Cells[14].Value.ToString();

                if (dtGridAppointmentSpa.CurrentRow.Cells[6].Value.ToString() == "True")
                {
                    cbHeadMassage.Checked = true;
                }
                else
                {
                    cbHeadMassage.Checked = false;
                }
                numHeadMassage.Text = dtGridAppointmentSpa.CurrentRow.Cells[7].Value.ToString();

                if (dtGridAppointmentSpa.CurrentRow.Cells[8].Value.ToString() == "True")
                {
                    cbFootMassage.Checked = true;
                }
                else
                {
                    cbFootMassage.Checked = false;
                }
                numFootMassage.Text = dtGridAppointmentSpa.CurrentRow.Cells[9].Value.ToString();

                if (dtGridAppointmentSpa.CurrentRow.Cells[10].Value.ToString() == "True")
                {
                    cbFullBodyMassage.Checked = true;
                }
                else {
                    cbFullBodyMassage.Checked = false;

                }
                numFullBodyMassage.Text = dtGridAppointmentSpa.CurrentRow.Cells[11].Value.ToString();

                if (dtGridAppointmentSpa.CurrentRow.Cells[12].Value.ToString() == "True")
                {
                    cbFacial.Checked = true;
                }
                else
                {
                    cbFacial.Checked = false;

                }
                numFacial.Text = dtGridAppointmentSpa.CurrentRow.Cells[13].Value.ToString();
                dateAppoinmentSpa.Text = dtGridAppointmentSpa.CurrentRow.Cells[15].Value.ToString();
                btnSaveAppointment.Text = "UPDATE";
                btnDeleteAppointment.Enabled = true;
            }
        }
        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want Delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                appointment.Spa_AppointmentDelete(appointmentID);
                DataViewsSearchAppointent();
                AppointmentReset();
            }
            DataViewsSearchAppointent();
            AppointmentReset();
            nextAppointmentId();
            InitializeValuesForcmbAppointmentNum();
        }
        void AppointmentReset()
        {

            btnSaveAppointment.Text = "SAVE";

            txtCustomerName.Text = txtCustomerContactNumer.Text = "";
            cmbRoomNumSpa.SelectedIndex = 0;
            cmbCustomerType.SelectedIndex = 0;
            numOfCustomerSpa.Value = numFootMassage.Value = numHeadMassage.Value = numFullBodyMassage.Value = numFacial.Value = 0;
            cbFootMassage.Checked = cbHeadMassage.Checked = cbFullBodyMassage.Checked = cbFacial.Checked = false;
            dateAppoinmentSpa.Value = DateTime.Today;


            String roomId = cmbRoomNumSpa.Text.ToString();
            String custID = "";

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("select customer_id from Accomodation where accID = '" + roomId + "'", sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            sqlDataReader.Read();

            custID = Convert.ToString(sqlDataReader["customer_id"]);

            txtCustIDAppoinments.Text = custID;

            sqlDataReader.Close();

            DBConnection.closeDBConnection();


        }
        private void BtnResetAppointment_Click(object sender, EventArgs e)
        {
            AppointmentReset();
        }
        //end Appoinment

        //Services
        private void ButnServiceSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtServiceName.Text.Trim() == "" || numHours.Text.Trim() == "" || numMinutes.Text.Trim() == "" || txtServicePrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details to empty fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
                else {
                    DBConnection.openDBConnection();

                    if (butnServiceSave.Text == "SAVE")
                    {
                        service.ServiceName = txtServiceName.Text.Trim();
                        service.Hours = numHours.Text.Trim();
                        service.Minutes = numMinutes.Text.Trim();
                        service.Price = float.Parse(txtServicePrice.Text.Trim());
                        service.ServiceSave();
                    }
                    else if (butnServiceSave.Text == "UPDATE")
                    {
                        service.ServiceName = txtServiceName.Text.Trim();
                        service.Hours = numHours.Text.Trim();
                        service.Minutes = numMinutes.Text.Trim();
                        service.Price = float.Parse(txtServicePrice.Text.Trim());
                        service.ServiceUpdate(serviceID);
                    }
                    DataViewsSearchService();
                    ServiceReset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void TxtServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }//validation For serviceCategory Name
        }
        private void TxtServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //validation For service Price
            {
                e.Handled = true;
            }
        }
        void DataViewsSearchService()
        {
            service.Searchtxt = txtSearchService.Text.Trim();
            DataTable table = service.ServiceView();
            dtGridService.DataSource = table;
            dtGridService.Columns[0].Visible = false;

            butnServDelete.Enabled = false;
        }
        private void ButnSearchService__Click(object sender, EventArgs e)
        {
            try {
                DataViewsSearchService();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DatGridService__DoubleClick(object sender, EventArgs e)
        {
            if (dtGridService.CurrentRow.Index != -1)
            {
                serviceID = int.Parse(dtGridService.CurrentRow.Cells[0].Value.ToString());
                txtServiceName.Text = dtGridService.CurrentRow.Cells[1].Value.ToString();
                numHours.Text = dtGridService.CurrentRow.Cells[2].Value.ToString();  
                numMinutes.Text = dtGridService.CurrentRow.Cells[3].Value.ToString();  
                txtServicePrice.Text = dtGridService.CurrentRow.Cells[4].Value.ToString();
           
                butnServiceSave.Text = "UPDATE";
                butnServDelete.Enabled = true;
            }
        }
        private void ButnDeleteSearch__Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want Delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                service.ServiceDelete(serviceID);
                DataViewsSearchService();
                ServiceReset();
            }
        }
        void ServiceReset()
        {
            txtServiceName.Text =  txtServicePrice.Text ="";
            numHours.Value = numMinutes.Value = 0;
            butnServiceSave.Text = "SAVE";
        }
        private void ButonReset_Click(object sender, EventArgs e)
        {
            ServiceReset();
        }//end Service 

        //Supplier
        private void BtnSaveSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text.Trim() == "" || txtSupplierNic.Text.Trim() == "" || cmbSupplierType.Text.Trim() == ""|| txtSupAddressLine1.Text.Trim() == "" ||txtSupAddressLine2.Text.Trim() == ""
                    || txtCityTwon.Text.Trim() == "" || txtSupplierPhone.Text.Trim() == "" || txtSupplierEmail.Text.Trim() == "" || txtSupDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSupplierNic.Text.Length != 10 && txtSupplierNic.Text.Length != 12 )
                {
                    MessageBox.Show("Please Check Again Nic Number!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);                 
                }
                else if (!Regex.IsMatch(txtCityTwon.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Please Check Again!\n\nCity should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSupplierPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please Check Again!\n\nContact number should have only 10 numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidSupplierEmail(txtSupplierEmail.Text))
                {
                    MessageBox.Show("Please Check Again!\n\nEmail is not in correct structure", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtSupDescription.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Please Check Again!\n\nDescription should be in letters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DBConnection.openDBConnection();
                    if (btnSaveSuppliers.Text == "SAVE")
                    {
                        supplier.SupplierName = txtSupplierName.Text.Trim();
                        supplier.SupplierNic = txtSupplierNic.Text.Trim();
                        supplier.SupplierType = cmbSupplierType.Text.Trim();
                        supplier.SaddressLine1 = txtSupAddressLine1.Text.Trim();
                        supplier.SaddressLine2 = txtSupAddressLine2.Text.Trim();
                        supplier.City_Twon = txtCityTwon.Text.Trim();
                        supplier.SupplierPhone = txtSupplierPhone.Text.Trim();
                        supplier.SupplierEmail = txtSupplierEmail.Text.Trim();
                        supplier.Description = txtSupDescription.Text.Trim();
                        supplier.SaveSupplier();
                    }
                    else if (btnSaveSuppliers.Text == "UPDATE")
                    {
                        supplier.SupplierName = txtSupplierName.Text.Trim();
                        supplier.SupplierNic = txtSupplierNic.Text.Trim();
                        supplier.SupplierType = cmbSupplierType.Text.Trim();
                        supplier.SaddressLine1 = txtSupAddressLine1.Text.Trim();
                        supplier.SaddressLine2 = txtSupAddressLine2.Text.Trim();
                        supplier.City_Twon = txtCityTwon.Text.Trim();
                        supplier.SupplierPhone = txtSupplierPhone.Text.Trim();
                        supplier.SupplierEmail = txtSupplierEmail.Text.Trim();
                        supplier.Description = txtSupDescription.Text.Trim();
                        supplier.SupplierUpdate(supplierId);
                    }
                    DataViewsSearchSupplier();
                    supplierReset();
                }
                InitializeValuesForcmbProductSupplierName();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Used this NIC \nplease check Again  ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void TxtSupplierName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //validation for supplier 
            {
                e.Handled = true;
            }
        }  
        private void TxtSupplierPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//validation for supplier contact number
            {
                e.Handled = true;
            }
        }
        bool IsValidSupplierEmail(string supplierEmail)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(supplierEmail);//validation for supplierEmail
                return mailAddress.Address == supplierEmail;
            }
            catch
            {
                return false;
            }
        }
        void DataViewsSearchSupplier()
        {
            supplier.Searchtxt = txtSearchSupppliers.Text.Trim();
            DataTable table = supplier.SupplierView();
            dtGridSuppliers.DataSource = table;
            dtGridSuppliers.Columns[0].Visible = false;

            btnDeleteSuppliers.Enabled = false;
            cmbSupplierType.SelectedIndex = 0;
        }
        private void BtnSearchSuppliers_Click(object sender, EventArgs e)
        {
            try
            {

                DataViewsSearchSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DatGridSupplier(object sender, EventArgs e)
        {
            if (dtGridSuppliers.CurrentRow.Index != -1)
            {
                supplierId = int.Parse(dtGridSuppliers.CurrentRow.Cells[0].Value.ToString()); 

                txtSupplierName.Text = dtGridSuppliers.CurrentRow.Cells[1].Value.ToString();
                txtSupplierNic.Text = dtGridSuppliers.CurrentRow.Cells[2].Value.ToString();
                cmbSupplierType.Text = dtGridSuppliers.CurrentRow.Cells[3].Value.ToString();
                txtSupAddressLine1.Text = dtGridSuppliers.CurrentRow.Cells[4].Value.ToString();
                txtSupAddressLine2.Text = dtGridSuppliers.CurrentRow.Cells[5].Value.ToString();
                txtCityTwon.Text = dtGridSuppliers.CurrentRow.Cells[6].Value.ToString();
                txtSupplierPhone.Text = dtGridSuppliers.CurrentRow.Cells[7].Value.ToString();
                txtSupplierEmail.Text = dtGridSuppliers.CurrentRow.Cells[8].Value.ToString();
                txtSupDescription.Text = dtGridSuppliers.CurrentRow.Cells[9].Value.ToString();

                btnSaveSuppliers.Text = "UPDATE";
                btnDeleteSuppliers.Enabled = true;
            }
           
        }
        private void BtnDeleteSuppliers_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want Delete", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                supplier.SupplierDelete(supplierId);
                DataViewsSearchSupplier();
                supplierReset();
            }
        }
        void supplierReset() {
            //reset filled feilds
            
            txtSupplierName.Text = txtSupplierNic.Text = txtSupAddressLine1.Text = txtSupAddressLine2.Text = txtCityTwon.Text = txtSupplierPhone.Text = txtSupplierEmail.Text = txtSupDescription.Text = " ";
            cmbSupplierType.SelectedIndex = 0;
            btnSaveSuppliers.Text = "SAVE";
        }

        private void BtnRsetSuppliers_Click(object sender, EventArgs e)
        {
            supplierReset();
        }//end supplier 

        //Product
        public void InitializeValuesForcmbProductSupplierName()
        {
            try
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("select * from Spa_Supplier", sqlcon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                cmbProductSupplierName.ValueMember = "supplierNic"; 
                cmbProductSupplierName.DisplayMember = "supplierNic"; 
                cmbProductSupplierName.DataSource = dt;
                btnDeleteProduct.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void BtnSaveProdut_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductBrandName.Text.Trim() == "" || txtProductType.Text.Trim() == "" || txtProductModelName.Text.Trim() == "" || cmbProductSupplierName.Text.Trim() == ""
                    || txtUnitPriceProductSpa.Text.Trim() == ""|| numOfProductSpa.Text.Trim() == "" || txtProductPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DBConnection.openDBConnection();

                    if (btnSaveProdut.Text == "SAVE")
                    {
                        products.BrandName = txtProductBrandName.Text.Trim();
                        products.ProductType = txtProductType.Text.Trim();
                        products.ModelName = txtProductModelName.Text.Trim();
                        products.SupplierNic = cmbProductSupplierName.Text.Trim();
                        products.UnitPriceProduct = float.Parse(txtUnitPriceProductSpa.Text.Trim());
                        products.Quty = int.Parse(numOfProductSpa.Text.Trim());
                        products.PPrice = float.Parse(txtProductPrice.Text.Trim());
                        products.ProductDate = DateProduct.Value.ToString();
        
                        products.productSave();
                    }

                    else if (btnSaveProdut.Text == "UPDATE")
                    {
                        products.BrandName = txtProductBrandName.Text.Trim();
                        products.ProductType = txtProductType.Text.Trim();
                        products.ModelName = txtProductModelName.Text.Trim();
                        products.SupplierNic = cmbProductSupplierName.Text.Trim();
                        products.UnitPriceProduct = float.Parse(txtUnitPriceProductSpa.Text.Trim());
                        products.Quty = int.Parse(numOfProductSpa.Text.Trim());
                        products.PPrice = float.Parse(txtProductPrice.Text.Trim());
                        products.ProductDate = DateProduct.Value.ToString();
                        products.ProductUpdate(productId);
                    }
                    DataViewSearchProduct();
                    ProductReset();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void TxtProductBrandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //validation For brandName
            }
        }
        private void TxtProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;       //Validation ProductType     
            }
        }
        private void TxtProductModelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);//validation ProductModelName
        }
        private void TxtUnitPriceProductSpa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //validation For Product unit Price
            {
                e.Handled = true;
            }
        }
        private void TxtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) //validation For Product unit Price
            {
                e.Handled = true;
            }
        }
        private void NumOfProductSpa_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtProductPrice.Text = Convert.ToString(float.Parse(txtUnitPriceProductSpa.Text) * Convert.ToInt32(numOfProductSpa.Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void TxtUnitPriceProductSpa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtUnitPriceProductSpa.Text == "")
                {
                    //nothing happen
                }
                else
                {
                    txtProductPrice.Text = Convert.ToString(float.Parse(txtUnitPriceProductSpa.Text) * Convert.ToInt32(numOfProductSpa.Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        void DataViewSearchProduct()
        {
            products.ProductSearchtxt = txtSearchProducts.Text.Trim();
            DataTable table = products.ProductDataView();
            dtGridProducts.DataSource = table;
            dtGridProducts.Columns[0].Visible = false;
        }
        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            try
            {
                DataViewSearchProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DatGridProduct(object sender, EventArgs e)
        {
            if (dtGridProducts.CurrentRow.Index != -1)
            {
                productId = int.Parse(dtGridProducts.CurrentRow.Cells[0].Value.ToString());

                DateProduct.Text = dtGridProducts.CurrentRow.Cells[1].Value.ToString();
                txtProductBrandName.Text = dtGridProducts.CurrentRow.Cells[2].Value.ToString();
                txtProductType.Text = dtGridProducts.CurrentRow.Cells[3].Value.ToString();
                txtProductModelName.Text = dtGridProducts.CurrentRow.Cells[4].Value.ToString();
                cmbProductSupplierName.Text = dtGridProducts.CurrentRow.Cells[5].Value.ToString();
                txtUnitPriceProductSpa.Text = dtGridProducts.CurrentRow.Cells[6].Value.ToString();
                numOfProductSpa.Text = dtGridProducts.CurrentRow.Cells[7].Value.ToString();
                txtProductPrice.Text = dtGridProducts.CurrentRow.Cells[8].Value.ToString();
                

                btnSaveProdut.Text = "UPDATE";
                btnDeleteProduct.Enabled = true;
            }
        }
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                products.ProductDelete(productId);
                DataViewSearchProduct();
                ProductReset();
            }
        }
        void ProductReset()
        {
            txtProductBrandName.Text = txtProductType.Text = txtProductModelName.Text = "";
            cmbProductSupplierName.SelectedIndex = 0;
            txtUnitPriceProductSpa.Text = "0";
            numOfProductSpa.Value = 0;
            txtProductPrice.Text = "0";
            btnSaveProdut.Text = "SAVE";
        }
        private void BtnResetProdut_Click(object sender, EventArgs e)
        {
            ProductReset();
        }//end Product

        //Equipment
        public void InitializeValuesForcmbEquipmentSupNames()
        {
            try
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("select * from Spa_Supplier", sqlcon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                cmbEquipmentSupNames.ValueMember = "supplierNic";
                cmbEquipmentSupNames.DisplayMember = "supplierNic";
                cmbEquipmentSupNames.DataSource = dt;
                btnDeleteEquipment.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
       
        private void BtnSaveEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEquBrandName.Text.Trim() == "" || txtEquipmentType.Text.Trim() == "" || txtEquModelNumber.Text.Trim() == "" || cmbEquipmentSupNames.Text.Trim() == ""
                    || txtUnitPriceEquipmentSpa.Text.Trim() == "" || numOfEquipmentSpa.Text.Trim() == "" || txtEquipmentPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtEquModelNumber.Text.Length != 5)
                {
                    MessageBox.Show("Equipment Model number should have only 5 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DBConnection.openDBConnection();

                    if (btnSaveEquipment.Text == "SAVE")
                    {
                        equipment.BrandName = txtEquBrandName.Text.Trim();
                        equipment.EquipmentType = txtEquipmentType.Text.Trim();
                        equipment.ModelNumber = txtEquModelNumber.Text.Trim();
                        equipment.SupplierNic = cmbEquipmentSupNames.Text.Trim();
                        equipment.EunitPrice = float.Parse(txtUnitPriceEquipmentSpa.Text.Trim());
                        equipment.NumOfEquipment = int.Parse(numOfEquipmentSpa.Text.Trim());
                        equipment.EPrice = float.Parse(txtEquipmentPrice.Text.Trim());
                        equipment.equipmentSave();
                    }

                    else if (btnSaveEquipment.Text == "UPDATE")
                    {
                        equipment.BrandName = txtEquBrandName.Text.Trim();
                        equipment.EquipmentType = txtEquipmentType.Text.Trim();
                        equipment.ModelNumber = txtEquModelNumber.Text.Trim();
                        equipment.SupplierNic = cmbEquipmentSupNames.Text.Trim();
                        equipment.EunitPrice = float.Parse(txtUnitPriceEquipmentSpa.Text.Trim());
                        equipment.NumOfEquipment = int.Parse(numOfEquipmentSpa.Text.Trim());
                        equipment.EPrice = float.Parse(txtEquipmentPrice.Text.Trim());
                        equipment.equipmentUpdate(equipmentId);
                    }
                    DataViewSearchEquipment();
                    EquipmentReset();
                    InitializeValuesForcmbEquipmentSupNames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void TxtEquBrandName_KeyPress(object sender, KeyPressEventArgs e)//validation for EquipmentBrandName 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtEquipmentType_KeyPress(object sender, KeyPressEventArgs e) //validation for EquipmentType
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtEquModelNumber_KeyPress(object sender, KeyPressEventArgs e) //validation for EquModelNumber 
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private void TxtUnitPriceEquipmentSpa_KeyPress(object sender, KeyPressEventArgs e) //validation for UnitPriceEquipment
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
        private void TxtEquipmentPrice_KeyPress(object sender, KeyPressEventArgs e)//validation for EquipmentPrice
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void NumOfEquipmentSpa_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentPrice.Text = Convert.ToString(float.Parse(txtUnitPriceEquipmentSpa.Text) * Convert.ToInt32(numOfEquipmentSpa.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void TxtUnitPriceEquipmentSpa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitPriceEquipmentSpa.Text == "")
                {
                    //nothing happen
                }
                else
                {
                    txtEquipmentPrice.Text = Convert.ToString(float.Parse(txtUnitPriceEquipmentSpa.Text) * Convert.ToInt32(numOfEquipmentSpa.Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void DataViewSearchEquipment()
        {
            equipment.EquipmentSearchTxt = txtSearchEquipment.Text.Trim();
            DataTable table = equipment.equipmentDataView();
            dtGridEquipment.DataSource = table;
            dtGridEquipment.Columns[0].Visible = false;
        }

        private void BtnSearchEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                DataViewSearchEquipment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DtGridEquipment(object sender, EventArgs e)
        {
            if (dtGridEquipment.CurrentRow.Index != -1)
            {
                equipmentId = int.Parse(dtGridEquipment.CurrentRow.Cells[0].Value.ToString());
                txtEquBrandName.Text = dtGridEquipment.CurrentRow.Cells[1].Value.ToString();
                txtEquipmentType.Text = dtGridEquipment.CurrentRow.Cells[2].Value.ToString();
                txtEquModelNumber.Text = dtGridEquipment.CurrentRow.Cells[3].Value.ToString();
                cmbEquipmentSupNames.Text = dtGridEquipment.CurrentRow.Cells[4].Value.ToString();
                txtUnitPriceEquipmentSpa.Text = dtGridEquipment.CurrentRow.Cells[5].Value.ToString();
                numOfEquipmentSpa.Text = dtGridEquipment.CurrentRow.Cells[6].Value.ToString();
                txtEquipmentPrice.Text = dtGridEquipment.CurrentRow.Cells[7].Value.ToString();

                btnSaveEquipment.Text = "UPDATE";
                btnDeleteEquipment.Enabled = true;
            }
        }
        private void BtnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                equipment.equipmentDelete(equipmentId);
                DataViewSearchEquipment();
                EquipmentReset();
            }
        }

        void EquipmentReset() //create reset method
        {

            txtEquBrandName.Text = txtEquipmentType.Text = txtEquModelNumber.Text = "";
            cmbEquipmentSupNames.SelectedIndex = 0;
            txtUnitPriceEquipmentSpa.Text = "0";
            numOfEquipmentSpa.Value = 0;
            txtEquipmentPrice.Text = "0";
            btnSaveEquipment.Text = "SAVE";
        }
        private void BtnResetEquipment_Click(object sender, EventArgs e)
        {
            //reset method call in to the reset button
            EquipmentReset();
        }//equipment

        //Employee
        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpId.Text.Trim() == "" || txtEmpFirstName.Text.Trim() == "" || txtEmpLastName.Text.Trim() == "" || DateTimeEmpDOB.Text.Trim() == ""
                    || txtEmpNic.Text.Trim() == "" || cmbEmpGender.Text.Trim() == "" || txtEmpEmail.Text.Trim() == "" || txtEmpPhone.Text.Trim() == ""
                    || txtEmpAddressLine1.Text.Trim() == "" || txtEmpAddressLine2.Text.Trim() == "" || DateTimeEmpHired.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtEmpNic.Text.Length != 10 && txtEmpNic.Text.Length != 12)
                {
                    MessageBox.Show("Please Check Again Nic Number!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!IsValidEmployeeEmail(txtEmpEmail.Text))
                {
                    MessageBox.Show("Please Check Again!\n\nEmail is not in correct structure", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtEmpPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please Check Again!\n\nContact number should have only 10 numbers", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DBConnection.openDBConnection();

                    if (btnSaveEmployee.Text == "SAVE")
                    {
                        Spa_Employee.EmpID = txtEmpId.Text.Trim();
                        Spa_Employee.FirstName = txtEmpFirstName.Text.Trim();
                        Spa_Employee.LastName = txtEmpLastName.Text.Trim();
                        Spa_Employee.NIC_ = txtEmpNic.Text.Trim();
                        Spa_Employee.DOB_ = DateTimeEmpDOB.Text.Trim().ToString();
                        Spa_Employee.Gender_ = cmbEmpGender.Text.Trim();
                        Spa_Employee.Email_ = txtEmpEmail.Text.Trim();
                        Spa_Employee.ContactNo = txtEmpPhone.Text.Trim();
                        Spa_Employee.AddressLine1 = txtEmpAddressLine1.Text.Trim();
                        Spa_Employee.AddressLine2 = txtEmpAddressLine2.Text.Trim();
                        Spa_Employee.DateHired = DateTimeEmpHired.Text.Trim().ToString();
                        Spa_Employee.SaveEmployee();
                    }

                    else if (btnSaveEmployee.Text == "UPDATE")
                    {
                        Spa_Employee.EmpID = txtEmpId.Text.Trim();
                        Spa_Employee.FirstName = txtEmpFirstName.Text.Trim();
                        Spa_Employee.LastName = txtEmpLastName.Text.Trim();
                        Spa_Employee.NIC_ = txtEmpNic.Text.Trim();
                        Spa_Employee.DOB_ = DateTimeEmpDOB.Text.Trim().ToString();
                        Spa_Employee.Gender_ = cmbEmpGender.Text.Trim();
                        Spa_Employee.Email_ = txtEmpEmail.Text.Trim();
                        Spa_Employee.ContactNo = txtEmpPhone.Text.Trim();
                        Spa_Employee.AddressLine1 = txtEmpAddressLine1.Text.Trim();
                        Spa_Employee.AddressLine2 = txtEmpAddressLine2.Text.Trim();
                        Spa_Employee.DateHired = DateTimeEmpHired.Text.Trim().ToString();
                        Spa_Employee.EmployeeUpdate(Emp_ID);
                    }
                    EmployeeReset();
                    DataViewSearchEmployee();
                    nextEmployeetId();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Already used this Emp_Id \n\nplease check Again  ","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        private void TxtEmpId_KeyPress(object sender, KeyPressEventArgs e)  

        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }//validation for Employee First Name
        private void TxtEmpFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            } //validation for Employee First Name
        }
        private void TxtEmpLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //validation for Employee First Name
            {
                e.Handled = true;
            } //validation for Employee Last Name
        }
        bool IsValidEmployeeEmail(string employeeEmil)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(employeeEmil);
                return mail.Address == employeeEmil;
            }
            catch
            {
                return false;
            } //validation for Employee Email
        }
        private void TxtEmpPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            } //validation for employee contact number
        }
        void DataViewSearchEmployee()
        {
            Spa_Employee.SearchText = txtSearchEmployee.Text.Trim();
            DataTable table = Spa_Employee.EmployeeDataView();
            dtGridEmployee.DataSource = table;
            dtGridEmployee.Columns[0].Visible = false;
          
            cmbEmpGender.SelectedIndex = 0;
        }
        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DataViewSearchEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void DtGridEmployee(object sender, EventArgs e)
        {
            if (dtGridEmployee.CurrentRow.Index != -1)
            {
                Emp_ID = dtGridEmployee.CurrentRow.Cells[0].Value.ToString();

                txtEmpId.Text = dtGridEmployee.CurrentRow.Cells[0].Value.ToString();
                txtEmpFirstName.Text = dtGridEmployee.CurrentRow.Cells[1].Value.ToString();
                txtEmpLastName.Text = dtGridEmployee.CurrentRow.Cells[2].Value.ToString();
                txtEmpNic.Text = dtGridEmployee.CurrentRow.Cells[3].Value.ToString();
                DateTimeEmpDOB.Text = dtGridEmployee.CurrentRow.Cells[4].Value.ToString();

                cmbEmpGender.Text = dtGridEmployee.CurrentRow.Cells[5].Value.ToString();

                txtEmpEmail.Text = dtGridEmployee.CurrentRow.Cells[6].Value.ToString();
                txtEmpPhone.Text = dtGridEmployee.CurrentRow.Cells[7].Value.ToString();
                txtEmpAddressLine1.Text = dtGridEmployee.CurrentRow.Cells[8].Value.ToString();
                txtEmpAddressLine2.Text = dtGridEmployee.CurrentRow.Cells[9].Value.ToString();
                DateTimeEmpHired.Text = dtGridEmployee.CurrentRow.Cells[13].Value.ToString();

                btnSaveEmployee.Text = "UPDATE";
                btnDeleteEmployee.Enabled = true;
            }
        }
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Spa_Employee.Spa_EmployeeDelete(Emp_ID);
                DataViewSearchEmployee();
                EmployeeReset();
                nextEmployeetId();

            }
        }
        void EmployeeReset() {
            //reset the filled feild
            txtEmpFirstName.Text = txtEmpLastName.Text = DateTimeEmpDOB.Text = txtEmpNic.Text = cmbEmpGender.Text =
            txtEmpEmail.Text = txtEmpPhone.Text = txtEmpAddressLine1.Text = txtEmpAddressLine2.Text = DateTimeEmpHired.Text = "";
            btnSaveEmployee.Text = "SAVE";
        }
        private void BtnResetEmployee_Click(object sender, EventArgs e)
        {   //reset method call in to the reset button
            EmployeeReset();
            nextEmployeetId();
        }
        //end employee function

        //Customer Charges
        public void InitializeValuesForcmbAppointmentNum() {

            try
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("select * from Spa_Appointment", sqlcon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                cmbChargesAppointmentId.ValueMember = "appointmentNum"; //accommodation id access to the cmbRoomNumber from Accommodation table
                cmbChargesAppointmentId.DisplayMember = "appointmentNum";
                cmbChargesAppointmentId.DataSource = dt;

                //cmbChargesAppointmentId.SelectedIndex = 0;  //set customer type to Local as default value
                btnDeleteChargesSpa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }

        private void BtnSaveChargesSpa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbChargesAppointmentId.Text.Trim() == "" || txtChargesCustomerId.Text.Trim() == "" || txtChargesNoOfCustomer.Text.Trim() == "" || txtTotSpaCharges.Text.Trim() == ""
                    || txtDiscountSpaCharges.Text.Trim() == "" || txtTotAmountSpaCharges.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter details", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    DBConnection.openDBConnection();

                    if (btnSaveChargesSpa.Text == "SAVE")
                    {
                        customer_Charges.AppointmentID = cmbChargesAppointmentId.Text.Trim();
                        customer_Charges.CustomerID = int.Parse(txtChargesCustomerId.Text.Trim());
                        customer_Charges.NumberOfCustomers = int.Parse(txtChargesNoOfCustomer.Text.Trim());
                        customer_Charges.ServicePrice = float.Parse(txtTotSpaCharges.Text.Trim());
                        customer_Charges.Discount = float.Parse(txtDiscountSpaCharges.Text.Trim().ToString());
                        customer_Charges.TotalAmount = float.Parse(txtTotAmountSpaCharges.Text.Trim().ToString());

                        customer_Charges.CustomerChargesSave();
                    }

                    else if (btnSaveChargesSpa.Text == "UPDATE")
                    {
                        customer_Charges.AppointmentID = cmbChargesAppointmentId.Text.Trim();
                        customer_Charges.CustomerID = int.Parse(txtChargesCustomerId.Text.Trim());
                        customer_Charges.NumberOfCustomers = int.Parse(txtChargesNoOfCustomer.Text.Trim());
                        customer_Charges.ServicePrice = float.Parse(txtTotSpaCharges.Text.Trim());
                        customer_Charges.Discount = float.Parse(txtDiscountSpaCharges.Text.Trim().ToString());
                        customer_Charges.TotalAmount = float.Parse(txtTotAmountSpaCharges.Text.Trim().ToString());

                        customer_Charges.CustomerChargesUpdate(paymentID);
                    }
                    CustomerChargesReset();
                    DataViewSearchCustomerCharges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }
        void DataViewSearchCustomerCharges()
        {
            customer_Charges.CustomerChargesSearchTxt = txtViewSearchCustmCharges.Text.Trim();
            DataTable table = customer_Charges.CustomerChargesDataView();
            dtGridCustCharges.DataSource = table;
            dtGridCustCharges.Columns[0].Visible = false;

        }
        private void BtnSearchCustm_Click(object sender, EventArgs e)
        {
            try
            {
                DataViewSearchCustomerCharges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void DtGridCustCharges_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridCustCharges.CurrentRow.Index != -1)
            {
                paymentID = int.Parse(dtGridCustCharges.CurrentRow.Cells[0].Value.ToString());

                cmbChargesAppointmentId.Text = dtGridCustCharges.CurrentRow.Cells[1].Value.ToString();
                txtChargesCustomerId.Text = dtGridCustCharges.CurrentRow.Cells[2].Value.ToString();
                txtChargesNoOfCustomer.Text = dtGridCustCharges.CurrentRow.Cells[3].Value.ToString();
                txtTotSpaCharges.Text = dtGridCustCharges.CurrentRow.Cells[4].Value.ToString();
                txtDiscountSpaCharges.Text = dtGridCustCharges.CurrentRow.Cells[5].Value.ToString();
                txtTotAmountSpaCharges.Text = dtGridCustCharges.CurrentRow.Cells[6].Value.ToString();

                btnSaveChargesSpa.Text = "UPDATE";
                btnDeleteChargesSpa.Enabled = true;
            }
        }
        private void BtnDeleteChargesSpa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want to Delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // dtGridCustCharges.CustomerChargesDelete(paymentID);
                customer_Charges.CustomerChargesDelete(paymentID);
                DataViewSearchCustomerCharges();
                CustomerChargesReset();

            }
        }
        void CustomerChargesReset()
        {
            cmbChargesAppointmentId.SelectedIndex = 0;
            txtChargesCustomerId.Text = "";
            txtChargesNoOfCustomer.Text = "0"; 
            txtTotSpaCharges.Text = "0";
            txtDiscountSpaCharges.Text = "0";
            txtTotAmountSpaCharges.Text = "0";
            btnSaveChargesSpa.Text = "SAVE";
        }
        private void BtnResetChargesSpa_Click(object sender, EventArgs e)
        {
            CustomerChargesReset();
        }
        private void SPADemoService_Click(object sender, EventArgs e)
        {
            txtServiceName.Text = "Fish Massage";
            numHours.Value = 2;
            numMinutes.Value = 20;
            txtServicePrice.Text = "1500";

        }

        private void BtnDemo_Click(object sender, EventArgs e)
        {
            cmbRoomNumSpa.SelectedIndex = 1;
            //txtCustIDAppoinments.Text = "8";
            cmbCustomerType.SelectedIndex = 1;
            txtCustomerName.Text = "A.M.Silva";
            txtCustomerContactNumer.Text = "0779876542";
            numOfCustomerSpa.Value = 6;
            cbHeadMassage.Checked = true;
            numHeadMassage.Value = 3;
            cbFootMassage.Checked = true;
            numFootMassage.Value = 3;
            dateAppoinmentSpa.Text = "26-Sep-19";
        }

        private void BtnempDemo_Click(object sender, EventArgs e)
        {    
            txtEmpFirstName.Text = "Amal";
            txtEmpLastName.Text = "Perera";
            txtEmpNic.Text = "912345758V";
            DateTimeEmpDOB.Text = "21-jul-91";
            cmbEmpGender.SelectedIndex = 1;
            txtEmpEmail.Text = "amal@gmail.com";
            txtEmpPhone.Text = "0712210489";
            txtEmpAddressLine1.Text = "56/A";
            txtEmpAddressLine2.Text = "Homagama";
            DateTimeEmpHired.Text = "23-Jan-18";

        }
        private void BtnSupplierDemo_Click(object sender, EventArgs e)
        {
            txtSupplierName.Text = "Indika Fernando";
            txtSupplierNic.Text = "731987653V";
            cmbSupplierType.SelectedIndex = 1;
            txtSupAddressLine1.Text = "Neture's Secrets";
            txtSupAddressLine2.Text = "No : 12, Dutch Hospital Arcade";
            txtCityTwon.Text = "Colombo 02";
            txtSupplierPhone.Text = "0112233773";
            txtSupplierEmail.Text = "indika@gmail.com";
            txtSupDescription.Text = "Hiar oil - 10  " 
                +"Face Wash - 15";

        }

        private void BtnProductDemo_Click(object sender, EventArgs e)
        {
            txtProductBrandName.Text = "Nature's Secret";
            txtProductType.Text = "Hair oil";
            txtProductModelName.Text = "Hurbal oil";
            cmbProductSupplierName.SelectedIndex = 1;
            txtUnitPriceProductSpa.Text = "5000";
            numOfProductSpa.Value = 5;
            txtProductPrice.Text = "25000";
        }

        private void BtnEquipmentDemo_Click(object sender, EventArgs e)
        {
            txtEquBrandName.Text = "Damro";
            txtEquipmentType.Text = "Chairs";
            txtEquModelNumber.Text = "CH101";
            cmbEquipmentSupNames.SelectedIndex = 1;
            txtUnitPriceEquipmentSpa.Text = "2500";
            numOfEquipmentSpa.Value = 5;
            txtEquipmentPrice.Text = "12500";
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            label1.Text = "1 = Foreign";
            label2.Text = "2 = Local";
            label3.Text = "";
            label4.Text = "";



            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            DBConnection.openDBConnection();

            String date = dateTimePicker1Spa.Value.ToString("yyyy-MM-dd");

            SqlCommand sqlCommand = new SqlCommand("select sum(numOfCustomers) from Spa_Appointment where appoinmentDate_ LIKE '%"+ date + "%'  group by nationality", sqlcon);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Series series1 = new Series();

            while (sqlDataReader.Read()) {

                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(0));
            }

            DBConnection.closeDBConnection();
        }

        private void BtnServiceChatrs_Click(object sender, EventArgs e)
        {

            label1.Text = "1 = Facial";
            label2.Text = "2 = Foot Massage";
            label3.Text = "3 = Full body Massage";
            label4.Text = "4 = Head Massage";


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            DBConnection.openDBConnection();

            String date = "";

            SqlCommand sqlCommand = new SqlCommand(" select sum(numOfCustomersFacial),sum(numOfCustomersFootMassage),sum(numOfCustomersFullBodyMassage), sum(numOfCustomersHeadMassage) from Spa_Appointment where appoinmentDate_ LIKE '%"+date+"%' ", sqlcon);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Series series1 = new Series();

            while (sqlDataReader.Read())
            {
                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(0));
                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(1));
                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(2));
                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(3));
            }

            DBConnection.closeDBConnection();
        }

        private void CmbChargesAppointmentId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String appointmentID = cmbChargesAppointmentId.Text.ToString();
            String customerId = "";
            String numberOfCustomers = "";
            double serviceCharge = 0;
            double discount = 0;

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("select customer_Id from Spa_Appointment where appointmentNum like '" + appointmentID + "'", sqlcon);
            SqlCommand sqlCommand1 = new SqlCommand("select numOfCustomers from Spa_Appointment where appointmentNum like '" + appointmentID + "'", sqlcon);
            SqlCommand sqlCommand2 = new SqlCommand("select total from Spa_Appointment where appointmentNum like '" + appointmentID + "'", sqlcon);
            SqlCommand sqlCommand3 = new SqlCommand("select discount from Spa_Appointment where appointmentNum like '" + appointmentID + "'", sqlcon);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            customerId = Convert.ToString(sqlDataReader["customer_Id"]);
            sqlDataReader.Close();

            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            sqlDataReader1.Read();
            numberOfCustomers = Convert.ToString(sqlDataReader1["numOfCustomers"]);
            sqlDataReader1.Close();

            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            sqlDataReader2.Read();
            serviceCharge = Convert.ToDouble(sqlDataReader2["total"]);
            sqlDataReader2.Close();

            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            sqlDataReader3.Read();
            discount = Convert.ToDouble(sqlDataReader3["discount"]);
            sqlDataReader3.Close();
            
            txtChargesCustomerId.Text = customerId;
            txtChargesNoOfCustomer.Text = numberOfCustomers;
            txtTotSpaCharges.Text = serviceCharge.ToString();
            txtDiscountSpaCharges.Text = discount.ToString();
            txtTotAmountSpaCharges.Text = (serviceCharge - discount).ToString() ;

            DBConnection.closeDBConnection();
        }

        private void BtnProductChart_Click(object sender, EventArgs e)
        {
            label1.Text = "Hair Oil";
            label2.Text = "Body Oil";
            label3.Text = "Scrub Cream";
            label4.Text = "Facepack";

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            DBConnection.openDBConnection();

            String date = dateTimePicker1Spa.Value.ToString("yyyy-MM");

            SqlCommand sqlCommand = new SqlCommand("select count(quty) from Spa_Product where productDate_ like '%"+date+"%' group by productType", sqlcon);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Series series1 = new Series();

            while (sqlDataReader.Read())
            {
                chart1.Series[0].Points.AddY(sqlDataReader.GetInt32(0));
                
            }

            DBConnection.closeDBConnection();
        }

        public void nextAppointmentId() {

            int LastIdAppointment = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("Select Top 1 appointmentNum from Spa_Appointment Order by appointmentNum DESC",sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            try {
                LastIdAppointment = Convert.ToInt32(sqlDataReader["appointmentNum"]);
            }
            catch (Exception ex) {

                LastIdAppointment = 0;
            }
            sqlDataReader.Close();

            DBConnection.closeDBConnection();

            txtAppoinmentIDSpa.Text = Convert.ToString(LastIdAppointment + 1);

        }

        public void nextEmployeetId()
        {

            int LastEmployeetId = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("Select Top 1 Emp_ID from Emplyoees Order by Emp_ID DESC", sqlcon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            try
            {
                LastEmployeetId = Convert.ToInt32(sqlDataReader["Emp_ID"]);
            }
            catch (Exception ex)
            {

                LastEmployeetId = 0;
            }
            sqlDataReader.Close();

            DBConnection.closeDBConnection();

            txtEmpId.Text = Convert.ToString(LastEmployeetId + 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SpaAppointmentReportForm spaAppointmentReportForm = new SpaAppointmentReportForm();
            spaAppointmentReportForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SpaCompletedAppointmentsReportForm spaCompletedAppointmentsReportForm = new SpaCompletedAppointmentsReportForm();
            spaCompletedAppointmentsReportForm.Show();
        }
    }
}  

