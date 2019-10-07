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
    class ProfitCalculations
    {
        float amount;
        String date;
        String department, status;
        Incomes income = new Incomes();
        Expences expence = new Expences();
        SqlConnection sqlcon = DBConnection.getConnection();
        Expenditures expenditure = new Expenditures();

        public float Amount { get => amount; set => amount = value; }
        public string Date { get => date; set => date = value; }
        public string Department { get => department; set => department = value; }
        public string Status { get => status; set => status = value; }

        public float Tot_Incomes_To_Calculate_profit(String date)
        {
            try
            {
                float amount = 0;
                DateTime date1 = Convert.ToDateTime(date);

                sqlcon.Open();
                SqlCommand command = new SqlCommand("select SUM(Ammount) as total from TotalIncomes where Date = '" + date1 + "'", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["total"]);
                reader.Close();
                /*sqlcon.Close();*/

                return amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Searches Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        public float Tot_Expenses_To_Calculate_profit(String date)
        {
            try
            {
                float amount = 0;
                DateTime date1 = Convert.ToDateTime(date);

                sqlcon.Open();
                SqlCommand command = new SqlCommand("select SUM(Ammount) as total from TotalExpenses where Date = '" + date1 + "'", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["total"]);
                reader.Close();
                return amount;
            }
            catch(Exception ex)
            {
               // MessageBox.Show("System Error" + ex.Message);
                MessageBox.Show("No Searches Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            finally
            {
                sqlcon.Close();
            }
            
        }


        public float calculate_Total_Department_Profit(String date, String department)
        {

            amount = income.retrieveTotIncomes(date, department) - expence.retrieveTotExpences(date, department);

            return amount;

        }


        public float calculate_Total_Profit(String date)
        {

            amount = (Tot_Incomes_To_Calculate_profit(date)) - (Tot_Expenses_To_Calculate_profit(date) + expenditure.retrieveTotExpenditures(date));

            return amount;

        }

        public void Insert_Profit()
        {

            //INSERT INTO Profit(Department , Date ,Ammount ,Status) VALUES (@Department , @date , @Ammount , @Status );



            try
            {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("InsertTotProfit", sqlcon);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@Department", Department);
                sql_command.Parameters.AddWithValue("@date", date);
                sql_command.Parameters.AddWithValue("@Ammount", amount);
                sql_command.Parameters.AddWithValue("@Status", Status);

                sql_command.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("This Record Already Exists");
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

                SqlCommand command = new SqlCommand("SELECT * FROM Profit WHERE date LIKE '%' +@date + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@date", date);

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





    }
}

