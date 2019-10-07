using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using customerManagementITP;

namespace Hall_Reservation
{
    class HallType
    {
        private SqlConnection sqlcon = DBConnection.getConnection();

        private string hallType;
        private double price;
        private string description;

        public string HallType1 { get => hallType; set => hallType = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public HallType() { }

      //  SqlCommand sqlcmd = new SqlCommand("HRS_Hall_type_add", sqlcon);

        /*public void Add()
        {

            DBConnection.OpenDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_Hall_type_add", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Add");
            sqlCmd.Parameters.AddWithValue("@halltype", HallType1);
            sqlCmd.Parameters.AddWithValue("@price", Price);
            sqlCmd.Parameters.AddWithValue("@description", Description);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            DBConnection.CloseDBConnection();


        }
        */
        public void Update() {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_Hall_type_add", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Update");
            sqlCmd.Parameters.AddWithValue("@halltype", HallType1);
            sqlCmd.Parameters.AddWithValue("@price", Price);
            sqlCmd.Parameters.AddWithValue("@description", Description);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();
        }

        public void delete()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_hallType_delete", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@hall_type", HallType1);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();

        }

        public DataTable viewSearch()
        {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_HallType", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;


        }

    }
}
