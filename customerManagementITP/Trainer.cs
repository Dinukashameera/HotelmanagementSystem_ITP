using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public class Trainer
    {
        private String empID;
        private String fName;
        private String lName;
        private String DOB;
        private String NIC;
        private String trainerhiredDate;
        private String gender;
        private String email;
        private String contactNum;
        private String addLine1;
        private String addLine2;
        private String city;
        private String searchText;
        private double trainerBasicSalary = GymCharges.returnGymCharges("Trainer Basic Salary");
        private SqlConnection sqlcon = DBConnection.getConnection();


        public Trainer()
        {

        }

        public string EmpID { get => empID; set => empID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public string AddLine1 { get => addLine1; set => addLine1 = value; }
        public string AddLine2 { get => addLine2; set => addLine2 = value; }
        public string City { get => city; set => city = value; }
        public string SearchText { get => searchText; set => searchText = value; }
        public string TrainerhiredDate { get => trainerhiredDate; set => trainerhiredDate = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public double TrainerBasicSalary { get => trainerBasicSalary; set => trainerBasicSalary = value; }

        public void delete(int ID)
        {
            if (MessageBox.Show("Are you sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("DeleteGymTrainer", sqlcon);   //create SqlCommand object by passing name of the stored procedure and connection object
                sqlcmd.CommandType = CommandType.StoredProcedure;   //set command type as Stored procedure
                sqlcmd.Parameters.AddWithValue("@empID", ID);

                sqlcmd.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)
                MessageBox.Show("Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DBConnection.closeDBConnection();
            }
        }

        public void save()
        {

            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("AddGymTrainer", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@First_Name", fName);
            sqlcmd.Parameters.AddWithValue("@Last_Name", lName);

            sqlcmd.Parameters.AddWithValue("@NIC", NIC);

            sqlcmd.Parameters.AddWithValue("@DOB", DOB);
            sqlcmd.Parameters.AddWithValue("@Gender", gender);
            sqlcmd.Parameters.AddWithValue("@Email", email);
            sqlcmd.Parameters.AddWithValue("@Contact_No", contactNum);
            sqlcmd.Parameters.AddWithValue("@Address_Line_1", addLine1);
            sqlcmd.Parameters.AddWithValue("@Address_Line_2", addLine2);
            sqlcmd.Parameters.AddWithValue("@City_Town", city);
            sqlcmd.Parameters.AddWithValue("@Date_Hired", trainerhiredDate);
            sqlcmd.Parameters.AddWithValue("@Department", "Gym");
            sqlcmd.Parameters.AddWithValue("@Designation", "Trainer");
            sqlcmd.Parameters.AddWithValue("@Basic_Salary", TrainerBasicSalary);

            sqlcmd.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)
            MessageBox.Show("Added Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public void update(int ID)
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateGymTrainer", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;



            sqlcmd.Parameters.AddWithValue("@Emp_ID", ID);
            sqlcmd.Parameters.AddWithValue("@First_Name", fName);
            sqlcmd.Parameters.AddWithValue("@Last_Name", lName);
            sqlcmd.Parameters.AddWithValue("@NIC", NIC);
            sqlcmd.Parameters.AddWithValue("@DOB", DOB);
            sqlcmd.Parameters.AddWithValue("@Gender", gender);
            sqlcmd.Parameters.AddWithValue("@Email", email);
            sqlcmd.Parameters.AddWithValue("@Contact_No", contactNum);
            sqlcmd.Parameters.AddWithValue("@Address_Line_1", addLine1);
            sqlcmd.Parameters.AddWithValue("@Address_Line_2", addLine2);
            sqlcmd.Parameters.AddWithValue("@City_Town", city);
            sqlcmd.Parameters.AddWithValue("@Date_Hired", trainerhiredDate);
            sqlcmd.Parameters.AddWithValue("@Department", "Gym");
            sqlcmd.Parameters.AddWithValue("@Designation", "Trainer");
            sqlcmd.Parameters.AddWithValue("@Basic_Salary", TrainerBasicSalary);

            sqlcmd.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)
            MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public DataTable viewOrSearch()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("VieworSearchGymTrainer", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@seacrhText", SearchText);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);

            DBConnection.closeDBConnection();

            return dt;
        }

    }
}
