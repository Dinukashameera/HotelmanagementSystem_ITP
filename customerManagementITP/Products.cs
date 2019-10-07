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
    class Products
    {      
        private string brandName;
        private string productType;
        private string modelName;
        private string supplierNic;
        private float unitPriceProduct;
        private int quty;
        private float pPrice;
        private string productSearchtxt;

        private SqlConnection sqlcon = DBConnection.getConnection();
 
        public string BrandName { get => brandName; set => brandName = value; }
        public string ProductType { get => productType; set => productType = value; }
        public string ModelName { get => modelName; set => modelName = value; }
        public string SupplierNic { get => supplierNic; set => supplierNic = value; }
        public float UnitPriceProduct { get => unitPriceProduct; set => unitPriceProduct = value; }
        public int Quty { get => quty; set => quty = value; }
        public float PPrice { get => pPrice; set => pPrice = value; }
        public string ProductSearchtxt { get => productSearchtxt; set => productSearchtxt = value; }

        public void productSave()
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("addProduct", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@brandName", brandName);
            sqlCommand.Parameters.AddWithValue("@productType", productType);
            sqlCommand.Parameters.AddWithValue("@modelName", modelName);
            sqlCommand.Parameters.AddWithValue("@supplierNic", supplierNic);
            sqlCommand.Parameters.AddWithValue("@productUnitPrice", unitPriceProduct);
            sqlCommand.Parameters.AddWithValue("@quty", quty);
            sqlCommand.Parameters.AddWithValue("@ptotalAmount", pPrice);
             
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
       }

        public DataTable ProductDataView()
        {
            DBConnection.openDBConnection();
           
            SqlDataAdapter dataAdapter = new SqlDataAdapter("veiwSearchProduct", sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTxt", ProductSearchtxt);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();
            return dataTable;
        }
        public void ProductUpdate(int entryID)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("editProduct", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@entryID", entryID);
            sqlCommand.Parameters.AddWithValue("@brandName", brandName);
            sqlCommand.Parameters.AddWithValue("@productType", productType);
            sqlCommand.Parameters.AddWithValue("@modelName", modelName);
            sqlCommand.Parameters.AddWithValue("@supplierNic", supplierNic);
            sqlCommand.Parameters.AddWithValue("@productUnitPrice", unitPriceProduct);
            sqlCommand.Parameters.AddWithValue("@quty", quty);
            sqlCommand.Parameters.AddWithValue("@ptotalAmount", pPrice);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }
        public void ProductDelete(int entryID)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("deleteProduct", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@entryID", entryID);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }
    }
}

   

      
 