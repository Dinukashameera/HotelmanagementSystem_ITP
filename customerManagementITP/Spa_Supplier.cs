using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using customerManagementITP;

namespace SPA
{
    class Spa_Supplier
    {

        private String supplierName;
        private String supplierNic;
        private String supplierType;
        private String saddressLie1;
        private String saddressLie2;
        private String city_Twon;
        private String supplierPhone;
        private String supplierEmail;
        private String description;
        private String searchtxt;

        //private float headMassage = 1000;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string SupplierNic { get => supplierNic; set => supplierNic = value; }
        public string SupplierType { get => supplierType; set => supplierType = value; }
        public string SaddressLine1 { get => saddressLie1; set => saddressLie1 = value; }
        public string SaddressLine2 { get => saddressLie2; set => saddressLie2 = value; }
        public string City_Twon { get => city_Twon; set => city_Twon = value; }
        public String SupplierPhone { get => supplierPhone; set => supplierPhone = value; }
        public string SupplierEmail { get => supplierEmail; set => supplierEmail = value; }
        public string Description { get => description; set => description = value; }
        public string Searchtxt { get => searchtxt; set => searchtxt = value; }

        public void SaveSupplier()
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_AddSupplier", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@supplierName", supplierName);
            sqlCommand.Parameters.AddWithValue("@supplierNic", supplierNic);
            sqlCommand.Parameters.AddWithValue("@supplierType", supplierType);
            sqlCommand.Parameters.AddWithValue("@saddressLine1", saddressLie1);
            sqlCommand.Parameters.AddWithValue("@saddressLine2", saddressLie2);
            sqlCommand.Parameters.AddWithValue("@city_Twon", city_Twon);
            sqlCommand.Parameters.AddWithValue("@supplierPhone", supplierPhone);
            sqlCommand.Parameters.AddWithValue("@supplierEmail", supplierEmail);
            sqlCommand.Parameters.AddWithValue("@description", description);

            //sqlCommand.Parameters.AddWithValue("@total", description);
            //sqlCommand.Parameters.AddWithValue("@description", description);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public DataTable SupplierView()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("spa_ViewSearchSupplier", sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTxt", Searchtxt);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();
            return dataTable;
        }


        public void SupplierUpdate(int sId)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_EditSupplier", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@sId_", sId);
            sqlCommand.Parameters.AddWithValue("@supplierName", supplierName);
            sqlCommand.Parameters.AddWithValue("@supplierNic", supplierNic);
            sqlCommand.Parameters.AddWithValue("@supplierType", supplierType);
            sqlCommand.Parameters.AddWithValue("@saddressLine1", saddressLie1);
            sqlCommand.Parameters.AddWithValue("@saddressLine2", saddressLie2);
            sqlCommand.Parameters.AddWithValue("@city_Twon", city_Twon);
            sqlCommand.Parameters.AddWithValue("@supplierPhone", supplierPhone);
            sqlCommand.Parameters.AddWithValue("@supplierEmail", supplierEmail);
            sqlCommand.Parameters.AddWithValue("@description", description);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }
        public void SupplierDelete(int supId)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_DeleteSupplier", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@sId_", supId);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

    }
}
