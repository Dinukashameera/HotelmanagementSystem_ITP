using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpManagementSystem
{
    class AddEmployee
    {
            private string Emp_ID;
            private string First_Name;
            private string Last_Name ;
            private string DOB;
            private string NIC;
	        private string Gender ;
            private string Email;
	        private string Contact_No;
	        private string Address_Line_1;
	        private string Address_Line_2;
	        private string City_Town;
	        private string Department;
	        private string Designation;
	        private string Date_Hired;
	        private string Basic_Salary;
        private SqlConnection sqlcon = DBConnection.getConnection();

        public AddEmployee() {
        }

        public string Basic_Salary1 { get => Basic_Salary; set => Basic_Salary = value; }
        public string Emp_ID1 { get => Emp_ID; set => Emp_ID = value; }
        public string First_Name1 { get => First_Name; set => First_Name = value; }
        public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Contact_No1 { get => Contact_No; set => Contact_No = value; }
        public string Address_Line_11 { get => Address_Line_1; set => Address_Line_1 = value; }
        public string Address_Line_21 { get => Address_Line_2; set => Address_Line_2 = value; }
        public string City_Town1 { get => City_Town; set => City_Town = value; }
        public string Department1 { get => Department; set => Department = value; }
        public string Designation1 { get => Designation; set => Designation = value; }
        public string Date_Hired1 { get => Date_Hired; set => Date_Hired = value; }

       // SqlCommand sqlcmd = new SqlCommand("AddEmployees", sqlcon);

        public void addNewEmployee()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("AddEmployees", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
           
                //  sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            
            
                
            
            sqlcmd.Parameters.AddWithValue("@First_Name", First_Name);
            sqlcmd.Parameters.AddWithValue("@Last_Name", Last_Name);
            sqlcmd.Parameters.AddWithValue("@NIC", NIC);
            sqlcmd.Parameters.AddWithValue("@DOB", DOB);
            sqlcmd.Parameters.AddWithValue("@Gender", Gender1);
            sqlcmd.Parameters.AddWithValue("@Email", Email);
            sqlcmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            sqlcmd.Parameters.AddWithValue("@Address_Line_1", Address_Line_1);
            sqlcmd.Parameters.AddWithValue("@Address_Line_2", Address_Line_2);
            sqlcmd.Parameters.AddWithValue("@City_Town", City_Town);
            sqlcmd.Parameters.AddWithValue("@Department", Department);
            sqlcmd.Parameters.AddWithValue("@Designation", Designation);
            sqlcmd.Parameters.AddWithValue("@Date_Hired", Date_Hired);
            sqlcmd.Parameters.AddWithValue("@Basic_Salary", Basic_Salary);

            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Entered EMP ID Already Exists !");
            }
            MessageBox.Show("New Employee is Added !","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            

            DBConnection.closeDBConnection();

        }
        public void updateEmployee()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateEmployee", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

           sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            sqlcmd.Parameters.AddWithValue("@First_Name", First_Name);
            sqlcmd.Parameters.AddWithValue("@Last_Name", Last_Name);
            sqlcmd.Parameters.AddWithValue("@NIC", NIC);
            sqlcmd.Parameters.AddWithValue("@DOB", DOB);
            sqlcmd.Parameters.AddWithValue("@Gender", Gender);
            sqlcmd.Parameters.AddWithValue("@Email", Email);
            sqlcmd.Parameters.AddWithValue("@Contact_No", Contact_No);
            sqlcmd.Parameters.AddWithValue("@Address_Line_1", Address_Line_1);
            sqlcmd.Parameters.AddWithValue("@Address_Line_2", Address_Line_2);
            sqlcmd.Parameters.AddWithValue("@City_Town", City_Town);
            sqlcmd.Parameters.AddWithValue("@Department", Department);
            sqlcmd.Parameters.AddWithValue("@Designation", Designation);
            sqlcmd.Parameters.AddWithValue("@Date_Hired", Date_Hired);
            sqlcmd.Parameters.AddWithValue("@Basic_Salary", Basic_Salary);

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee Details are updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            DBConnection.closeDBConnection();

        }

        public void deleteEmployee()

        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("DeleteEmployee", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
       
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee is deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }

        public bool IsEmailValid()
        {
            try
            {

                try
                {
                    MailAddress m = new MailAddress(Email1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Email !");
                }
                return true;
            }
            catch(FormatException ex)
            {
                return false;
            }
        }
    }
}
    