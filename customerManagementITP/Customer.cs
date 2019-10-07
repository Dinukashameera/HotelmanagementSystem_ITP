using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace customerManagementITP
{
    class Customer
    {
        private SqlConnection sqlcon = DBConnection.getConnection();
        private String mail;

        public Boolean insertCustomer(String nationality,String fullname,String phone,String email,int adult,int child,String dateCheckin, String dateCheckout) {
            mail = email;

            //validating the parameters which are send to the method
            //checking for the false condition first
            //validating the ID entered is correct
            if (!(nationality.Length == 9))
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (adult < 0 && child < 0) {
                MessageBox.Show("Invalid Number of people", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }



            SqlCommand command = new SqlCommand("Insert into Customer_Room(nationality,full_Name,phone,email,adult,child,checkin,checkout,status) Values(@nationality,@full_Name,@phone,@email,@adult,@child,@checkin,@checkout,'Registered')", sqlcon);
            command.CommandType = CommandType.Text;

            

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@nationality", nationality);
            command.Parameters.AddWithValue("@full_Name", fullname);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email",email);
            
            command.Parameters.AddWithValue("@adult",adult);
            command.Parameters.AddWithValue("@child",child);
            command.Parameters.AddWithValue("@checkin",dateCheckin);
            command.Parameters.AddWithValue("@checkout", dateCheckout);


            DBConnection.openDBConnection();


            //MessageBox.Show("executed", "message");

            String title = "";
            String message = "";
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {

                    message = "SuccessFully added";
                    title = "Success";

                    MessageBox.Show(message, title);
                    
                }
                else
                {

                    message = "Unable to enter the Data";
                    title = "UnsucessFull";

                    MessageBox.Show(message, title);
                    return false;
                }
                
            }


            catch (Exception ex) {
                MessageBox.Show(ex + " Error ", "ERROR");
                
            }

            DBConnection.closeDBConnection();
            return true;
            
            
        }

        //creating a method
        //to validate the email
        //which will return a boolean value
        //then will be passed to insert method inside the if condition
        public bool IsEmailValid()
        {
            
            try
            {
                MailAddress m = new MailAddress(mail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }



        //Method to display customer data to datagrid
        public DataTable CustomerData
        {
            get
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customer_Room", sqlcon);
                //command.ExecuteNonQuery();
                //connection.openConnection();
                DataTable datatable = new DataTable();
                SqlDataAdapter sqldapter = new SqlDataAdapter(command);
                sqldapter.Fill(datatable);

                return datatable;


            }
        }
        //Method to display all registered and online customers seperately
        public DataTable getCustomerStatus(String status)
        {

            DBConnection.openDBConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM Customer_Room Where Status = @status", sqlcon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@status", status);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);
            DBConnection.closeDBConnection();
            return datatable;



        }







        //Method to Edit the customers
        public Boolean UpdateCustomer(int id, String nationality, String fullname, String phone, String email, int adult, int child, String dateCheckin, String dateCheckout) {
            SqlCommand command = new SqlCommand("UPDATE Customer_Room SET nationality = @nationality, full_Name = @full_Name, phone = @phone,email = @email, adult = @adult, child = @child, checkin = @checkin, checkout = @checkout, status = @status WHERE customer_id = @customer_id", sqlcon);
            command.CommandType = CommandType.Text;



            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@customer_id", id);
            command.Parameters.AddWithValue("@nationality", nationality);
            command.Parameters.AddWithValue("@full_Name", fullname);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);

            command.Parameters.AddWithValue("@adult", adult);
            command.Parameters.AddWithValue("@child", child);
            command.Parameters.AddWithValue("@checkin", dateCheckin);
            command.Parameters.AddWithValue("@checkout", dateCheckout);
            command.Parameters.AddWithValue("@status", "Registered");


            DBConnection.openDBConnection();


            //MessageBox.Show("executed", "message");

            String title = "";
            String message = "";
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {

                    message = fullname + " was Upadted sucessfully";
                    title = "Update Success";

                    MessageBox.Show(message, title);

                }
                else
                {

                    message = "Unable to update the Data";
                    title = "UnsucessFull";

                    MessageBox.Show(message, title);
                    return false;
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error ", "ERROR");

            }

            DBConnection.closeDBConnection();
            return true;
            //closing the connection
            

        }


        //method to delete customer
        public Boolean DeleteCustomer(int id) {
            SqlCommand command = new SqlCommand("DELETE FROM Customer_Room WHERE customer_id = @customer_id", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@customer_id", id);

            DBConnection.openDBConnection();


            // MessageBox.Show("executed", "message");

            String title = "";
            String message = "";
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {

                    message = "Customer deleted Sucessfully";
                    title = "DELETED";

                    MessageBox.Show(message, title);

                }
                else
                {

                    message = "Unable to enter the Data";
                    title = "UnsucessFull";

                    MessageBox.Show(message, title);
                    return false;
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Checked In Customer Cannot Be Deleted", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

            DBConnection.closeDBConnection();
            return true;

           
        }

        public DataTable SearchCustomer(String name) {
               
                SqlCommand command = new SqlCommand("SELECT * FROM Customer_Room WHERE full_Name LIKE '%' + @name + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", name);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable datatable = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(datatable);

                return datatable;


        }


    }
}
