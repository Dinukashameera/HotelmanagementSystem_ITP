using customerManagementITP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stock_Management_System
{
    public partial class StockManagement : MetroFramework.Forms.MetroForm
    {

        //create a object from RoomEquipment class
        RoomEquipment roomE = new RoomEquipment();
        HallEquipment hallE = new HallEquipment();
        CleaningEquipment cleanE = new CleaningEquipment();
        Transpotation transV = new Transpotation();
        Kitchen kitchenW = new Kitchen();
        Supplier Supplier = new Supplier();
        Expenses expense = new Expenses();

        //public object EquipmentID { get; private set; }

        public StockManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //to display  RoomEquipment DataGridView
            displayRoomEquipmentDataGridView();
            Reset();
            //to display HallEquipment DatagridView
            displayHAllEquipmentDataGridView();
            displayCleaningEquipmentDataGridView();
            displayVehicaltDataGridView();
            displayKitchentDataGridView();
            displaysupplierDataGridView();
            displayExpenceDataGridView();


        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LblKitchenWear_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblFoodItem_Click(object sender, EventArgs e)
        {

        }

        private void Panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        //RoomRemoveEquipment
        private void BtnRemove_Click(object sender, EventArgs e)
        {

            try
            {
                

                if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {



                    roomE.@REntryID1 = int.Parse(DgvStocks.CurrentRow.Cells[0].Value.ToString()); ;
                    roomE.RemoveEquipment(roomE.@REntryID1);

                    MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }

                displayRoomEquipmentDataGridView();
                Reset();



            } catch(Exception ex){

                MessageBox.Show(ex.Message, "Error Message");

            }       

        }

        private void BtnExceed_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroTabPage7_Click(object sender, EventArgs e)
        {

        }

        private void BtnRoomManageCategories_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //RoomAddNewCategoriecs add = new RoomAddNewCategoriecs();
            //add.ShowDialog();
        }

        private void BtnRoomSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtRoomEID.Text == "" || cmbRoomECategorie.Text == "" || txtRoomEBrand.Text == "" || txtRoomEquipmentModel.Text == "" ||
                    numericUpDownRoom.Text == "" || txtRoomUnitPrice.Text == "")
                {

                   MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
                
                    if(btnRoomAdd.Text == "Add")
                    {
                        //trim for remove extra spaces from left and right side
                        //roomE.EquipmentID1 = txtRoomEID.Text.Trim().ToString();
                        roomE.EquipmentID1 = txtRoomEID.Text.Trim().ToString();
                        roomE.EquipmentCategorie1 = cmbRoomECategorie.Text.Trim().ToString();
                        roomE.EquipmentBrand1 = txtRoomEBrand.Text.Trim().ToString();
                        roomE.EquipmentModel1 = txtRoomEquipmentModel.Text.Trim().ToString();
                        roomE.Description1 = txtRoomDescription.Text.Trim().ToString();
                        roomE.Quantity1 = int.Parse(numericUpDownRoom.Text.Trim());
                        roomE.UnitPrice1 = float.Parse(txtRoomUnitPrice.Text.Trim());

                        roomE.save();
                    
                        MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    }

                    else if (btnRoomAdd.Text == "Update")
                    {
                        
                        roomE.EquipmentID1 = txtRoomEID.Text.Trim().ToString();
                        roomE.EquipmentCategorie1 = cmbRoomECategorie.Text.Trim().ToString();
                        roomE.EquipmentBrand1 = txtRoomEBrand.Text.Trim().ToString();
                        roomE.EquipmentModel1 = txtRoomEquipmentModel.Text.Trim().ToString();
                        roomE.Description1 = txtRoomDescription.Text.Trim().ToString();
                        roomE.Quantity1 = int.Parse(numericUpDownRoom.Text.Trim());
                        roomE.UnitPrice1 = float.Parse(txtRoomUnitPrice.Text.Trim());


                      roomE.Update(txtRoomEID.Text.Trim().ToString());


                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayRoomEquipmentDataGridView();

                    }

                Reset();
                displayRoomEquipmentDataGridView();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }  

        }

        private void LblRoomECategorie_Click(object sender, EventArgs e)
        {

        }


        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbRoomECategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroGrid3_Click(object sender, EventArgs e)
        {

        }

        private void MetroGrid3_DoubleClick(object sender, EventArgs e)
        {
            if (DgvStocks.CurrentRow.Index != -1)
            {
                txtRoomEID.Text = DgvStocks.CurrentRow.Cells[1].Value.ToString();
                cmbRoomECategorie.Text = DgvStocks.CurrentRow.Cells[2].Value.ToString();
                txtRoomEBrand.Text = DgvStocks.CurrentRow.Cells[3].Value.ToString();
                txtRoomEquipmentModel.Text = DgvStocks.CurrentRow.Cells[4].Value.ToString();
                txtRoomDescription.Text = DgvStocks.CurrentRow.Cells[5].Value.ToString();
                numericUpDownRoom.Text = DgvStocks.CurrentRow.Cells[6].Value.ToString();
                txtRoomUnitPrice.Text =DgvStocks.CurrentRow.Cells[7].Value.ToString();
                btnRoomAdd.Text = "Update";//safe convert to update after clicking datagrid row view
                btnRoomRemoveE.Enabled = true;//default false so now it's inaible
            }
        }

        public void displayRoomEquipmentDataGridView() {

            roomE.SearchContent1 = txtRoomSearch.Text.Trim().ToString();
            DataTable dt = roomE.viewSearch();
            DgvStocks.DataSource = dt;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        public void displayHallEquipmentDataGridView()
        {

            hallE.SearchHallContent = txtRoomSearch.Text.Trim().ToString();
            DataTable dth = hallE.viewSearchHall();
            DgvStocks.DataSource = dth;//to show the records in datagrid
            

        }

        private void MetroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void Reset() {

            txtRoomEID.Text = cmbRoomECategorie.Text = txtRoomEBrand.Text = txtRoomEquipmentModel.Text = txtRoomDescription.Text =
             txtRoomUnitPrice.Text = "";
            numericUpDownRoom.Text = "0";
            btnRoomAdd.Text = "Add";//Update  to add
            
            btnRoomRemoveE.Enabled = false;//remove is disable now
        }

        private void BtnRoomReset_Click(object sender, EventArgs e)
        {
            try
            {
                //call the button click event
                Reset();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

            

        }

        private void BtnHallAddNewEuipment_Click(object sender, EventArgs e)
        {
           
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnRoomImage_Click(object sender, EventArgs e)
        {
           

        }

        private void Panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListRoomImageFileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Panel48_Paint(object sender, PaintEventArgs e)
        {

        }

        
        //search
        private void lblRoomSearch1(object sender, EventArgs e)
        {
           

        }

        private void BtnhallAdd_Click_1(object sender, EventArgs e)
        {
            try
            {

                 if (txtHallEID.Text == "" || cmdHallEcategorie.Text == "" || txthallEbrand.Text == "" || txthallEmodel.Text == "" ||
                    numericUpDownHall.Text == "" || txthallunitprice.Text == "")
                  {

                   MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                   }


             
                    hallE.HEquipmentID1 = txtHallEID.Text.Trim().ToString();
                    hallE.HEquipmentCategorie1 = cmdHallEcategorie.Text.Trim().ToString();
                    hallE.HEquipmentBrand1 = txthallEbrand.Text.Trim().ToString();
                    hallE.HEquipmentModel1 = txthallEmodel.Text.Trim().ToString();
                    hallE.HDescription1 = txthalldescription.Text.Trim().ToString();
                    hallE.HQuantity1 = int.Parse(numericUpDownHall.Text.Trim());
                    hallE.HUnitPrice1 = float.Parse(txthallunitprice.Text.Trim());

                    hallE.insertHEquipment();

                

                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                displayHAllEquipmentDataGridView();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void LblHallInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnhallupdateC(object sender, EventArgs e)
        {

            if (txtHallEID.Text == "" || cmdHallEcategorie.Text == "" || txthallEbrand.Text == "" || txthallEmodel.Text == "" ||
                   txthalldescription.Text == "" || numericUpDownHall.Text == "" || txthallunitprice.Text == "")
            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            try
            {
               
                hallE.HEquipmentID1 = txtHallEID.Text.Trim().ToString();
                hallE.HEquipmentCategorie1 = cmdHallEcategorie.Text.Trim().ToString();
                hallE.HEquipmentBrand1 = txthallEbrand.Text.Trim().ToString();
                hallE.HEquipmentModel1 = txthallEmodel.Text.Trim().ToString();
                hallE.HDescription1 = txthalldescription.Text.Trim().ToString(); 
                hallE.HQuantity1 = int.Parse(numericUpDownHall.Text.Trim());
                hallE.HUnitPrice1 = float.Parse(txthallunitprice.Text.Trim());

                hallE.updateEquipment();



                

                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               


                displayHAllEquipmentDataGridView(); 

            

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
}
        //datagrid hall
        private void hallDatagGrid(object sender, EventArgs e)
        {
            if (DvgHall.CurrentRow.Index != -1)
            {
                txtHallEID.Text = DvgHall.CurrentRow.Cells[1].Value.ToString();
                cmdHallEcategorie.Text = DvgHall.CurrentRow.Cells[2].Value.ToString();
                txthallEbrand.Text = DvgHall.CurrentRow.Cells[3].Value.ToString();
                txthallEmodel.Text = DvgHall.CurrentRow.Cells[4].Value.ToString();
                txthalldescription.Text = DvgHall.CurrentRow.Cells[5].Value.ToString();
                numericUpDownHall.Text = DvgHall.CurrentRow.Cells[6].Value.ToString();
                txthallunitprice.Text = DvgHall.CurrentRow.Cells[7].Value.ToString();
               // btnhallUpdate.Text = "Update";//safe convert to update after clicking datagrid row view
                btnRemoveHall.Enabled = true;//default false so now it's inaible
            }

        }


        public void displayHAllEquipmentDataGridView()
        {

            hallE.SearchHallContent = txthallsearch.Text.Trim().ToString();
            

            DataTable dth = hallE.viewSearchHall();
            DvgHall.DataSource = dth;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }


        private void MetroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtRoomSearch_DockChanged(object sender, EventArgs e)
        {

        }

        private void TxtRoomSearch_DoubleClick(object sender, EventArgs e)
        {

        }

        //hallbtnsearch
        private void btnhallClick(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayHAllEquipmentDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        //roombtnsearch
        private void btnRoomSearchClick(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayRoomEquipmentDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        //hall reset method
        void ResetHall()
        {

            txtHallEID.Text = cmdHallEcategorie.Text = txthallEbrand.Text = txthallEmodel.Text = txthalldescription.Text =
             txthallunitprice.Text = "";
            numericUpDownHall.Text = "0";
            //btnRoomAdd.Text = "Add";//Update  to add
            //roomE.REntryID1 = 0;
            btnRemoveHall.Enabled = false;//remove is disable now
        }

        //btnhallreset
        private void btnHallResetClick(object sender, EventArgs e)
        {
            try
            {

                ResetHall();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        //linkicon
        private void halldamageClick(object sender, EventArgs e)
        {
            new damagehall().Show();
            this.Hide();

        }

        private void StockManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnRemovehallClick(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    hallE.@HEntryID1 = int.Parse(DvgHall.CurrentRow.Cells[0].Value.ToString()); ;
                    hallE.RemoveHallEquipment(hallE.@HEntryID1);

                    MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                displayHAllEquipmentDataGridView();
                ResetHall();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");

            }


        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClickCleaning(object sender, EventArgs e)
        {
            try
            {

                if (txtCleaningItemId1.Text == "" || txtCleaningItemName1.Text == "" || numericUpDownleanig.Text == "" || txtCleanoingUnitprice.Text == "") 
                
                {
                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


         
                cleanE.CItemIdID1 = txtCleaningItemId1.Text.Trim().ToString();
                cleanE.CItemName1 = txtCleaningItemName1.Text.Trim().ToString();
                cleanE.CQuantity1 = int.Parse(numericUpDownleanig.Text.Trim());
                cleanE.CUnitPrice1 = float.Parse(txtCleanoingUnitprice.Text.Trim());
                

                cleanE.insertCEquipment();

              

                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                displayCleaningEquipmentDataGridView();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        private void LblCleaningUnitprice_Click(object sender, EventArgs e)
        {

        }

        private void LblCleaningquantity_Click(object sender, EventArgs e)
        {

        }

        private void TxtcleaningentryId_Click(object sender, EventArgs e)
        {

        }

        private void btnCleaningUpdate(object sender, EventArgs e)
        {

            if (txtCleaningItemId1.Text == "" || txtCleaningItemName1.Text == "" || numericUpDownleanig.Text == "" || txtCleanoingUnitprice.Text == "")

            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                
                cleanE.CItemIdID1 = txtCleaningItemId1.Text.Trim().ToString();
                cleanE.CItemName1 = txtCleaningItemName1.Text.Trim().ToString();
                cleanE.CQuantity1 = int.Parse(numericUpDownleanig.Text.Trim());
                cleanE.CUnitPrice1 = float.Parse(txtCleanoingUnitprice.Text.Trim());

                cleanE.updateCEquipment();

                
                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                displayCleaningEquipmentDataGridView();



                ResetCleaning();
                //displayRoomEquipmentDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        //cleaning double click
        /*private void CleanoingDtaGrid(object sender, EventArgs e)
        {
            if (dvgCleaning.CurrentRow.Index != -1)
            {
                txtCleaningItemId.Text = dvgCleaning.CurrentRow.Cells[1].Value.ToString();
                txtCleaningItemName.Text = dvgCleaning.CurrentRow.Cells[2].Value.ToString();
                txtcleaningquantity.Text = dvgCleaning.CurrentRow.Cells[3].Value.ToString();
                txtCleanoingUnitprice.Text = dvgCleaning.CurrentRow.Cells[4].Value.ToString();
               
                // btnhallUpdate.Text = "Update";//safe convert to update after clicking datagrid row view
               // new -- btnRemoveHall.Enabled = true;//default false so now it's inaible
            }
        }*/

        public void displayCleaningEquipmentDataGridView()
        {

            cleanE.SearchCleaningContent = txtSearchCItem.Text.Trim().ToString();
            //roomE.EquipmentID1 = txtRoomEID.Text.Trim().ToString();
            //roomE.EquipmentCategorie1 = cmbRoomECategorie.Text.Trim().ToString();

            DataTable dtc = cleanE.viewSearchCleaning();
            DvgCleaning.DataSource = dtc;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        //btn Search Cleaning
        private void bnSearchCleaning(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayCleaningEquipmentDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void CleaningDoubleClick(object sender, EventArgs e)
        {
            if (DvgCleaning.CurrentRow.Index != -1)
            {
                txtCleaningItemId1.Text = DvgCleaning.CurrentRow.Cells[1].Value.ToString();
                txtCleaningItemName1.Text = DvgCleaning.CurrentRow.Cells[2].Value.ToString();
                numericUpDownleanig.Text = DvgCleaning.CurrentRow.Cells[3].Value.ToString();
                txtCleanoingUnitprice.Text = DvgCleaning.CurrentRow.Cells[4].Value.ToString();

                // btnhallUpdate.Text = "Update";//safe convert to update after clicking datagrid row view
                // new -- btnRemoveHall.Enabled = true;//default false so now it's inaible
            }
        }

        // cleaning remove btn
        private void BtnRemoveCleaning_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                cleanE.CEntryID1 = int.Parse(DvgCleaning.CurrentRow.Cells[0].Value.ToString());
                cleanE.RemoveCleaningEquipment(cleanE.CEntryID1);

                MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            displayCleaningEquipmentDataGridView();
            ResetCleaning();


        }

        void ResetCleaning()
        {

            txtCleaningItemId1.Text = txtCleaningItemName1.Text =  txtCleanoingUnitprice.Text = " ";
            numericUpDownleanig.Text = "0";
            //btnRoomAdd.Text = "Add";//Update  to add
            //roomE.REntryID1 = 0;
            //btnResetCl.Enabled = false;//remove is disable now
        }

        private void btbCleaningReset(object sender, EventArgs e)
        {
            try
            {

                ResetCleaning();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void btnVehicalAddClick(object sender, EventArgs e)
        {
            if (txtVehicleID1.Text == "" || txtVehicleCategory1.Text == "" || txtVlicense1.Text == "" || txtVDriveName1.Text == "" || txtTDriverMobile1.Text == "")

            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            /*else if (transV.TDriverMobileNo1.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/

            try
            {
                transV.TvehicalID1 = txtVehicleID1.Text.Trim().ToString();
                transV.TVehicalCategory1 = txtVehicleCategory1.Text.Trim().ToString();
                transV.TvehicleLicenseNo1 = txtVlicense1.Text.Trim().ToString();
                transV.TDriverName1 = txtVDriveName1.Text.Trim().ToString();
                transV.TDriverMobileNo1 = int.Parse(txtTDriverMobile1.Text.Trim().ToString());

                 


                transV.insertTEquipment();

                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                displayVehicaltDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        private void btnVehicalUpdateClick(object sender, EventArgs e)
        {
            if (txtVehicleID1.Text == "" || txtVehicleCategory1.Text == "" || txtVlicense1.Text == "" || txtVDriveName1.Text == "" || txtTDriverMobile1.Text == "")

            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {

                transV.TvehicalID1 = txtVehicleID1.Text.Trim().ToString();
                transV.TVehicalCategory1 = txtVehicleCategory1.Text.Trim().ToString();
                transV.TvehicleLicenseNo1 = txtVlicense1.Text.Trim().ToString();
                transV.TDriverName1 = txtVDriveName1.Text.Trim().ToString();
                transV.TDriverMobileNo1 = int.Parse(txtTDriverMobile1.Text.Trim().ToString());


                transV.updateTEquipment();

                
                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                displayVehicaltDataGridView();



                Resettranspotation();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        // data grid transpotation
        private void dvgTranspotation(object sender, EventArgs e)
        {
            if (DvgVehical.CurrentRow.Index != -1)
            {
                txtVehicleID1.Text = DvgVehical.CurrentRow.Cells[1].Value.ToString();
                txtVehicleCategory1.Text = DvgVehical.CurrentRow.Cells[2].Value.ToString();
                txtVlicense1.Text = DvgVehical.CurrentRow.Cells[3].Value.ToString();
                txtVDriveName1.Text = DvgVehical.CurrentRow.Cells[4].Value.ToString();
                txtTDriverMobile1.Text = DvgVehical.CurrentRow.Cells[5].Value.ToString();

            }
        }

        // vehical displayVehicaltDataGridView()
        public void displayVehicaltDataGridView()
        {

            transV.SearchTranspotationContent = txtSearchTranspotation.Text.Trim().ToString();
            

            DataTable dtt = transV.viewSearchTranspotation();
            DvgVehical.DataSource = dtt;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        // vehical remove
        private void VehicaRemovelClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                transV.TEntryID1 = int.Parse(DvgVehical.CurrentRow.Cells[0].Value.ToString());
                transV.Removetranspotation(transV.TEntryID1);

                MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            displayVehicaltDataGridView();
            Resettranspotation();

        }

        // reset method for vehical
        void Resettranspotation()
        {

            txtVehicleID1.Text = txtVehicleCategory1.Text = txtVlicense1.Text= txtVDriveName1.Text = txtTDriverMobile1.Text = "";
            
        }

        private void ResetVehicalClick(object sender, EventArgs e)
        {
            try
            {

                Resettranspotation();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntransSearchClick(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayVehicaltDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void LblKitchenID_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddNewKitchenwear_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtKitchenid.Text == "" || txtKitchenwearName.Text == "" || numericUpDownKitchen.Text == "" || txtKitchenUnitprice.Text == "")
                 
                 {

                 MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                kitchenW.KKitchenwearID1 = txtKitchenid.Text.Trim().ToString();
                kitchenW.KKitchenwearName1 = txtKitchenwearName.Text.Trim().ToString();
                kitchenW.KQuantity1 = int.Parse(numericUpDownKitchen.Text.Trim().ToString());
                kitchenW.KUnitPrice1 = float.Parse(txtKitchenUnitprice.Text.Trim().ToString());

                kitchenW.insertKEquipment();
                

                
                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                displayKitchentDataGridView();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        private void btnKitchenUpdate(object sender, EventArgs e)
        {
            /*try
            {

                kitchenW.KKitchenwearID1 = txtKitchenid.Text.Trim().ToString();
                kitchenW.KKitchenwearName1 = txtKitchenwearName.Text.Trim().ToString();

                kitchenW.updateKEquipment();


                MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //new displayVehicaltDataGridView();



                // new Resettranspotation();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }*/
        }

        private void btnKClickUpdate(object sender, EventArgs e)
        {
            if (txtKitchenid.Text == "" || txtKitchenwearName.Text == "" || numericUpDownKitchen.Text == "" || txtKitchenUnitprice.Text == "")

            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {

                kitchenW.KKitchenwearID1 = txtKitchenid.Text.Trim().ToString();
                kitchenW.KKitchenwearName1 = txtKitchenwearName.Text.Trim().ToString();
                kitchenW.KQuantity1 = int.Parse(numericUpDownKitchen.Text.Trim().ToString());
                kitchenW.KUnitPrice1 = float.Parse(txtKitchenUnitprice.Text.Trim().ToString());

                kitchenW.updateKEquipment();

               

                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                displayKitchentDataGridView();



                ResetKitchen();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }

        }

        public void displayKitchentDataGridView()
        {

            kitchenW.SearchKitchenContent = txtKitchenSearch1.Text.Trim().ToString();


            DataTable dtk = kitchenW.viewSearchKitchen();
            dvgKitchen.DataSource = dtk;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        private void dvgKitchenDClick(object sender, EventArgs e)
        {
            if (dvgKitchen.CurrentRow.Index != -1)
            {
                txtKitchenid.Text = dvgKitchen.CurrentRow.Cells[1].Value.ToString();
                txtKitchenwearName.Text = dvgKitchen.CurrentRow.Cells[2].Value.ToString();
                numericUpDownKitchen.Text = dvgKitchen.CurrentRow.Cells[3].Value.ToString();
                txtKitchenUnitprice.Text = dvgKitchen.CurrentRow.Cells[4].Value.ToString();
            }

        }

        private void KitchenSearchClick(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayKitchentDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void btnRemoveKitchenWear(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                kitchenW.KEntryID1 = int.Parse(dvgKitchen.CurrentRow.Cells[0].Value.ToString());
                kitchenW.RemoveKitchenWear(kitchenW.KEntryID1);

                MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            displayKitchentDataGridView();
            ResetKitchen();

        }

        void ResetKitchen()
        {

            txtKitchenid.Text = txtKitchenwearName.Text = txtKitchenUnitprice.Text = " ";
            numericUpDownKitchen.Text = "0";

        }

        private void btnKitchenReset(object sender, EventArgs e)
        {
            try
            {

                ResetKitchen();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }


        }

        private void Panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSupplierAddClick(object sender, EventArgs e)
        {
            try
            {

               
                Supplier.SID1 = txtSupplierId1.Text.Trim().ToString();
                Supplier.SName1 = txtSupplierName1.Text.Trim().ToString();
                Supplier.SEmail1 = txtSupplierEmail1.Text.Trim().ToString();
                Supplier.SContact1 = int.Parse(txtSupplierContact1.Text.Trim().ToString());
                Supplier.SDescription1 = txtSupplierDescription1.Text.Trim().ToString();

                if (txtSupplierId1.Text == "" || txtSupplierName1.Text == "" || txtSupplierEmail1.Text == "" || txtSupplierContact1.Text == "")
                {

                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (IsValidEmail() == false)
                {
                    MessageBox.Show("Invalid email!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                else 
                {
                    Supplier.insertSuppliers();
                    displaysupplierDataGridView();
                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }


                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " +ex.Message, "Error Message");

            }
        }

        public bool IsValidEmail()
        {
            try
            {
                MailAddress m = new MailAddress(Supplier.SEmail1);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }
        

        private void btnSupplierUpdateClick(object sender, EventArgs e)
        {
            if (txtSupplierId1.Text == "" || txtSupplierName1.Text == "" || txtSupplierEmail1.Text == "" || txtSupplierContact1.Text == "" ||
                txtSupplierDescription1.Text == "")
            {

                MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {

                Supplier.SID1 = txtSupplierId1.Text.Trim().ToString();
                Supplier.SName1 = txtSupplierName1.Text.Trim().ToString();
                Supplier.SEmail1 = txtSupplierEmail1.Text.Trim().ToString();
                Supplier.SContact1 = int.Parse(txtSupplierContact1.Text.Trim().ToString());
                Supplier.SDescription1 = txtSupplierDescription1.Text.Trim().ToString();

                Supplier.updateSupplier();


               
                    MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                displaysupplierDataGridView();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        public void displaysupplierDataGridView()
        {

            Supplier.SearchSupplierContent = txtSupplierSearch.Text.Trim().ToString();
          
            DataTable dts = Supplier.viewSearchSupplier();
            DvgSupplier.DataSource = dts;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        private void dvgSpplierDoubleClick(object sender, EventArgs e)
        {
            if (DvgSupplier.CurrentRow.Index != -1)
            {
                txtSupplierId1.Text = DvgSupplier.CurrentRow.Cells[1].Value.ToString();
                txtSupplierName1.Text = DvgSupplier.CurrentRow.Cells[2].Value.ToString();
                txtSupplierEmail1.Text = DvgSupplier.CurrentRow.Cells[3].Value.ToString();
                txtSupplierContact1.Text = DvgSupplier.CurrentRow.Cells[4].Value.ToString();
                txtSupplierDescription1.Text = DvgSupplier.CurrentRow.Cells[5].Value.ToString();
                
                
               // btnRemoveHall.Enabled = true;//default false so now it's inaible
            }
        }

        private void btnSupplierSerach(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displaysupplierDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnSupplierRemove(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Supplier.SEntryID1 = int.Parse(DvgSupplier.CurrentRow.Cells[0].Value.ToString());
                Supplier.RemoveSupplier(Supplier.SEntryID1);

                MessageBox.Show("Equipment removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            displaysupplierDataGridView();
            ResetSupplier();
        }

        void ResetSupplier()
        {

            txtSupplierId1.Text = txtSupplierName1.Text = txtSupplierEmail1.Text= txtSupplierContact1.Text= txtSupplierDescription1.Text= " ";

        }

        private void btnSupplierResetClick(object sender, EventArgs e)
        {
            try
            {

                ResetSupplier();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnExpensesView(object sender, EventArgs e)
        {
            txtExpensesGrandTotal.Text = expense.calSubTotal().ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage10_Click(object sender, EventArgs e)
        {

        }

        private void TxtCleaningItemName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ExpensesDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel21_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MetroGrid4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //keypress validation
        private void suppliercontact(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        //validation for up Room
        private void upKeyPressRoom(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void UPHall(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void UPkitchen(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void upValidation(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void valiidationEExpense(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void TxtSupplierEmail_Leave(object sender, EventArgs e)
        {
           
        }

        private void BtnExpensesAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtExpenceID.Text == "" ||  expensesDateTimePicker.Text == "" || txtExpensesGrandTotal.Text=="")

                {

                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                expense.ExpenseId2 = txtExpenceID.Text.Trim().ToString();
                expense.Description1 = txtDescription.Text.Trim().ToString();
                expense.Date1 = DateTime.Parse(expensesDateTimePicker.Text.Trim().ToString());
                expense.GrandTotal = float.Parse(txtExpensesGrandTotal.Text.Trim().ToString());

                expense.insertExpense();
               
                    MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayExpenceDataGridView();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        private void HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExpensesUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtExpenceID.Text == "" || txtDescription.Text == "" || expensesDateTimePicker.Text == "" || txtExpensesGrandTotal.Text == "")

                {

                    MessageBox.Show("Please enter values to fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                expense.ExpenseId2 = txtExpenceID.Text.Trim().ToString();
                expense.Description1 = txtDescription.Text.Trim().ToString();
                expense.Date1 = DateTime.Parse(expensesDateTimePicker.Text.Trim().ToString());
                expense.GrandTotal = float.Parse(txtExpensesGrandTotal.Text.Trim().ToString());

                expense.updateExpences();

                MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayExpenceDataGridView();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        public void displayExpenceDataGridView()
        {

            expense.SearchExpencesContent = txtSearchExpense1.Text.Trim().ToString();

            DataTable dts = expense.viewSearchExpences();
            DvgExpense.DataSource = dts;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        private void BtnExpensesSearch_Click(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayExpenceDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        
        private void DvgExpencesDoubleclick(object sender, EventArgs e)
        {
            if (DvgExpense.CurrentRow.Index != -1)
            {
                txtExpenceID.Text = DvgExpense.CurrentRow.Cells[0].Value.ToString();
                txtDescription.Text = DvgExpense.CurrentRow.Cells[1].Value.ToString();
                expensesDateTimePicker.Text = DvgExpense.CurrentRow.Cells[2].Value.ToString();
                txtExpensesGrandTotal.Text = DvgExpense.CurrentRow.Cells[3].Value.ToString();
                 
            }
        }

        private void BtnExpensesDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you really want to remove this Expences details?", "Remove expences details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    expense.@ExpenseId2 = DvgExpense.CurrentRow.Cells[0].Value.ToString(); 
                    expense.RemoveExpences(expense.@ExpenseId2);

                    MessageBox.Show("Expences Details removed Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                displayExpenceDataGridView();
                ResetExpences();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");

            }

        }

        //expences remove
        void ResetExpences()
        {
            txtExpenceID.Text = txtDescription.Text = expensesDateTimePicker.Text = txtExpensesGrandTotal.Text = "";
           // btnExpensesDelete.Enabled = false;//remove is disable now
        }

        //click event for reset button
        private void BtnExpensesReset_Click(object sender, EventArgs e)
        {

            try
            {

                ResetExpences();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void Panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnchartExpences_Click(object sender, EventArgs e)
        {
            //this.ChartExpences.Series["GrandTotal"].Points.AddXY(expensesDateTimePicker.Text.Trim().ToString(), txtExpensesGrandTotal.Text.Trim().ToString());

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
           // this.ChartExpences.Series["GrandTotal"].Points.AddXY(expensesDateTimePicker.Text.Trim().ToString(), txtExpensesGrandTotal.Text.Trim().ToString());

        }

        private void BtnChartEx_Click(object sender, EventArgs e)
        {
            this.chart1.Series["GrandTotal"].Points.AddXY(expensesDateTimePicker.Text.Trim().ToString(), txtExpensesGrandTotal.Text.Trim().ToString());

        }

        private void Btndemoroom_Click(object sender, EventArgs e)
        {
            txtRoomEID.Text = "R001";
            cmbRoomECategorie.SelectedIndex = 0;
            txtRoomEBrand.Text = "Damro";
            txtRoomEquipmentModel.Text = "DAM01";
            txtRoomDescription.Text = "Latest vertion";
            numericUpDownRoom.Value = 1;
            txtRoomUnitPrice.Text = "1345.00";
            

        }

        private void TxtRoomDescription_Click(object sender, EventArgs e)
        {

        }

        private void LblkitchenwearName_Click(object sender, EventArgs e)
        {

        }

        private void Btndemohall_Click(object sender, EventArgs e)
        {
            txtHallEID.Text = "H001";
            cmdHallEcategorie.SelectedIndex = 1;
            txthallEbrand.Text = "Abance";
            txthallEmodel.Text = "AB01";
            txthalldescription.Text = "";
            numericUpDownHall.Value = 2;
            txthallunitprice.Text = "1599.00";


        }

        private void Btndemokitchen_Click(object sender, EventArgs e)
        {
            txtKitchenid.Text = "K001";
            txtKitchenwearName.Text = "Spoon";
            numericUpDownKitchen.Value = 5;
            txtKitchenUnitprice.Text = "150.00";
        }

        private void Btndemocleaning_Click(object sender, EventArgs e)
        {
            txtCleaningItemId1.Text = "C001";
            txtCleaningItemName1.Text = "Mops";
            numericUpDownleanig.Value = 15;
            txtCleanoingUnitprice.Text = "325.00";



        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtndemoVehical_Click(object sender, EventArgs e)
        {
            txtVehicleID1.Text = "V001";
            txtVehicleCategory1.Text = "Van";
            txtVlicense1.Text = "B3833920";
            txtVDriveName1.Text = "Visal Perera";
            txtTDriverMobile1.Text = "0714564567";


        }

        private void Btndemosupplier_Click(object sender, EventArgs e)
        {
            txtSupplierId1.Text = "S001";
            txtSupplierName1.Text = "Nimal";
            txtSupplierEmail1.Text = "nimal1@gmail.com";
            txtSupplierContact1.Text = "0778529631";
            txtSupplierDescription1.Text = "";
        }

        private void Btndemoexpences_Click(object sender, EventArgs e)
        {
            txtExpenceID.Text = "1";
            txtDescription.Text = "";
            expensesDateTimePicker.Text = "21 September 2019";
        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LblSupplierID_Click(object sender, EventArgs e)
        {

        }

        private void TxtSupplierContact1_Click(object sender, EventArgs e)
        {

        }

        private void Panel49_Paint(object sender, PaintEventArgs e)
        {

        }

        //validation for mobile number transpotation
        private void TransKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }

        }

        //validation for supplier mobile number
        private void KeyPressSupplier(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            InventoryExpensesReportForm inventoryExpensesReportForm = new InventoryExpensesReportForm();
            inventoryExpensesReportForm.Show();
        }
    }
    
} 

