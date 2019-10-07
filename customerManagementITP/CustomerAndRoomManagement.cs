using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace customerManagementITP
{
    public partial class CustomerForm : MetroFramework.Forms.MetroForm
    {
        private Customer customer = new Customer();
        private Familymember familyMember = new Familymember();
        private Rooms rooms = new Rooms();
        private RoomType roomtype = new RoomType();
        private Payment payment = new Payment();
        private CheckedOut checkedOutCustomer = new CheckedOut();
        private Chart chartData = new Chart();
        private Meal meal = new Meal();

        
        private String nationality = null;
        private String gender = null;
        private String adultChild = null;
        private String accomadationType = null;
        private String year = null;
        private String month = null;
        private String chartChoice = null;
        private String registerStatus = null;
        private Boolean premium = false;
        private Boolean deluxe = false;
        private Boolean superior = false;
        private int totalRooms = 0;
        private double netTotal = 0;
       
        private String Customergender = null;


        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.RoomType' table. You can move, or remove it, as needed.
            // this.roomTypeTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.RoomType);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet.Room' table. You can move, or remove it, as needed.
            // this.roomTableAdapter.Fill(this.blue_Lotus_HotelDataSet.Room);
            //displaying the data to the data grid
            customerdataGridView.DataSource = customer.CustomerData;

            //displayomg family member data to the datagrid
            familymembergrid.DataSource = familyMember.GetFamilymembers();

            //displaying Accomodation data to the data grid
            roomgrid.DataSource = rooms.RoomDetails();

            //displaying aall the food available in the hotel when the form is loaded
            FoodGrid.DataSource = meal.getAllFoodType();


            //displaying all the orders in the meal order grid when form is loaded
            CustomerMealOrderGrid.DataSource = meal.getAllMealOrder();

            //getting all the meals avaialble in the Hotel to the system when the forms is loaded
            cmbMealType.DataSource = meal.getAllMeals();
            cmbMealType.DisplayMember = "Food_Name";
            cmbMealType.ValueMember = "Food_Name";

            //displaying all payment checked IN records in payament data grid
            paymentgrid.DataSource = payment.displayCheckinPayment();

            //displaying all the checked out customer when the form is loaded
            customerCheckedOutgrid.DataSource = checkedOutCustomer.dispplayCheckoutCustomer();

            //getting all room type for the update room type combo box
            cmbUpdatetype.DataSource = roomtype.getAllroomType();
            cmbUpdatetype.DisplayMember = "typeName";
            cmbUpdatetype.ValueMember = "typeName";

            //getting all room Id from the database
            cmbRoom.DataSource = rooms.getAllRoom();
            cmbRoom.DisplayMember = "roomId";
            cmbRoom.ValueMember = "roomId";

            //getting data from the database 
            //assigning the premium rooms to premium type
            cmbpremiumroom.DataSource = rooms.getRoomList("Premium");
            cmbpremiumroom.DisplayMember = "roomId";
            cmbpremiumroom.ValueMember = "roomId";


            //getting data from the database 
            //assigning the deluxe rooms to deluxe type
            cmbdeluxeroom.DataSource = rooms.getRoomList("Deluxe");
            cmbdeluxeroom.DisplayMember = "roomId";
            cmbdeluxeroom.ValueMember = "roomId";

            //getting data from the database 
            //assigning the superior rooms to superior type
            cmbsuperiorroom.DataSource = rooms.getRoomList("Superior");
            cmbsuperiorroom.DisplayMember = "roomId";
            cmbsuperiorroom.ValueMember = "roomId";


            //getting available rooms
            getFreeRooms();

            //maximun value of the numeric up and down of premium
            //This value is equal tonumber of premium rooms
            numpremium.Maximum = cmbpremiumroom.Items.Count;


            //maximun value of the numeric up and down of deluxe
            //This value is equal to number of deluxe rooms
            numdeluxe.Maximum = cmbdeluxeroom.Items.Count;


            //maximun value of the numeric up and down of superior
            //This value is equal tonumber of superior rooms
            numsuperior.Maximum = cmbsuperiorroom.Items.Count;


            //making both payment card and cash paymet methods disable when the form is loaded
            grpBoxCardType.Enabled = false;
            txtamountpaid.Enabled = false;
            lblamountpaid.Enabled = false;
            

            //when the form is loading enabling the new accomodation and disabling the update and fee accomodation
            //maming the cursor disable when hovered
            grpboxnewAccomodation.Enabled = true;
            
            grpboxUpdateAccomodation.Enabled = false;

            //grpboxUpdateAccomodation.Cursor = Cursors.No;

            grpboxAccomodationfee.Enabled = false;
            //grpboxAccomodationfee.Cursor = Cursors.No;

            //when the form is loading the floor number and room number of the new Rooms adding is invisble
            cmbFloorNo.Visible = false;
            txtnewRoomNo.Visible = false;
            lblRoomNo.Visible = false;
            lblfloorNo.Visible = false;
            lblr.Visible = false;


            //getting the total occupancy whe the form is loaded
            lbltotaloccupancy.Text = rooms.getTotalOccupancy().ToString();

            //initaially there is only year month and week visible in the chart tab
            grpboxnewAccomodation.Enabled = false;

            grpboxUpdateAccomodation.Enabled = false;

            grpboxAccomodationfee.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rdforegin_CheckedChanged_1(object sender, EventArgs e)
        {
            nationality = "Foregin";
            lblnationality.Text = "Passport Number";
        }

        private void rdlocal_CheckedChanged(object sender, EventArgs e)
        {
            nationality = "Local";
            lblnationality.Text = "NIC";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            getCheckDate();

        }

        private void datecheckin_ValueChanged(object sender, EventArgs e)
        {
            getCheckDate();

        }

        private void getCheckDate() {
            double day;
            
            day = (datecheckin.Value - dateTimePicker2.Value).TotalDays;

            if (day < 0)
            {
                day *= (-1);
            }
            txtDays.Text = ((Int32)day + 1).ToString();
        }

        private void GetNoOfPeople() {
            //variables for the no of peoples in customer registration
            int adults, child;

            adults = (Int32)numAdult.Value;
            child = (Int32)numchild.Value;
            txttotalnoofpeople.Text = (adults + child).ToString();

        }
        
        private void NumAdult_ValueChanged(object sender, EventArgs e)
        {
            GetNoOfPeople();
        }

        private void numchild_ValueChanged(object sender, EventArgs e)
        {
            GetNoOfPeople();
            
        }
        public void Reset() {

            txtfullname.Text = "";
            txtcustomerRegistrationSearch.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtnationality.Text = "";
            datecheckin.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            numAdult.Value = 0;
            numchild.Value = 0;
            txttotalnoofpeople.Text = "0";
            premium = false;
            deluxe = false;
            superior = false;
            txtregId.Text = "";
            lblcustomerRegId.Text = "";
            txtcheckincustomerid.Text = "";
            txtcustomerIdOrder.Text = "";
            txtchkoutcustId.Text = "";
            txtcheckinName.Text = "";
        }

        private void customermemberDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ResetCustomerMemberDetailPanel() {
            txtregId.Text = "";
            txtmemberName.Text = "";
            
        }

        private void rdadult_CheckedChanged(object sender, EventArgs e)
        {
            adultChild = "Adult";
            lblchildage.Visible = false;
            numchildage.Value = 0;
            numchildage.Visible = false;
        }

        private void rdchild_CheckedChanged(object sender, EventArgs e)
        {
            adultChild = "Child";
            lblchildage.Visible = true;
            numchildage.Visible = true;
        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnserachchkout_Click(object sender, EventArgs e)
        {

        }


        public void resetRoomTab() {
            //method to reset the value of the room tab

            numpremium.Value = 0;
            numdeluxe.Value = 0;
            numsuperior.Value = 0;
            txtpremiumtotal.Text = "0";
            txtdeluxetotal.Text = "0";
            txtsuperiortotal.Text = "0";
            txttotalrooms.Text = "0";
            txttotalamount.Text = "0";
            
           

        }




        private void btnroomreset_Click(object sender, EventArgs e)
        {
            //resetting the values in the room tab
            resetRoomTab();
        }

        private void chkpremium_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkpremium.Checked == true)
            {
                numpremium.Visible = true;

            }
            else
            {
                numpremium.Visible = false;
                numpremium.Value = 0;
            }
        }

        private void chkdeluxe_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkdeluxe.Checked == true)
            {
                numdeluxe.Visible = true;
            }
            else
            {
                numdeluxe.Visible = false;
                numdeluxe.Value = 0;
            }
        }

        private void chksuperior_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chksuperior.Checked == true)
            {
                numsuperior.Visible = true;
            }
            else
            {
                numsuperior.Visible = false;
                numsuperior.Value = 0;
            }
        }

        public double getPremiumCost() {
            
            //declaring and assigning numbeer of rooms in the premium
            int noOfRooms = (Int32)numpremium.Value;
            totalRooms += noOfRooms;

            //calculating the cost of the room assuming the room cost as 300
            //returning the cost value to the form
            //setting the values
            roomtype.PPrice = roomtype.getTypePrice("Premium");
            double cost = noOfRooms * roomtype.PPrice;
           
            return cost;
        }

        public double getDeluxeCost()
        {

            //declaring and assigning numbeer of rooms in the premium
            int noOfRooms = (Int32)numdeluxe.Value;
            totalRooms += noOfRooms;

            //calculating the cost of the room assuming the room cost as 600
            //returning the cost value to the form
            roomtype.DPrice = roomtype.getTypePrice("Deluxe");
            double cost = noOfRooms * roomtype.DPrice;
           
            return cost;
        }


        public double getSuperiorCost()
        {

            //declaring and assigning numbeer of rooms in the premium
            int noOfRooms = (Int32)numsuperior.Value;
            totalRooms += noOfRooms;

            //calculating the cost of the room assuming the room cost as 700
            //returning the cost value to the form
            roomtype.SPrice = roomtype.getTypePrice("Superior");
            double cost = noOfRooms * roomtype.SPrice;
           
            return cost;
        }


        //get the total number of rooms
        public int getTotalRooms() {
            //calculating the total number of rooms
            int total = (Int32)numsuperior.Value + (Int32)numdeluxe.Value + (Int32)numpremium.Value;
            return total;
        }





        //get the total cost of rooms
        public double getTotalRoomCost() {
            double total = getSuperiorCost() + getDeluxeCost() + getPremiumCost();
            return total;
        }

        //calculating discount for rooms


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //getting individual cost of the three rooms types
            txtsuperiortotal.Text = getSuperiorCost().ToString();
            txtdeluxetotal.Text = getDeluxeCost().ToString();
            txtpremiumtotal.Text = getPremiumCost().ToString();

            //getting the total number of rooms from the gettotal number of rooms methods
            txttotalrooms.Text = getTotalRooms().ToString();

            //getting the total cost for the rooms from the getTotalRoomCost method()
            txttotalamount.Text = getTotalRoomCost().ToString();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //button to reset the all fields in suite tab






        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //button click method to
        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            if (btnaddcustomer.Text == "ADD") {
                customer.insertCustomer(txtnationality.Text.Trim(), txtfullname.Text.Trim(), txtphone.Text.Trim(), txtemail.Text.Trim(), (Int32)numAdult.Value, (Int32)numchild.Value, datecheckin.Value.ToString(), dateTimePicker2.Value.ToString());

                //display data afterinserting to the data base
                customerdataGridView.DataSource = customer.CustomerData;
                //int index = customerdataGridView.Rows.Count - 2;
                //  customerdataGridView.Rows[index].Selected = true;
            }
            else if (btnaddcustomer.Text == "UPDATE")
            {
                int id = (Int32)(customerdataGridView.CurrentRow.Cells[0].Value);
                String updateName = txtfullname.Text;
                String updateNationality = txtnationality.Text;
                String updatePhone = txtphone.Text;
                String updateEmail = txtemail.Text;
                int updateAdult = (Int32)numAdult.Value;
                int updateChild = (Int32)numchild.Value;
                String updateCheckin = datecheckin.Text;
                String updateCheckOut = dateTimePicker2.Text;

                if (updateName.Equals("") || updateNationality.Equals("") || updatePhone.Equals("") || updateEmail.Equals("") || updateCheckin.Equals("") || updateCheckOut.Equals(""))
                {
                    MessageBox.Show("Complete the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    customer.UpdateCustomer(id, updateNationality, updateName, updatePhone, updateEmail, updateAdult, updateChild, updateCheckin, updateCheckOut);
                    customerdataGridView.DataSource = customer.CustomerData;

                }
            }

        }

        private void rdcustomermale_CheckedChanged(object sender, EventArgs e)
        {
            Customergender = "male";
        }

        private void rdcustomerfemale_CheckedChanged(object sender, EventArgs e)
        {
            Customergender = "female";
        }




        //getting the datagrid values to the respective text fields

        private void customerdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        //When the values are prepoluated from the data grid.
        //to perform the customer update operation
        private void btncustomerupdate_Click(object sender, EventArgs e)
        {
           


        }

        //deleting customer from the customer table
        //instantly showing the data
        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            int id = (Int32)(customerdataGridView.CurrentRow.Cells[0].Value);
           
            customer.DeleteCustomer(id);
            Reset();
            customerdataGridView.DataSource = customer.CustomerData;
        }

        private void btnresetcustomer_Click(object sender, EventArgs e)
        {
            btnaddcustomer.Text = "ADD";
            
            customerdataGridView.DataSource = customer.CustomerData;
            Reset();
        }



        private void Btncustomersearch_Click(object sender, EventArgs e)
        {
            customer.SearchCustomer(txtcustomerRegistrationSearch.Text.ToString().Trim());
            customerdataGridView.DataSource = customer.SearchCustomer(txtcustomerRegistrationSearch.Text.ToString().Trim());

        }
        private void Btnaddmember_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse((txtregId.Text.ToString()));
                String name = txtmemberName.Text.Trim().ToString();
                int childAge = (Int32)(numchildage.Value);
                familyMember.InsertMember(id, name, adultChild, childAge, gender);



                //after inserting the data to the database displaying the details in the data grid
                familymembergrid.DataSource = familyMember.GetFamilymembers();
                txtmemberName.Text = "";
                rdadult.Checked = false;
                rdchild.Checked = false;
                rdmale.Checked = false;
                rdfemale.Checked = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a registered Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void familymembergrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Btnupdatemember_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse((txtregId.Text.ToString()));
            String name = txtmemberName.Text.Trim().ToString();
            int childAge = (Int32)(numchildage.Value);

            //calling the update Member method in family member class
            familyMember.updateMember(id, name, adultChild, childAge, gender);


            //after updating the family member displaying the detaisl back in the data grid
            familymembergrid.DataSource = familyMember.GetFamilymembers();
        }
        private void Btndeletemember_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse((txtregId.Text.ToString()));
            String name = txtmemberName.Text.Trim().ToString();

            //calling the method deleteMember in the family member class
            familyMember.DeleteMember(id, name);

            //after deleteing displaying the remaining data in the databse to the data grid
            familymembergrid.DataSource = familyMember.GetFamilymembers();
            txtmemberName.Text = "";
            txtmemberName.Enabled = true;
            rdadult.Checked = false;
            rdchild.Checked = false;
            numchildage.Value = 0;
            numchildage.Visible = false;
            rdmale.Checked = false;
            rdfemale.Checked = false;
            txtsearchmember.Text = "";
            
        }
        private void Resetfamilymember_Click_1(object sender, EventArgs e)
        {
            //resetting all the fields to default values
            txtregId.Text = "";
            txtmemberName.Text = "";
            rdadult.Checked = false;
            rdchild.Checked = false;
            numchildage.Value = 0;
            numchildage.Visible = false;
            rdmale.Checked = false;
            rdfemale.Checked = false;
            txtsearchmember.Text = "";
            familymembergrid.DataSource = familyMember.GetFamilymembers();
        }
        private void Btnsearchmember_Click_1(object sender, EventArgs e)
        {
            familymembergrid.DataSource = familyMember.SearchFamily(txtsearchmember.Text.ToString().Trim());
        }

        //getting the total number of rooms which are not occupied from each type
        public void getFreeRooms()
        {
            lbldeluxeavailable.Text = rooms.getDeluxeAvailabilty().ToString();
            lblpremiumavailable.Text = rooms.getPremiumAvailabilty().ToString();
            lblsuperioravailable.Text = rooms.getSuperiorAvailabilty().ToString();
        }





        String BookingRoomId = null;

        private void btnaddpremium_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (Int32)(customerdataGridView.CurrentRow.Cells[0].Value);
                //  
                 BookingRoomId = cmbpremiumroom.SelectedValue.ToString();
               
                // MessageBox.Show(cmbpremiumroom.SelectedValue.ToString(),"Message");
                if(rooms.BookRoom(BookingRoomId, id))
                {
                    selectMealType();
                    
                }
                
                //displaying data to data grid
                roomgrid.DataSource = rooms.RoomDetails();
                getFreeRooms();
                cmbpremiumroom.DataSource = rooms.getRoomList("Premium");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a Registered Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void btnadddeluxe_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (Int32)(customerdataGridView.CurrentRow.Cells[0].Value);
                //  
                 BookingRoomId = cmbdeluxeroom.SelectedValue.ToString();

                // MessageBox.Show(cmbpremiumroom.SelectedValue.ToString(),"Message");
                if (rooms.BookRoom(BookingRoomId, id))
                {
                    selectMealType();
                    
                }
                //displaying data to data grid
                roomgrid.DataSource = rooms.RoomDetails();
                getFreeRooms();
                cmbdeluxeroom.DataSource = rooms.getRoomList("Deluxe");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a Registered Customer","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void btnaddsuperior_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (Int32)(customerdataGridView.CurrentRow.Cells[0].Value);
                //  
                 BookingRoomId = cmbsuperiorroom.SelectedValue.ToString();

                // MessageBox.Show(cmbpremiumroom.SelectedValue.ToString(),"Message");
                if (rooms.BookRoom(BookingRoomId, id))
                {
                    selectMealType();
                    
                }
                //displaying data to data grid
                roomgrid.DataSource = rooms.RoomDetails();
                getFreeRooms();
                cmbsuperiorroom.DataSource = rooms.getRoomList("Superior");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }









        }


        private void customercheckintab_Click(object sender, EventArgs e)
        {
            //getting final accomodation cost
            //txtcheckinaccomodationcost.Text = getTotalAccomodationCost().ToString();
            //getting final discount cost


            //getting the netcost
            //txtcheckinnetcost.Text = (getTotalAccomodationCost() - getTotalDiscount()).ToString();

            try
            {
                int id = int.Parse(txtcheckincustomerid.Text);
                float checkingCost = rooms.GetRoomCheckinCost(id);
                float mealTypeCost = meal.getMealOrderPrice(id);
               // MessageBox.Show(rooms.GetRoomCheckinCost(id) + " Room &  938");
                txtcheckinaccomodationcost.Text = checkingCost.ToString();
                txtMealTypeCost.Text = mealTypeCost.ToString();
                txtcheckindays.Text = txtDays.Text.ToString();
                txtnetcost.Text = ((checkingCost + mealTypeCost) * int.Parse(txtDays.Text.ToString())).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select a Registered User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //get the total amount of accomodation cost
        public double getTotalAccomodationCost()
        {
            return getTotalRoomCost();

        }

        //get total amount of discount



        //checkin the customer
        private void btncheckin_Click(object sender, EventArgs e)
        {
            //getting customer id, cost description,discount the customer recieves and total amount and inserting it to the payment table
            try
            {
                int id = int.Parse((txtcheckincustomerid.Text.ToString()));

                //float.Parse(txtcheckindiscount.Text.ToString());
                float total = float.Parse(txtcheckinaccomodationcost.Text.ToString());

                //insert payement method is called from the payment class
                payment.insetPayment(id, "ACCOMODATION COST", total);

                //updating the payment grid when the checkin is done
                paymentgrid.DataSource = payment.displayCheckinPayment();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                
        }

        //if the customer needs to get the total cost \
        //by this button click we can get that
        private void btncalculateCost_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtchkoutcustId.Text.ToString());
                double cost = payment.calculateTotal(customer_id);

                if (cost >= 0)
                {
                    txtamountchckout.Text = cost.ToString();

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a Registered Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnCalIndividualCost_Click(object sender, EventArgs e)
        {
         /*   try
            {
                int customerId = int.Parse(txtchkoutcustId.Text.ToString());
                double cost = 0;
                String descriptionCost = "";

                if (chckbreakfast.CheckState > 0)
                {
                    descriptionCost = "BREAKFAST COST";
                    cost += payment.calculateIndividualCost(customerId, descriptionCost);
                }

                if (chcklunchcost.CheckState > 0)
                {
                    descriptionCost = "LUNCH COST";
                    cost += payment.calculateIndividualCost(customerId, descriptionCost);
                }

                if (chckdinnercost.CheckState > 0)
                {
                    descriptionCost = "DINNER COST";
                    cost += payment.calculateIndividualCost(customerId, descriptionCost);
                }

                if (chckbarcost.CheckState > 0)
                {
                    descriptionCost = "BAR COST";
                    cost += payment.calculateIndividualCost(customerId, descriptionCost);
                }
                if (chckothercost.CheckState > 0)
                {
                    descriptionCost = "OTHER COST";
                    cost += payment.calculateIndividualCost(customerId, descriptionCost);
                }

                txtindividualCost.Text = cost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a Registered Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */
        }

        private void btnchkout_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtchkoutcustId.Text.ToString());

                double balance = int.Parse(txtamountpaid.Text) - int.Parse(txtamountchckout.Text);

                if (balance >= 0)
                {

                    payment.getAccomodationIncome(id);
                    payment.getGYMIncome(id);
                    payment.getSPAIncome(id);


                    if (payment.finalizePayment(id))
                    {
                        MessageBox.Show("Sucessfully checked out", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //  customer.deleteCustomer(id);
                    //displaying the remaining customers to the grid after checking out
                    customerdataGridView.DataSource = customer.CustomerData;

                    //showing the balance from amessage box

                    paymentgrid.DataSource = payment.displayCheckinPayment();
                    customerCheckedOutgrid.DataSource = checkedOutCustomer.dispplayCheckoutCustomer();
                    resetCheckoutTab();
                    ResetCustomerMemberDetailPanel();
                    Reset();
                    MessageBox.Show("Balance = Rs. " + balance, "Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Amount is Insufficent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Amount is not Not Entered " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void resetCheckoutTab()
        {
            txtchkoutcustId.Text = "";
            txtcheckoutcustomername.Text = "";
            txtchckoutcustomeremail.Text = "";
            txtamountchckout.Text = "";
            //txtchckrooms.Text = "";
            txtamountpaid.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

        }


        private void btngeneratecustomerRevenue_Click(object sender, EventArgs e)
        {

            double revenue = checkedOutCustomer.getRevenue(dateFrom.Value.ToString(), dateTo.Value.ToString());
            txtNoOfCheckedOutCustomer.Text = checkedOutCustomer.TotalCheckedOutCustomers(dateFrom.Value.ToString(), dateTo.Value.ToString()).ToString();
            txttotalcustomerRevenue.Text = revenue.ToString();
        }

        private void lbldiscountdescription_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCardType.Enabled = true;
            txtamountpaid.Enabled = false;
            lblamountpaid.Enabled = false;
            txtamountpaid.Text = "";

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxCardType.Enabled = false;
            txtamountpaid.Enabled = true;
            lblamountpaid.Enabled = true;

        }



        //disabling of the grop box in the room management section
        //only enabling the which is selected
        private void metroTile1_Click(object sender, EventArgs e)
        {
            grpboxnewAccomodation.Enabled = true;
            
            grpboxUpdateAccomodation.Enabled = false;

            grpboxAccomodationfee.Enabled = false;
            

            //changing the btnRoom button text
            btnRooms.Text = "ADD NEW ROOM";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //new floor details are invible in this tiles
            cmbFloorNo.Visible = false;
            txtnewRoomNo.Visible = false;
            lblRoomNo.Visible = false;
            lblfloorNo.Visible = false;

            grpboxnewAccomodation.Enabled = false;

            grpboxUpdateAccomodation.Enabled = true;

            grpboxAccomodationfee.Enabled = false;
            lblr.Visible = false;

            //changing the text of the button
            btnRooms.Text = "UPDATE ROOM";



            //all rd buttons in the new room group is c=unchecked in this tab
            rdnewDeluxe.Checked = false;
            rdnewPremium.Checked = false;
            rdnewSuperior.Checked = false;


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            //new floor details are invible in this tiles
            cmbFloorNo.Visible = false;
            txtnewRoomNo.Visible = false;
            lblRoomNo.Visible = false;
            lblfloorNo.Visible = false;


            grpboxnewAccomodation.Enabled = false;

            grpboxUpdateAccomodation.Enabled = false;
            
            grpboxAccomodationfee.Enabled = true;

            //all rd buttons in the new room group is c=unchecked in this tab
            rdnewDeluxe.Checked = false;
            rdnewPremium.Checked = false;
            rdnewSuperior.Checked = false;
            lblr.Visible = false;


        }

        private void rdnewDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Deluxe";
            cmbFloorNo.Visible = true;
            txtnewRoomNo.Visible = true;
            lblRoomNo.Visible = true;
            lblfloorNo.Visible = true;
            lblr.Visible = true;
        }

        private void rdnewPremium_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Premium";            
            cmbFloorNo.Visible = true;
            txtnewRoomNo.Visible = true;
            lblRoomNo.Visible = true;
            lblfloorNo.Visible = true;
            lblr.Visible = true;
        }

        private void rdnewSuperior_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Superior";
            cmbFloorNo.Visible = true;
            txtnewRoomNo.Visible = true;
            lblRoomNo.Visible = true;
            lblfloorNo.Visible = true;
            lblr.Visible = true;
        }


        private void cmbRoom_Click(object sender, EventArgs e)
        {
            try
            {

                txtcurrenttype.Text = rooms.getRoomType(cmbRoom.SelectedValue.ToString());
                txtcurrentfloot.Text = rooms.getFloor(cmbRoom.SelectedValue.ToString()).ToString();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("" + ex, "Error");
            }
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            if (btnRooms.Text == "UPDATE ROOM")
            {
                try { 
                rooms.UpdateRoom(cmbRoom.SelectedValue.ToString(), cmbUpdatetype.SelectedValue.ToString(), int.Parse((cmbupdatefloor.SelectedItem.ToString())));
                getFreeRooms();


                cmbpremiumroom.DataSource = rooms.getRoomList("Premium");
                cmbsuperiorroom.DataSource = rooms.getRoomList("Superior");
                cmbdeluxeroom.DataSource = rooms.getRoomList("Deluxe");
            }catch (Exception ex)
            {
                MessageBox.Show("Please Enter a Floor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            if (btnRooms.Text == "ADD NEW ROOM")
            {
                String roomId = txtnewRoomNo.Text;
                roomId = "R" + roomId;

                if (roomId.Length != 4)
                {
                    MessageBox.Show("Room Number should contain 3 Numbers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
                else
                {

                    rooms.AddNewRooms(roomId, accomadationType, int.Parse(cmbFloorNo.SelectedItem.ToString()));
                    getFreeRooms();

                    
                     cmbpremiumroom.DataSource = rooms.getRoomList("Premium");
                     cmbsuperiorroom.DataSource = rooms.getRoomList("Superior");
                      cmbdeluxeroom.DataSource = rooms.getRoomList("Deluxe");
                    


                }
            }

            //upadtingthe total occupancy
            lbltotaloccupancy.Text = rooms.getTotalOccupancy().ToString();

        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Deluxe";
            roomtype.DPrice = roomtype.getTypePrice(accomadationType);
            txtcurrentTypePrice.Text = roomtype.getTypePrice(accomadationType).ToString();
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Premium";
            roomtype.PPrice = roomtype.getTypePrice(accomadationType);
            txtcurrentTypePrice.Text = roomtype.getTypePrice(accomadationType).ToString();
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            accomadationType = "Superior";
            roomtype.SPrice = roomtype.getTypePrice(accomadationType);
            txtcurrentTypePrice.Text = roomtype.getTypePrice(accomadationType).ToString();
        }

        private void btnupdateRoomtypecost_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtnewTypePrice.Text.ToString()) > 0)
                {
                    roomtype.updateTypePrice(accomadationType, float.Parse(txtnewTypePrice.Text.ToString()));
                    txtnewTypePrice.Text = "";
                    txtcurrentTypePrice.Text = roomtype.getTypePrice(accomadationType).ToString();

                }
                else
                {
                    MessageBox.Show("Invalid Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewTypePrice.Text = "";
                    txtcurrentTypePrice.Text = roomtype.getTypePrice(accomadationType).ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter a Values and select a Room Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //calculating the NUmber of weeks
        //to add to the chart week panel


        public  int MondaysInMonth(DateTime thisMonth)
        {
            int mondays = 0;
            int month = thisMonth.Month;
            int year = thisMonth.Year;
            int daysThisMonth = DateTime.DaysInMonth(year, month);
            DateTime beginingOfThisMonth = new DateTime(year, month, 1);
            for (int i = 0; i < daysThisMonth; i++)
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Monday)
                    mondays++;
            return mondays;
        }



        private void cmbweekyear_Click(object sender, EventArgs e)
        {
        }

        private void cmbweekyear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbweekyear.SelectedIndex > -1)
            {
                cmbweekmonth.Visible = true;
                year = cmbweekyear.SelectedItem.ToString();
                
            }
        }



        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            chart.Titles.Add("");

            if (chartChoice == null)
            {
                MessageBox.Show("Please select a choice", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (chartChoice == "year")
            {
                //   chart.Titles.Add("Yearly");
                fillYearChart();
            }
            else if (chartChoice == "month")
            {

                // chart.Titles.Add("Monthly");
                fillMonthChart();
            }
            else if (chartChoice == "week")
            {

                //chart.Titles.Add("Weekly");
                fillWeekChart();

            }
        }
        private void fillWeekChart()
        {

            try
            {
                chart.DataSource = chartData.getWeekhData(cmbweekyear.SelectedItem.ToString(), cmbweekmonth.SelectedItem.ToString());
                chart.Series["Total"].XValueMember = "date";
                chart.Series["Total"].YValueMembers = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a year and month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillYearChart()
        {

            chart.DataSource = chartData.getYearData("2019");
            chart.Series["Total"].XValueMember = "Year";
            chart.Series["Total"].YValueMembers = "Total";
            
        }

        private void fillMonthChart()
        {
            try
            {
                chart.DataSource = chartData.getMonthData(cmbmonthyear.SelectedItem.ToString());
                chart.Series["Total"].XValueMember = "Month";
                chart.Series["Total"].YValueMembers = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a Month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        /* private void chartWeek_Click(object sender, EventArgs e)
          {
              chartChoice = "week";
              chartYear.Checked = false;
              chartMonth.Checked = false;
              cmbweekyear.Visible = true;

              //clearing the combo box of month and year

              cmbmonthyear.Visible = false;

          }

          private void chartMonth_Click(object sender, EventArgs e)
          {
              chartChoice = "month";
              chartYear.Checked = false;
              chartWeek.Checked = false;

              //clearing the combox of week and year

              cmbweekmonth.Visible = false;
              cmbweekmonth.Visible = false;

          }

          private void chartYear_Click(object sender, EventArgs e)
          {
              chartChoice = "year";
              chartMonth.Checked = false;
              chartWeek.Checked = false;


              //clearing the combo box of week and months
              cmbweekmonth.Visible = false;
              cmbweekmonth.Visible = false;     
              cmbmonthyear.Visible = false;

          }
               */








        private void numFoodQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                txtCustomerOrderPrice.Text = (int.Parse(numFoodQuantity.Value.ToString()) * float.Parse(FoodGrid.CurrentRow.Cells[3].Value.ToString())).ToString();
            }
            catch (Exception ex)
            {
            //    MessageBox.Show("Vxsxsala " + v, "deac");
                MessageBox.Show("Vla " + ex, "deac");
            }
        }

        private void FoodGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            numFoodQuantity.Value = 1;
        }

        private void btnAddCustomerOrder_Click(object sender, EventArgs e)
        {
            if (btnAddCustomerOrder.Text == "ADD")
            {
                meal.addCustomerOrder(int.Parse(txtcustomerIdOrder.Text.ToString()), FoodGrid.CurrentRow.Cells[0].Value.ToString(), FoodGrid.CurrentRow.Cells[1].Value.ToString(), int.Parse(numFoodQuantity.Value.ToString()), orderTime.Text.ToString(), cmbCustomerOrderRoom.SelectedValue.ToString(), float.Parse(txtCustomerOrderPrice.Text.ToString()));
                CustomerMealOrderGrid.DataSource = meal.getAllMealOrder();
            }
            else if(btnAddCustomerOrder.Text == "UPDATE")
            {
                meal.updateCustomerOrder(int.Parse(txtcustomerIdOrder.Text.ToString()), FoodGrid.CurrentRow.Cells[0].Value.ToString(), int.Parse(numFoodQuantity.Value.ToString()), orderTime.Text.ToString(), cmbCustomerOrderRoom.SelectedValue.ToString());
                CustomerMealOrderGrid.DataSource = meal.getAllMealOrder();
            }
        }


        private void btnDeleteCustomerMeal_Click(object sender, EventArgs e)
        {
            if (CustomerMealOrderGrid.CurrentRow.Cells[6].Value.ToString() == "Pending")
            {
                meal.deleteMealOrder(int.Parse(CustomerMealOrderGrid.CurrentRow.Cells[0].Value.ToString()), CustomerMealOrderGrid.CurrentRow.Cells[1].Value.ToString());
                CustomerMealOrderGrid.DataSource = meal.getAllMealOrder();

            } else
            {
                MessageBox.Show("Cannot Be Delete, Order is Approved", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        //when adding a customer to a room we have to consider what meal type is necessary for that room 
        //from this method mealType group box will abled and if the message box result is yes

        public void selectMealType()
        {
            if (DialogResult.Yes ==  MessageBox.Show("Do you want to Add a Meal type", "Select Meal Type", MessageBoxButtons.YesNo, MessageBoxIcon.Information)  )
            {
                grpbxMealType.Enabled = true;
            }
        }

        private void CustomerMealOrderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddCustomerOrder.Text = "UPDATE";

            txtcustomerIdOrder.Text = CustomerMealOrderGrid.CurrentRow.Cells[0].Value.ToString();
            txtCustomerOrderFoodName.Text = CustomerMealOrderGrid.CurrentRow.Cells[2].Value.ToString();
            numFoodQuantity.Value = (int)CustomerMealOrderGrid.CurrentRow.Cells[3].Value;
            orderTime.Text = CustomerMealOrderGrid.CurrentRow.Cells[4].Value.ToString();

            cmbCustomerOrderRoom.DataSource = rooms.getCustomerRoom((Int32)CustomerMealOrderGrid.CurrentRow.Cells[0].Value);
            cmbCustomerOrderRoom.DisplayMember = "accID";
            cmbCustomerOrderRoom.ValueMember = "accID";
        }

        private void FoodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddCustomerOrder.Text = "ADD";
            txtCustomerOrderFoodName.Text = FoodGrid.CurrentRow.Cells[1].Value.ToString();
            txtCustomerOrderPrice.Text = FoodGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnmealsearch_Click(object sender, EventArgs e)
        {
            FoodGrid.DataSource = meal.searchMeal(txtmealSearch.Text.ToString().Trim());
        }

        private void btnresetcustomerOrder_Click(object sender, EventArgs e)
        {
            txtCustomerOrderFoodName.Text = "";
            numFoodQuantity.Value = 1;
            txtmealSearch.Text = "";
            orderTime.Text = "";
            txtCustomerOrderPrice.Text = "";
            FoodGrid.DataSource = meal.getAllFoodType();

        }

        private void customerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartYear_CheckedChanged(object sender, EventArgs e)
        {
            chartChoice = "year";
            cmbmonthyear.Enabled = false;
            cmbweekyear.Enabled = false;
            cmbweekmonth.Enabled = false;
            chartMonth.Checked = false;
            chartWeek.Checked = false;
        }

        private void chartMonth_CheckedChanged(object sender, EventArgs e)
        {
            chartChoice = "month";
            cmbmonthyear.Enabled = true;
            cmbweekyear.Enabled = false;
            cmbweekmonth.Enabled = false;
            chartWeek.Checked = false;
            chartYear.Checked = false;
        }

        private void chartWeek_CheckedChanged(object sender, EventArgs e)
        {

            chartChoice = "week";
            cmbweekyear.Enabled = true;
            cmbweekmonth.Enabled = true;
            cmbmonthyear.Enabled = false;

            chartMonth.Checked = false;
            chartYear.Checked = false;
        }

        private void btnMealType_Click(object sender, EventArgs e)
        {
            //adding the meal type to the customer order table and displaying it in the data grid when the add button is clicked
            meal.addMealType(cmbMealType.SelectedValue.ToString(), int.Parse(customerdataGridView.CurrentRow.Cells[0].Value.ToString()), BookingRoomId);
            CustomerMealOrderGrid.DataSource = meal.getAllMealOrder();
            grpbxMealType.Enabled = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckedCustomerForm checkedCustomerReport = new CheckedCustomerForm();
            checkedCustomerReport.Show();
        }

        private void CustomerdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                btnaddcustomer.Text = "UPDATE";
                txtnationality.Text = customerdataGridView.CurrentRow.Cells[1].Value.ToString();

                txtfullname.Text = customerdataGridView.CurrentRow.Cells[2].Value.ToString();
                txtphone.Text = customerdataGridView.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = customerdataGridView.CurrentRow.Cells[4].Value.ToString();

                numAdult.Value = (Int32)(customerdataGridView.CurrentRow.Cells[5].Value);
                numchild.Value = (Int32)(customerdataGridView.CurrentRow.Cells[6].Value);

                datecheckin.Text = customerdataGridView.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker2.Text = customerdataGridView.CurrentRow.Cells[8].Value.ToString();

                //Getting customer id to family member tab
                txtregId.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();

                //getting customer id and customer name to the check in tab
                txtcheckincustomerid.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();
                txtcheckinName.Text = customerdataGridView.CurrentRow.Cells[2].Value.ToString();


                //getting customer id and name to the check out tab
                txtchkoutcustId.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();
                txtcheckoutcustomername.Text = customerdataGridView.CurrentRow.Cells[2].Value.ToString();
                txtchckoutcustomeremail.Text = customerdataGridView.CurrentRow.Cells[4].Value.ToString();


                //getting the customer id to the Order type
                txtcustomerIdOrder.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();

                cmbCustomerOrderRoom.DataSource = rooms.getCustomerRoom((Int32)customerdataGridView.CurrentRow.Cells[0].Value);
                cmbCustomerOrderRoom.DisplayMember = "accID";
                cmbCustomerOrderRoom.ValueMember = "accID";


                lblcustomerRegId.Text = txtregId.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Familymembergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmemberName.Enabled = false;

            txtregId.Text = familymembergrid.CurrentRow.Cells[0].Value.ToString();
            txtmemberName.Text = familymembergrid.CurrentRow.Cells[1].Value.ToString();
            adultChild = familymembergrid.CurrentRow.Cells[2].Value.ToString();

            if (adultChild == "Adult")
            {
                rdadult.Checked = true;
                rdchild.Checked = false;
                // numchildage.Visible = false;
                // lblchildage.Visible = false;
            }
            else if (adultChild == "Child")
            {
                rdchild.Checked = true;
                rdadult.Checked = false;
            }


            gender = familymembergrid.CurrentRow.Cells[3].Value.ToString();

            if (gender == "Male")
            {
                rdmale.Checked = true;
            }
            else if (gender == "Female")
            {
                rdfemale.Checked = true;
            }


            numchildage.Value = (Int32)(familymembergrid.CurrentRow.Cells[4].Value);
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            registerStatus = "Registered";
            rdOnlineRegistered.Checked = false;
            //MessageBox.Show(registerStatus, "Value",MessageBoxButtons.OK);
            customerdataGridView.DataSource = customer.getCustomerStatus(registerStatus);

        }

        private void RdOnlineRegistered_CheckedChanged(object sender, EventArgs e)
        {
            registerStatus = "Online";
            rdAllcustomer.Checked = false;
            //MessageBox.Show(registerStatus, "Value", MessageBoxButtons.OK);
            customerdataGridView.DataSource = customer.getCustomerStatus(registerStatus);


        }

        private void Btndemo1_Click(object sender, EventArgs e)
        {
           txtfullname.Text = "Kamal Perera";
            txtnationality.Text = "972554316";
            txtphone.Text = "0714346958";
            txtemail.Text = "kperera@gmail.com";
            numAdult.Value = 2;
            numchild.Value = 2;
            txtDays.Text = "1";
            datecheckin.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
