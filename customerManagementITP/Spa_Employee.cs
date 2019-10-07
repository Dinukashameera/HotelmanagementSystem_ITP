using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerManagementITP;

namespace SPA
{
    class Spa_Employee
    {
        private String Emp_ID;
        private String First_Name;
        private String Last_Name;
        private String DOB;
        private String NIC;
        private String Gender;
        private String Email;
        private String Contact_No;
        private String Address_Line1;
        private String Address_Line2;
        private String Department;
        private String Designation;
        private String Date_Hired;
        private float Bsic_Salary;
        private String searchText;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public String EmpID { get => Emp_ID; set => Emp_ID = value; }
        public string FirstName { get => First_Name; set => First_Name = value; }
        public string LastName { get => Last_Name; set => Last_Name = value; }
        public String DOB_ { get => DOB; set => DOB = value; }
        public string NIC_ { get => NIC; set => NIC = value; }
        public string Gender_ { get => Gender; set => Gender = value; }
        public string Email_ { get => Email; set => Email = value; }
        public string ContactNo { get => Contact_No; set => Contact_No = value; }
        public string AddressLine1 { get => Address_Line1; set => Address_Line1 = value; }
        public string AddressLine2 { get => Address_Line2; set => Address_Line2 = value; }
        public string Department_ { get => Department; set => Department = value; }
        public string Designation_ { get => Designation; set => Designation = value; }
        public String DateHired { get => Date_Hired; set => Date_Hired = value; }
        public float BsicSalary { get => Bsic_Salary; set => Bsic_Salary = value; }
        public string SearchText { get => searchText; set => searchText = value; }

        public void SaveEmployee()
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_AddEmployee", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@First_Name", First_Name);
            sqlCommand.Parameters.AddWithValue("@Last_Name",Last_Name );
            sqlCommand.Parameters.AddWithValue("@NIC", NIC);
            sqlCommand.Parameters.AddWithValue("@DOB", DOB);
            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Contact_No", Contact_No);
            sqlCommand.Parameters.AddWithValue("@Address_Line1", Address_Line1);
            sqlCommand.Parameters.AddWithValue("@Address_Line2", Address_Line2);
            sqlCommand.Parameters.AddWithValue("@Department", "SPA");
            sqlCommand.Parameters.AddWithValue("@Designation", "Theropist");
            sqlCommand.Parameters.AddWithValue("@Date_Hired", Date_Hired);
            sqlCommand.Parameters.AddWithValue("@Bsic_Salary", "20000");

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public DataTable EmployeeDataView()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("spa_ViewSearchEmployee", sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchText",searchText );
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();
            return dataTable;
        }
        public void EmployeeUpdate(string ID)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_EditEmployee", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Emp_ID", ID);
            sqlCommand.Parameters.AddWithValue("@First_Name", First_Name);
            sqlCommand.Parameters.AddWithValue("@Last_Name", Last_Name);
            sqlCommand.Parameters.AddWithValue("@NIC", NIC);
            sqlCommand.Parameters.AddWithValue("@DOB", DOB);
            sqlCommand.Parameters.AddWithValue("@Gender", Gender);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Contact_No", Contact_No);
            sqlCommand.Parameters.AddWithValue("@Address_Line1", Address_Line1);
            sqlCommand.Parameters.AddWithValue("@Address_Line2", Address_Line2);
            sqlCommand.Parameters.AddWithValue("@Department", "SPA");
            sqlCommand.Parameters.AddWithValue("@Designation", "Therapist");
            sqlCommand.Parameters.AddWithValue("@Date_Hired", Date_Hired);
            sqlCommand.Parameters.AddWithValue("@Bsic_Salary", "30000");
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public void Spa_EmployeeDelete(string ID)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_DeleteEmployee", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Emp_ID", ID);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

    }
}
