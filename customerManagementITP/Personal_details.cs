using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hall_Reservation
{
    class Personal_details
    {
        private string cus_id;
        private string first_name;
        private string last_name;
        private string nic;
        private string address;
        private string email;
        private string phone;
        private string lang;
        private static SqlConnection sqlcon = DBConnection.getConnection();

        public Personal_details() { }

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Email { get => email; set => email = value; }
        public string Lang { get => lang; set => lang = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cus_id { get => cus_id; set => cus_id = value; }

        SqlCommand sqlcmd = new SqlCommand("HRS_CustomerDetails_Add", sqlcon);
       

        public void Add() {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_CustomerDetails_Add", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@cusID", 0);
                sqlCmd.Parameters.AddWithValue("@first_name", First_name);
                sqlCmd.Parameters.AddWithValue("@last_name", Last_name);
                sqlCmd.Parameters.AddWithValue("@nic", Nic);
                sqlCmd.Parameters.AddWithValue("@addr", Address);
                sqlCmd.Parameters.AddWithValue("@email", Email);
                sqlCmd.Parameters.AddWithValue("@mob", Phone);
                sqlCmd.Parameters.AddWithValue("@lang", Lang);

            if (!IsEmailValid() == true)
            {
                MessageBox.Show("Invalid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Nic.Length == 10) && !Regex.Match(Nic, "/^[0-9]{9}[vVxX]$/").Success)
            {
                MessageBox.Show("Invalid NIC number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Phone.Length == 10))
            {
                MessageBox.Show("Invalid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            DBConnection.closeDBConnection();


        }

        public bool IsEmailValid() {

            try {
                MailAddress m = new MailAddress(Email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void update() {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_customerDetails_update", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@first_name", First_name);
            sqlCmd.Parameters.AddWithValue("@last_name", Last_name);
            sqlCmd.Parameters.AddWithValue("@nic", Nic);
            sqlCmd.Parameters.AddWithValue("@addr", Address);
            sqlCmd.Parameters.AddWithValue("@email", Email);
            sqlCmd.Parameters.AddWithValue("@mob", Phone);
            sqlCmd.Parameters.AddWithValue("@lang", Lang);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();



        }


        public DataTable viewSearch() {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_customer", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;


        }
    }
}
