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
    class Incomes
    {
        String date;
        String department;
        float income_ammount;
       // DataTable incomeDataTable;
        
        SqlConnection sqlcon = DBConnection.getConnection();

        public string Date { get => date; set => date = value; }
        public string Department { get => department; set => department = value; }
        public float Income_ammount { get => income_ammount; set => income_ammount = value; }

        public float retrieveTotIncomes(String department, String date ) {

            //MessageBox.Show(date);
            try
            {
                float amount = 0;
                DateTime date1 = Convert.ToDateTime(date);
                //MessageBox.Show(date);
                //String date2 = date1.Date.ToString("dd/mm/yyyy");
                //MessageBox.Show(date2);

                sqlcon.Open();
                SqlCommand command = new SqlCommand("select SUM(Income) as total from IncomeExpense where Date = '" + date1 + "' and Department ='" + department + "' and Expense IS NULL ", sqlcon);
                //SqlCommand command = new SqlCommand("select SUM(Income) as total from IncomeExpense where Date = '9-10-2019' and Department ='Gym Management Department' and Expense IS NULL ", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["total"]);
                reader.Close();
                sqlcon.Close();

                return amount;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("No Incomes Found On This Day!" , "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                sqlcon.Close();
            }

            /*float amount = 0;

            SqlCommand command = new SqlCommand("select SUM(total) from Payments where date =@date and department= @department", sqlcon);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@department", department);
            command.Parameters.AddWithValue("@date", date);

            sqlcon.Open();

            amount = command.ExecuteNonQuery();
            sqlcon.Close();

            return amount;

/*              try
               {
                   float ammount = 0;

                   SqlCommand command = new SqlCommand("select [dbo].CalculateTotExpences(@department, @date) ", sqlcon);

                   command.Parameters.AddWithValue("@department", department);
                   command.Parameters.AddWithValue("@date", date);

                   MessageBox.Show(date,"date");
                   MessageBox.Show(department,"Department");

                   sqlcon.Open();

                   ammount = float.Parse(command.ExecuteScalar().ToString());
                  

                   return ammount;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("" + ex, "Error");
               }
               finally
               {
                   sqlcon.Close();
               }
               return 0;*/
               

            /* SqlCommand command = new SqlCommand("select SUM(total) from Payments where date =@date and department= @department", sqlcon);
             command.CommandType = CommandType.Text;
             command.Parameters.AddWithValue("@department", department);
             command.Parameters.AddWithValue("@date", date);


             SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable datatable = new DataTable();
             adapter.SelectCommand = command;
             adapter.Fill(datatable);

             return datatable;*/

        }


        public void insertTotIncomes() {

            try {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("InsertTotIncomes", sqlcon);
                sql_command.CommandType = CommandType.StoredProcedure;

                sql_command.Parameters.AddWithValue("@Department", department );
                sql_command.Parameters.AddWithValue("@paymnt_date", date);
                sql_command.Parameters.AddWithValue("@Ammount", income_ammount );

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

                SqlCommand command = new SqlCommand("SELECT * FROM TotalIncomes WHERE date LIKE '%' +@date + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@date", date);

                SqlDataAdapter adapter = new SqlDataAdapter();
                

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No Incomes Found On This Day!" , "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                return table;
        }


    }


}
