using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA
{
    public class Service
    {

        private string serviceName;
        private String hours_;
        private String minutes_;
        private float price;
        private string searchtxt;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public string ServiceName{ get => serviceName; set => serviceName = value; }

        public String  Hours{ get => hours_; set => hours_ = value; }
        public String  Minutes{ get => minutes_; set => minutes_ = value; }

        public float Price { get => price; set => price = value; }

      

        public string Searchtxt { get => searchtxt; set => searchtxt = value; }

        public void ServiceSave()
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("addService", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@serviceName", serviceName);
            sqlCommand.Parameters.AddWithValue("@hours_", hours_);
            sqlCommand.Parameters.AddWithValue("@minutes_", minutes_);
            sqlCommand.Parameters.AddWithValue("@price", price);
          
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }

        
         public DataTable ServiceView()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("viewSearchService",sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchText", searchtxt);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();

            return dataTable;   

        }

        public void ServiceUpdate(int serviceId) {

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("editService", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@serviceId", serviceId );
            sqlCommand.Parameters.AddWithValue("@serviceName", serviceName);
            sqlCommand.Parameters.AddWithValue("@hours_", hours_);
            sqlCommand.Parameters.AddWithValue("@minutes_", minutes_);
            sqlCommand.Parameters.AddWithValue("@price", price);
          
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }

        public void ServiceDelete(int serviceId) {

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("deleteService", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@serviceId", serviceId);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }


    }
}
