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
    class EventType
    {
        private SqlConnection sqlcon = DBConnection.getConnection();

        private string eventType;
        private double price;
        private string description;

        public string EventType1 { get => eventType; set => eventType = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public EventType() { }

     //   SqlCommand sqlcmd = new SqlCommand("HRS_Event_type_add", sqlcon);

        public void Add()
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_Event_type_add", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Add");
            sqlCmd.Parameters.AddWithValue("@eventtype", EventType1);
            sqlCmd.Parameters.AddWithValue("@price", Price);
            sqlCmd.Parameters.AddWithValue("@description", Description);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();


        }

        public void Update()
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_Eventtype_update", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@eventtype", EventType1);
            sqlCmd.Parameters.AddWithValue("@price", Price);
            sqlCmd.Parameters.AddWithValue("@description", Description);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();
        }

        public void delete()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("HRS_Event_Type_delete", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@event_type", EventType1);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();

        }

        public DataTable viewSearch()
        {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_EventType", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;


        }
    }
}
