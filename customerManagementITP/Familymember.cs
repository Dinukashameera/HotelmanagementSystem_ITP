using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace customerManagementITP
{

    class Familymember
    {
        private SqlConnection sqlcon = DBConnection.getConnection();
       
        //insert family member details to the family member table
        public Boolean InsertMember(int id, String name, String adultChild, int childAge, String gender) {
            try
            {
                SqlCommand commad = new SqlCommand("addUpdateFamily", sqlcon);
                commad.CommandType = CommandType.StoredProcedure;
                commad.Parameters.AddWithValue("@id", id);
                commad.Parameters.AddWithValue("@name", name);
                commad.Parameters.AddWithValue("@adultChild", adultChild);
                commad.Parameters.AddWithValue("@gender", gender);
                commad.Parameters.AddWithValue("@childAge", childAge);
                DBConnection.openDBConnection();

                if (commad.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucess fully added", "Sucess");
                    DBConnection.closeDBConnection();

                    return true;


                }
                else
                {
                    MessageBox.Show("Error", "Error");
                    DBConnection.closeDBConnection();

                    return false;


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This Customer is Already Added","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }


        

        //display family member details int the data grid
        public DataTable GetFamilymembers()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM familyMember", sqlcon);
            //command.ExecuteNonQuery();
            //connection.openConnection();
            DataTable datatable = new DataTable();
            SqlDataAdapter sqldapter = new SqlDataAdapter(command);
            sqldapter.Fill(datatable);

            return datatable;


        }


        //update the family member details
        public Boolean updateMember(int regId,String name, String adultChild, int childAge, String gender)
        {
            SqlCommand commad = new SqlCommand("UpdateFamily", sqlcon);
            commad.CommandType = CommandType.StoredProcedure;
            commad.Parameters.AddWithValue("@id", regId);
            commad.Parameters.AddWithValue("@name", name);
            commad.Parameters.AddWithValue("@adultChild", adultChild);
            commad.Parameters.AddWithValue("@gender", gender);
            commad.Parameters.AddWithValue("@childAge", childAge);
            DBConnection.openDBConnection();

            if (commad.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sucess fully Updated", "Sucess");
                DBConnection.closeDBConnection();

                return true;
               

            }
            else
            {
                MessageBox.Show("Error", "Error");
                DBConnection.closeDBConnection();

                return false;
               

            }

        }

        public Boolean DeleteMember(int regId, String name)
        {
            SqlCommand commad = new SqlCommand("DeleteFamily", sqlcon);
            commad.CommandType = CommandType.StoredProcedure;
            commad.Parameters.AddWithValue("@id", regId);
            commad.Parameters.AddWithValue("@name", name);

            DBConnection.openDBConnection();

            if (commad.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sucess fully Deleted", "Sucess");
                DBConnection.closeDBConnection();

                return true;
                

            }
            else
            {
                MessageBox.Show("Error", "Error");
                DBConnection.closeDBConnection();

                return false;
               

            }
        }



        public DataTable SearchFamily(String name) {
            SqlCommand command = new SqlCommand("SELECT* FROM familyMember WHERE name LIKE  '%' + @name + '%'", sqlcon);
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
