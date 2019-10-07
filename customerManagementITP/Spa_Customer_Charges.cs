using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerManagementITP;

namespace SPA
{
    class Spa_Customer_Charges
    {



        private String appointmentID;
        private int customerID;
        private int numberOfCustomers;
        private float servicePrice;
        private float discount;
        private float totalAmount;
        private String customerChargesSearchTxt;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public string AppointmentID { get => appointmentID; set => appointmentID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public int NumberOfCustomers { get => numberOfCustomers; set => numberOfCustomers = value; }
        public float ServicePrice { get => servicePrice; set => servicePrice = value; }
        public float Discount { get => discount; set => discount = value; }
        public float TotalAmount { get => totalAmount; set => totalAmount = value; }
        
        public String CustomerChargesSearchTxt { get => customerChargesSearchTxt; set => customerChargesSearchTxt = value; }


        public void CustomerChargesSave()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("Spa_AddCharges", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;


            sqlCommand.Parameters.AddWithValue("@appointmentId", appointmentID);
            sqlCommand.Parameters.AddWithValue("@customerId", customerID);
            sqlCommand.Parameters.AddWithValue("@numOfCustomers", numberOfCustomers);
            sqlCommand.Parameters.AddWithValue("@servicePrice", servicePrice);
            sqlCommand.Parameters.AddWithValue("@discount", discount);
            sqlCommand.Parameters.AddWithValue("@totalAmount", totalAmount);

           ;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }


        public DataTable CustomerChargesDataView()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("spa_viewSearchCharges", sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTxts",customerChargesSearchTxt );
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();
            return dataTable;

        }

        public void CustomerChargesUpdate(int payId)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCommand = new SqlCommand("spa_EditCharges", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@appointmentId", appointmentID);
            sqlCommand.Parameters.AddWithValue("@paymentId", payId);
            sqlCommand.Parameters.AddWithValue("@customerId", customerID);
            sqlCommand.Parameters.AddWithValue("@numOfCustomers", numberOfCustomers);
            sqlCommand.Parameters.AddWithValue("@servicePrice", servicePrice);
            sqlCommand.Parameters.AddWithValue("@discount", discount);
            sqlCommand.Parameters.AddWithValue("@totalAmount", totalAmount);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }

        public void CustomerChargesDelete(int payID)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_DeleteCharges", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@paymentId", payID);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }



    }
}
