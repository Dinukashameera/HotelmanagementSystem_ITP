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
    class CheckedOut
    {
        private SqlConnection sqlcon = DBConnection.getConnection();


        public DataTable dispplayCheckoutCustomer()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CheckedOutCustomer", sqlcon);
            //command.ExecuteNonQuery();
            //connection.openConnection();
            DataTable datatable = new DataTable();
            SqlDataAdapter sqldapter = new SqlDataAdapter(command);
            sqldapter.Fill(datatable);

            return datatable;

        }

        public double getRevenue(String dateFrom,String dateTo)
        {
            float total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].generateCustomerIncome(@dateFrom,@dateTo)", sqlcon);

            command.Parameters.AddWithValue("@dateFrom", dateFrom);
            command.Parameters.AddWithValue("@dateTo", dateTo);

            DBConnection.openDBConnection();
            total = float.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }

        public int TotalCheckedOutCustomers(String dateFrom, String dateTo)
        {
            int total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].TotalCheckedOutCustomers(@dateFrom,@dateTo)", sqlcon);

            command.Parameters.AddWithValue("@dateFrom", dateFrom);
            command.Parameters.AddWithValue("@dateTo", dateTo);

            DBConnection.openDBConnection();
            total = int.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }

    }
}


