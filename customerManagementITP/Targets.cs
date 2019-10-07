using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement_Blue_Lotus
{
    class Targets
    {
        String department, todate,fdate;
        float percentage, amount;
        SqlConnection sqlcon = DBConnection.getConnection();

        public string Department { get => department; set => department = value; }
        public string Todate { get => todate; set => todate = value; }
        public string Fdate { get => fdate; set => fdate = value; }
        public float Percentage { get => percentage; set => percentage = value; }
        public float Amount { get => amount; set => amount = value; }

        public float retrieveProfit(String department, String date)
        {

            float amount = 0;
            DateTime date1 = Convert.ToDateTime(date);

            sqlcon.Open();
            SqlCommand command = new SqlCommand("select Ammount as total from Profit where date = '" + date1 + "' and department ='" + department + "'", sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            amount = Convert.ToSingle(reader["total"]);
            reader.Close();
            sqlcon.Close();

            return amount;

        }

        public void Create_target_Insertion()
        {
            // Insert into Target VALUES(@Department , @ToDate  , @FromDate  , @ExpectedPercentage  , @TargetAmount )

            try
            {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("CreateTargetsToInsert", sqlcon);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@Department", Department);
                sql_command.Parameters.AddWithValue("@ToDate", Todate);
                sql_command.Parameters.AddWithValue("@FromDate", Fdate);
                sql_command.Parameters.AddWithValue("@ExpectedPercentage", Percentage);
                sql_command.Parameters.AddWithValue("@TargetAmount", Amount);

                sql_command.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("This Record Already Exists!");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }


        }


       public DataTable FillGrid(String date)
        {
            DataTable table = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Target WHERE ToDate LIKE '%' + @ToDate + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ToDate", date);

                SqlDataAdapter adapter = new SqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (Exception ex)
            {

                MessageBox.Show("System Error" + ex.Message);
            }
            return table;
        }


        public void Update_Epected_Percentage() {

            

            try
            {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("Update_percentage", sqlcon);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@ToDate", Todate);
                sql_command.Parameters.AddWithValue("@Department", Department);
                sql_command.Parameters.AddWithValue("@ExpectedPercentage", Percentage);
                sql_command.Parameters.AddWithValue("@Amount", Amount);

                sql_command.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("System Error" + ex.Message);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }

        public float Retreive_Expected_Amounts(String department,String date)
        {
            try { 
            float amount = 0;
            DateTime date1 = Convert.ToDateTime(date);

            sqlcon.Open();
            SqlCommand command = new SqlCommand("select TargetAmount as ExpectedAmount from Target where ToDate = '" + date1 + "' and Department ='" + department + "' ", sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            amount = Convert.ToSingle(reader["ExpectedAmount"]);
            reader.Close();
            sqlcon.Close();

            return amount;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("No Searches Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            finally
            {
                sqlcon.Close();
            }

        }

        /*        public float Retreive_Earned_Amounts(String department, String date)
                {
                    try
                    {
                        float amount = 0;
                        DateTime date1 = Convert.ToDateTime(date);

                        sqlcon.Open();
                        SqlCommand command = new SqlCommand("select Ammount from Profit where Date = '" + date1 + "' and Department ='" + department + "' ", sqlcon);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        amount = Convert.ToSingle(reader["Ammount"]);
                        reader.Close();
                        sqlcon.Close();

                        return amount;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("No Searches Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }

                    finally
                    {
                        sqlcon.Close();
                    }

                }*/


        public float retriewTargetAmountToMakeChart(String date)
        {

            try
            {
                float amount = 0;
                DateTime date1 = Convert.ToDateTime(date);

                sqlcon.Open();
                SqlCommand command = new SqlCommand("select TargetAmount as ExpectedAmount from Target where ToDate = '" + date1 + "' ", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["ExpectedAmount"]);
                reader.Close();
                sqlcon.Close();

                return amount;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("No Searches Found On This Day!", "Error!"+ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            finally
            {
                sqlcon.Close();
            }
        }


    }
}
