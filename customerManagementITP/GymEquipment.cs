using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerManagementITP
{
    public class GymEquipment
    {
        private String brandName;
        private String type;
        private String modelNumber;
        private String supplierid;
        private double unitPrice;
        private int quantity;
        private double totalPrice;
        private String purchaseddate;
        private String searchText;
        private SqlConnection sqlcon = DBConnection.getConnection();

        public GymEquipment()
        {

        }


        public string BrandName { get => brandName; set => brandName = value; }
        public string Type { get => type; set => type = value; }
        public string ModelNumber { get => modelNumber; set => modelNumber = value; }
        public string Supplierid { get => supplierid; set => supplierid = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Purchaseddate { get => purchaseddate; set => purchaseddate = value; }
        public string SearchText { get => searchText; set => searchText = value; }


        public void delete(int ID)
        {
            if (MessageBox.Show("Are You Sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("DeleteGymEquipment", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@equipmentId", ID);
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
                
        }


        public void save()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("AddGymEquipment", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@brandName",brandName);
            sqlcmd.Parameters.AddWithValue("@type_",type);
            sqlcmd.Parameters.AddWithValue("@model",modelNumber);
            sqlcmd.Parameters.AddWithValue("@unitPrice",unitPrice);
            sqlcmd.Parameters.AddWithValue("@quantity",quantity);
            sqlcmd.Parameters.AddWithValue("@totalPrice",totalPrice);
            sqlcmd.Parameters.AddWithValue("@supplierId",supplierid);
            sqlcmd.Parameters.AddWithValue("@purchasedDate",purchaseddate);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);



            //store values to incomeExpences table
            SqlCommand sqlcmd1 = new SqlCommand("AddGymEquipmentFeeToIncomeExpenses", sqlcon);
            sqlcmd1.CommandType = CommandType.StoredProcedure;

            sqlcmd1.Parameters.AddWithValue("@Expense", totalPrice);

            sqlcmd1.ExecuteNonQuery();



            DBConnection.closeDBConnection();
        }

        public void update(int ID)
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateGymEquipment", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@equipmentId", ID);
            sqlcmd.Parameters.AddWithValue("@brandName", brandName);
            sqlcmd.Parameters.AddWithValue("@type_", type);
            sqlcmd.Parameters.AddWithValue("@model", modelNumber);
            sqlcmd.Parameters.AddWithValue("@unitPrice", unitPrice);
            sqlcmd.Parameters.AddWithValue("@quantity", quantity);
            sqlcmd.Parameters.AddWithValue("@totalPrice", totalPrice);
            sqlcmd.Parameters.AddWithValue("@supplierId", supplierid);
            sqlcmd.Parameters.AddWithValue("@purchasedDate", purchaseddate);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();
        }

        public DataTable viewOrSearch()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("VieworSearchGymEquipment", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@searchText", searchText);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            

            DBConnection.closeDBConnection();
            return dt;
        }
    }
}
