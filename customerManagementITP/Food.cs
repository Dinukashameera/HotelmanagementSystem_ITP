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
    class Food
    {
        private SqlConnection ksqlcon = DBConnection.getConnection();

        private String FoodID;
        private String FoodName;
        private String searchfoodContent;

        public string FoodID1 { get => FoodID; set => FoodID = value; }
        
        public string FoodName1 { get => FoodName; set => FoodName = value; }
        public string SearchfoodContent { get => searchfoodContent; set => searchfoodContent = value; }

        //Add foods

        public Boolean insertFoodItems(String foodId, String foodName, float Price)
        {
            DBConnection.openDBConnection();
            foodId = "F" + foodId;
            SqlCommand command = new SqlCommand("Insert INTO Meals VALUES(@foodId,@foodName,'Food',@Price)", ksqlcon);
            command.CommandType = CommandType.Text;

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@foodId", foodId);
            command.Parameters.AddWithValue("@foodName", foodName);
            command.Parameters.AddWithValue("@Price", Price);



            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("FOOD Information Added Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }


            DBConnection.closeDBConnection();
            return false;
        }

        public Boolean updateFoodItem(String foodName, String foodId, float Price)
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

        //method will display all the food items available in the data base
        public DataTable viewSearchfood()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Meals Where Food_Type = 'Food'", ksqlcon);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;

        }

        //the meathod will search the food item in the data grid
        public DataTable viewSearchfood(String name)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Meals Where Food_Name Like @name", ksqlcon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@name", name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;

        }

        public Boolean deleteFoodItem(String foodId)
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

        public Boolean confirmMealOrder(int customerId, String mealId, float Price)
        {
            DBConnection.openDBConnection();

            SqlCommand command = new SqlCommand("confirmMealOrder", ksqlcon);
            command.CommandType = CommandType.StoredProcedure;

            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@Customer_id", customerId);
            command.Parameters.AddWithValue("@Meal_id", mealId);
            command.Parameters.AddWithValue("@total", Price);


            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Order confirmed Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }


            DBConnection.closeDBConnection();
            return false;


        }



        public DataTable searchMealOrder(int customerId)
        {
            DBConnection.openDBConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MealOrder Where Customer_Id Like @Customer_id", ksqlcon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Customer_id", customerId);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);
            DBConnection.closeDBConnection();
            return datatable;


        }

        public DataTable getAllMealOrder()
        {
            DBConnection.openDBConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MealOrder", ksqlcon);
            command.CommandType = CommandType.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);
            DBConnection.closeDBConnection();
            return datatable;
        }



    }
}
