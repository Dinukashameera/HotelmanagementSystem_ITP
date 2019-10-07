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

    class RoomType
    {
        private SqlConnection sqlcon = DBConnection.getConnection();

        private float deluxePrice = 0;
        private float premiumPrice = 0;
        private float superiorPrice = 0;

        public float DPrice
        {
            get { return deluxePrice; }
            set
            {
                deluxePrice = value;
            }
        }

        public float PPrice
        {
            get
            {
                return premiumPrice;
            }
            set
            {
                premiumPrice = value;
            }
        }

        public float SPrice
        {
            get
            {
                return superiorPrice;
            }
            set
            {
                superiorPrice = value;
            }
        }


        public DataTable getAllroomType()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RoomType", sqlcon);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }

        public float getTypePrice(String type)
        {
            SqlCommand command = new SqlCommand("SELECT [dbo].getTypePrice(@typeName)", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@typeName", type);
            DBConnection.openDBConnection();

            return float.Parse(command.ExecuteScalar().ToString());
        }

        public Boolean updateTypePrice(String typeName,float newPrice)
        {
            SqlCommand command = new SqlCommand("updateTypePrice", sqlcon);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@typeName", typeName);
            command.Parameters.AddWithValue("@cost", newPrice);

            DBConnection.openDBConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Updated Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Could Not Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;
            }

        }
    }
}
