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
    class Damage_items
    {
        private string itemNo;
        private string itemName;
        private string itemDes;
        private string hallDes;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public string ItemNo { get => itemNo; set => itemNo = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemDes { get => itemDes; set => itemDes = value; }
        public string HallDes { get => hallDes; set => hallDes = value; }

        public Damage_items() { }

       // SqlCommand sqlcmd = new SqlCommand("DamageItems_add", sqlcon);

        public void Add()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("DamageItems_add", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Add");
            sqlCmd.Parameters.AddWithValue("@itemNo", ItemNo);
            sqlCmd.Parameters.AddWithValue("@itemName", ItemName);
            sqlCmd.Parameters.AddWithValue("@itemDescript", ItemDes);
            sqlCmd.Parameters.AddWithValue("@hallDescript", HallDes);

            if(ItemNo == "" || ItemName == "" || ItemDes == "" || HallDes == "")
            {
                MessageBox.Show("Fields cannot be null!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            DBConnection.closeDBConnection();

        }

       
        public void update() {
            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("DamageItems_add", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Update");
            sqlCmd.Parameters.AddWithValue("@itemNo", ItemNo);
            sqlCmd.Parameters.AddWithValue("@itemName", ItemName);
            sqlCmd.Parameters.AddWithValue("@itemDescript", ItemDes);
            sqlCmd.Parameters.AddWithValue("@hallDescript", HallDes);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }

        public DataTable search(string ItemNo) {

            DBConnection.openDBConnection();

           SqlDataAdapter sqlCmd = new SqlDataAdapter("HRS_DamageItems_search", sqlcon);
           sqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
           sqlCmd.SelectCommand.Parameters.AddWithValue("@ItemNo", ItemNo);

           DataTable dt = new DataTable();
           
           sqlCmd.Fill(dt);
           
           DBConnection.closeDBConnection();

           return dt;
        }

        public DataTable viewSearch() {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_damage", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;
        }

        public void delete() {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("DamageItems_delete", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "Delete");
            sqlCmd.Parameters.AddWithValue("@itemNo", ItemNo);

            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();


        }
    }
}
