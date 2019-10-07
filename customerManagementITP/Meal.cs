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
    class Meal
    {






        private SqlConnection sqlcon = DBConnection.getConnection();


        public DataTable getAllMeals()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Meals Where Food_type = 'Meal'", sqlcon);
            command.CommandType = CommandType.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }


        public DataTable getAllFoodType()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Meals Where Food_Id LIKE 'F%' or Food_Id LIKE 'D%'", sqlcon);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;

        }


        public DataTable getAllMealOrder()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM MealOrder Where Status = 'Pending' and (Meal_Id LIKE 'F%' or Meal_Id LIKE 'D%')", sqlcon);
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;

        }




        public Boolean addCustomerOrder(int customerId,String MealId,String MealName,int quantity,String time,String Room_ID,float Price)
        {
            SqlCommand command = new SqlCommand("Insert into MealOrder(Customer_Id,Meal_Id,Meal_Name,Quantity,Time,Room_ID,Price) Values(@customerId,@MealId,@MealName,@quantity,@time,@Room_ID,@Price)", sqlcon);
            command.CommandType = CommandType.Text;



            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@MealId", MealId);
            command.Parameters.AddWithValue("@MealName", MealName);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@Room_ID", Room_ID);
            command.Parameters.AddWithValue("@Price", Price);


            DBConnection.openDBConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {



                    MessageBox.Show("SuccessFully added", "Success");

                }
                else
                {


                    MessageBox.Show("Unable to Add the Order", "UnsucessFull");
                    return false;
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error ", "ERROR");

            }

            DBConnection.closeDBConnection();
            return true;

        }



        public Boolean addMealType(String mealName, int cid, String roodId)
        {
           
            SqlCommand command = new SqlCommand("addMealType", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@mealName", mealName);
            command.Parameters.AddWithValue("@cid", cid);
            command.Parameters.AddWithValue("@roodId", roodId);


            DBConnection.openDBConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Added sucessfull to The Orders", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;

            }
            else
            {
                MessageBox.Show("Error When adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;

            }
        }



        public float getMealOrderPrice(int customer_id)
        {
            //getting the accomodation cost of rooms
            float total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].getMealOrderPrice(@cid)", sqlcon);

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();
            total = float.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }










        public Boolean updateCustomerOrder(int customerId, String MealId, int quantity, String time, String Room_ID)
        {

            SqlCommand command = new SqlCommand("Update MealOrder set Quantity = @quantity, Time = @time, Room_ID = @Room_ID Where Customer_Id = @customerId AND Meal_Id = @MealId ", sqlcon);
            command.CommandType = CommandType.Text;



            // command.Parameters.AddWithValue("@customerIdentity", identity);

            command.Parameters.AddWithValue("@MealId", MealId);
            
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@Room_ID", Room_ID);
            command.Parameters.AddWithValue("@customerId", customerId);

            DBConnection.openDBConnection();

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {



                    MessageBox.Show("SuccessFully Updated", "Success");

                }
                else
                {


                    MessageBox.Show("Unable to Update the Order", "UnsucessFull");
                    return false;
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error ", "ERROR");

            }

            DBConnection.closeDBConnection();
            return true;
        }


        public Boolean deleteMealOrder(int customerId, String MealId)
        {
            SqlCommand command = new SqlCommand("Delete MealOrder  Where Customer_Id = @customerId AND Meal_Id = @MealId", sqlcon);
            command.CommandType = CommandType.Text;



            // command.Parameters.AddWithValue("@customerIdentity", identity);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@MealId", MealId);

            DBConnection.openDBConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {



                    MessageBox.Show("SuccessFully Deleted", "Success");

                }
                else
                {


                    MessageBox.Show("Unable to Delete the Order", "UnsucessFull");
                    return false;
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error ", "ERROR");

            }

            DBConnection.closeDBConnection();
            return true;
        }


        public DataTable searchMeal(String foodName)
        {
            SqlCommand command = new SqlCommand("SELECT* FROM Meals WHERE Food_Name LIKE  '%' + @foodName + '%'", sqlcon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@foodName", foodName);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }


        /*
         Get the total meal customer for a individual customer
         */









    }
}
