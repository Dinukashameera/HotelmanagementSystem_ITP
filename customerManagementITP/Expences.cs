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
    class Expences
    {
        String department;
        String date;
        float expense_ammount;


        SqlConnection sqlcon = DBConnection.getConnection();

        public string Department { get => department; set => department = value; }
        public string Date { get => date; set => date = value; }
        public float Expense_ammount { get => expense_ammount; set => expense_ammount = value; }

        public float retrieveTotExpences(String department, String date)
        {
            float amount = 0;
            DateTime date1 = Convert.ToDateTime(date);

            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("select SUM( Expense ) as total from IncomeExpense where Date = '" + date1 + "' and Department ='" + department + "' and Income IS NULL ", sqlcon);
                //SqlCommand command = new SqlCommand("select SUM( Expense ) as total from IncomeExpense where Date = '2019-10-13' and Department ='Inventory Management Department' and Income IS NULL ", sqlcon);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["total"]);
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Expenses Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                sqlcon.Close();
            }
            return amount;

            
/*            sqlcon.Open();
            SqlCommand command = new SqlCommand("select SUM(total) as total from Payments where date = '" + date1 + "' and department ='" + department + "' and payment_type = 'Expence' ", sqlcon);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            amount = Convert.ToSingle(reader["total"]);
            reader.Close();
            sqlcon.Close();

            return amount;*/

        }


        public void insertTotExpenses()
        {

            try
            {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("InsertTotExpenses", sqlcon);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@Department", department);
                sql_command.Parameters.AddWithValue("@paymnt_date", date);
                sql_command.Parameters.AddWithValue("@Ammount", Expense_ammount);

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

                SqlCommand command = new SqlCommand("SELECT * FROM TotalExpenses WHERE date LIKE '%' +@date + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@date", date);

                SqlDataAdapter adapter = new SqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (Exception ex)
            {

                MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }


    }
}
