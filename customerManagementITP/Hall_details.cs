using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using customerManagementITP;

namespace Hall_Reservation
{
    class Hall_details
    {
        private string cusID;
        private string halltype;
        private string HallName;
        private string eventtype;
        private string date;
        private string time;
        private string amPm;
        private string foodType;
        //private string additionalFood;
        //private string qty;
        private string bar;
        private string status;
        private string notes;
        private static SqlConnection sqlcon = DBConnection.getConnection();

        public string Halltype { get => halltype; set => halltype = value; }
        public string HallName1 { get => HallName; set => HallName = value; }
        public string Eventtype { get => eventtype; set => eventtype = value; }
        public string FoodType { get => foodType; set => foodType = value; }
        //public string AdditionalFood { get => additionalFood; set => additionalFood = value; }
        //public string Qty { get => qty; set => qty = value; }
        public string Bar { get => bar; set => bar = value; }
        public string Status { get => status; set => status = value; }
        public string Notes { get => notes; set => notes = value; }
        public string AmPm { get => amPm; set => amPm = value; }
        public string Time { get => time; set => time = value; }
        public string Date1 { get => date; set => date = value; }
        public string CusID { get => cusID; set => cusID = value; }

        public Hall_details() { }

        SqlCommand sqlcmd = new SqlCommand("HRS_Hall_Add", sqlcon);

        public void Add()
        {

            DBConnection.openDBConnection();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("HRS_Hall_Add", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@resID", 0);
                sqlCmd.Parameters.AddWithValue("@cusID", CusID);
                sqlCmd.Parameters.AddWithValue("@Halltype", Halltype);
                sqlCmd.Parameters.AddWithValue("@HallName", HallName);
                sqlCmd.Parameters.AddWithValue("@eventtype", eventtype);
                sqlCmd.Parameters.AddWithValue("@date", Date1);
                sqlCmd.Parameters.AddWithValue("@time", Time);
                sqlCmd.Parameters.AddWithValue("@amPm", amPm);
                sqlCmd.Parameters.AddWithValue("@foodType", foodType);
                //sqlCmd.Parameters.AddWithValue("@additionalFood", additionalFood);
                //sqlCmd.Parameters.AddWithValue("@qty", qty);
                sqlCmd.Parameters.AddWithValue("@bar", bar);
                sqlCmd.Parameters.AddWithValue("@status", status);
                sqlCmd.Parameters.AddWithValue("@notes", notes);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
            

        }
        
        public void update() {


            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_hall_update", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@cusID", CusID);
            sqlCmd.Parameters.AddWithValue("@Halltype", Halltype);
            sqlCmd.Parameters.AddWithValue("@HallName", HallName);
            sqlCmd.Parameters.AddWithValue("@eventtype", eventtype);
            sqlCmd.Parameters.AddWithValue("@date", Date1);
            sqlCmd.Parameters.AddWithValue("@time", Time);
            sqlCmd.Parameters.AddWithValue("@amPm", amPm);
            sqlCmd.Parameters.AddWithValue("@foodType", foodType);
            //sqlCmd.Parameters.AddWithValue("@additionalFood", additionalFood);
            //sqlCmd.Parameters.AddWithValue("@qty", qty);
            sqlCmd.Parameters.AddWithValue("@bar", bar);
            sqlCmd.Parameters.AddWithValue("@status", status);
            sqlCmd.Parameters.AddWithValue("@notes", notes);


            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();



        }

        public DataTable viewSearch()
        {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_hall", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;


        }

        public DataTable viewTable()
        {
            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_addFood", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
            sqladapter.Fill(dtbl);
            return dtbl;
        }


    }
}
