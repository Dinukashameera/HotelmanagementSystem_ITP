using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Management_System
{
    class Drink
    {
        private SqlConnection ksqlcon = DBConnection.getConnection();

        private String DrinkID;
        private String DrinkName;

        public string DrinkID1 { get => DrinkID; set => DrinkID = value; }
        public string DrinkName1 { get => DrinkName; set => DrinkName = value; }


        //Add Drinks
        public bool insertDrinks()
        {
            DBConnection.openDBConnection();

            SqlCommand dsqlCmd = new SqlCommand("AddDrink", ksqlcon);
            dsqlCmd.CommandType = CommandType.StoredProcedure;


            dsqlCmd.Parameters.AddWithValue("@DrinkID", DrinkID);
            dsqlCmd.Parameters.AddWithValue("@DrinkName", DrinkName);



            if (dsqlCmd.ExecuteNonQuery() == 1)
            {
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                DBConnection.closeDBConnection();
                return false;

            }

        }

        public Boolean insertDrinkDetails(String foodId, String foodName, float Price)
        {
            DBConnection.openDBConnection();
            foodId = "D" + foodId;
            SqlCommand command = new SqlCommand("Insert INTO Meals VALUES(@foodId,@foodName,'Drink',@Price)", ksqlcon);
            command.CommandType = CommandType.Text;

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@foodId", foodId);
            command.Parameters.AddWithValue("@foodName", foodName);
            command.Parameters.AddWithValue("@Price", Price);



            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Drink Information Added Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }


            DBConnection.closeDBConnection();
            return false;
        }


        public Boolean updateDrinkDetails(String foodId, String foodName, float Price)
        {
            DBConnection.openDBConnection();
            // foodId = "F" + foodId;
            SqlCommand command = new SqlCommand("Update Meals SET Food_Name = @foodName, Food_Price = @Price where Food_Id = @foodId", ksqlcon);
            command.CommandType = CommandType.Text;

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@foodId", foodId);
            command.Parameters.AddWithValue("@foodName", foodName);
            command.Parameters.AddWithValue("@Price", Price);



            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Item updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }


            DBConnection.closeDBConnection();
            MessageBox.Show("Item Unable Updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public DataTable viewDrinkItems()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Meals Where Food_Type = 'Drink'", ksqlcon);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;

        }

        public Boolean deleteDrinkItem(String foodId)
        {
            DBConnection.openDBConnection();
            //  foodId = "F" + foodId;
            SqlCommand command = new SqlCommand("Delete Meals Where Food_Id = @foodId", ksqlcon);
            command.CommandType = CommandType.Text;

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@foodId", foodId);

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Item Deleted Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }


            DBConnection.closeDBConnection();
            MessageBox.Show("Item Unable Updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }



    }



}
