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
    class OlderRecords
    {

        SqlConnection sqlcon = DBConnection.getConnection();
        DateTime currentDate = DateTime.Now;
        DateTime currentdate;
        String date , department;
        String recordType;
        float income;
        float expense;
        float amount;



        public string Date { get => date; set => date = value; }
        public string Department { get => department; set => department = value; }
        public string RecordType { get => recordType; set => recordType = value; }
        public float Income { get => income; set => income = value; }
        public float Expense { get => expense; set => expense = value; }
        public float Amount { get => amount; set => amount = value; }

        public void Delete_olderIncomeRecords_fromPayments(String date , String department)
                 {

                    DateTime date1 = Convert.ToDateTime(date);
                    currentdate = currentDate.AddYears(-5);

                    try
                     {
                         DBConnection.openDBConnection();

                        if ( currentdate >= date1)
                        {
                            SqlCommand sql_command = new SqlCommand("Delete_Income_Records_of_Payments", sqlcon);  //Delete_Expense_Records_of_Payments
                    sql_command.CommandType = CommandType.StoredProcedure;

                            sql_command.Parameters.AddWithValue("@date", date);
                            sql_command.Parameters.AddWithValue("@department", department);

                            sql_command.ExecuteNonQuery();
                            MessageBox.Show("Dleted Successfully");
                        }              

                         else
                         {

                             MessageBox.Show("Operation Failed!..You can only delete records whih are older than five years!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                         }

                     }


                     catch (Exception ex)
                     {
                         MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     finally
                     {
                         DBConnection.closeDBConnection();
                     }
                 }

        public void Delete_olderExpenseRecords_fromPayments(String date, String department)
        {

            DateTime date1 = Convert.ToDateTime(date);
            currentdate = currentDate.AddYears(-5);

            try
            {
                DBConnection.openDBConnection();

                if (currentdate >= date1)
                {
                    SqlCommand sql_command = new SqlCommand("Delete_Expense_Records_of_Payments", sqlcon);  
                    sql_command.CommandType = CommandType.StoredProcedure;

                    sql_command.Parameters.AddWithValue("@date", date);
                    sql_command.Parameters.AddWithValue("@department", department);

                    sql_command.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                }

                else
                {

                    MessageBox.Show("Operation Failed!..Ypu can only delete records whih are older than five years!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("System Error");
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }

        public void Delete_olderIncome_Records(String date , String department)
        {

            DateTime date1 = Convert.ToDateTime(date);
            currentdate = currentDate.AddYears(-5);

            try
            {
                DBConnection.openDBConnection();

                if (currentdate >= date1)
                {
                    SqlCommand sql_command = new SqlCommand("Delete_Income_Records", sqlcon);
                    sql_command.CommandType = CommandType.StoredProcedure;

                    sql_command.Parameters.AddWithValue("@date", date);
                    sql_command.Parameters.AddWithValue("@department", department);

                    sql_command.ExecuteNonQuery();
                    MessageBox.Show("Dleted Successfully");
                }

                else
                {

                    MessageBox.Show("Operation Failed!..You can only delete records which are older than five years!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }


        public void Delete_older_Expense_Records(String date , String department)
        {

            DateTime date1 = Convert.ToDateTime(date);
            currentdate = currentDate.AddYears(-5);

            try
            {
                DBConnection.openDBConnection();

                if (currentdate >= date1)
                {
                    SqlCommand sql_command = new SqlCommand("Delete_Expense_Records", sqlcon);
                    sql_command.CommandType = CommandType.StoredProcedure;

                    sql_command.Parameters.AddWithValue("@date", date);
                    sql_command.Parameters.AddWithValue("@department", department);

                    sql_command.ExecuteNonQuery();
                    MessageBox.Show("Dleted Successfully", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    MessageBox.Show("Operation Failed!..Ypu can only delete records which are older than five years!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                SqlCommand command = new SqlCommand("SELECT * FROM IncomeExpense WHERE Date LIKE '%' +@date + '%'", sqlcon); // me qury eka nikan man gahanne reports hadala na nisa ..naththam select * from Reports thamai table eka
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


        public void Save_Older_Records()
        {
            DateTime date1 = Convert.ToDateTime(date);
            currentdate = currentDate.AddYears(-5);

            try
            {
                DBConnection.openDBConnection();
                if (currentdate >= date1)
                {
                    SqlCommand sql_command = new SqlCommand("InsertDeleteRecords", sqlcon);
                    sql_command.CommandType = CommandType.StoredProcedure;

                    sql_command.Parameters.AddWithValue("@Department", department);
                    sql_command.Parameters.AddWithValue("@paymnt_date", date);
                    //sql_command.Parameters.AddWithValue("@income", Income);
                    //sql_command.Parameters.AddWithValue("@expense", Expense);

                    //sql_command.Parameters.AddWithValue("@income", Income);
                    //sql_command.Parameters.AddWithValue("@expense", Expense);
                    sql_command.Parameters.AddWithValue("@Ammount ", Amount);


                    sql_command.ExecuteNonQuery();

                    MessageBox.Show("Added To Deleted Records Successfully");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("System Error", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }

        }

    }
}
