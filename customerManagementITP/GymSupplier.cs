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
    public class GymSupplier 
    {
        private String name;
        private String id;
        private String address;
        private String contactNum;
        private String email;
        private String searchText;
        private SqlConnection sqlcon = DBConnection.getConnection();
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public string SearchText { get => searchText; set => searchText = value; }

        public GymSupplier()
        {

        }

        public void save()
        {

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("AddGymSupplier", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@supplierId", id);
                sqlcmd.Parameters.AddWithValue("@name_", name);
                sqlcmd.Parameters.AddWithValue("@address_", address);
                sqlcmd.Parameters.AddWithValue("@contactNumber", contactNum);
                sqlcmd.Parameters.AddWithValue("@email", email);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
        }
        public DataTable viewOrSearch()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchGymSupplier", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@seacrhText",searchText);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            DBConnection.closeDBConnection();

            return dt;
        }

        public void update(int ID)
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateGymSupplier", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@entryId", ID);
            sqlcmd.Parameters.AddWithValue("@supplierId", id);
            sqlcmd.Parameters.AddWithValue("@name_", name);
            sqlcmd.Parameters.AddWithValue("@address_", address);
            sqlcmd.Parameters.AddWithValue("@contactNumber", contactNum);
            sqlcmd.Parameters.AddWithValue("@email", email);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public void delete(int ID)
        {
            if (MessageBox.Show("Are you sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("DeleteGymSupplier", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@entryID", ID);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DBConnection.openDBConnection();
            }
        }
    }
}
