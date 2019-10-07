using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FinanceManagement_Blue_Lotus
{
    public class Expenditures
    {
        private String invoice_no;
        private String payment_Type;
        private String paymnt_date;
        private float ammount;
        SqlConnection sqlcon = DBConnection.getConnection();

        public Expenditures()
        {

        }

        public string Invoice_no { get => invoice_no; set => invoice_no = value; }
        public string Payment_Type { get => payment_Type; set => payment_Type = value; }
        public string Paymnt_date { get => paymnt_date; set => paymnt_date = value; }
        public float Ammount { get => ammount; set => ammount = value; }



        public void Store()
        {
            try
            {
                DBConnection.openDBConnection();

                SqlCommand sql_command = new SqlCommand("Expenditures_inserstion", sqlcon);

                sql_command.CommandType = CommandType.StoredProcedure;

                
                sql_command.Parameters.AddWithValue("@Invoice_no", invoice_no);
                sql_command.Parameters.AddWithValue("@Payment_Type", payment_Type);
                sql_command.Parameters.AddWithValue("@payment_date", paymnt_date);
                sql_command.Parameters.AddWithValue("@Ammount", ammount);

                sql_command.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Records..Please Check Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }
        }

        public DataTable FillGrid(String paymnt_date)
        {
            DataTable table = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Expenditure_table WHERE payment_date LIKE '%' +@date + '%'", sqlcon);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@date", paymnt_date);

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

        public float retrieveTotExpenditures(String date)
        {
            try
            {
                float amount = 0;
                DateTime date1 = Convert.ToDateTime(date);

                sqlcon.Open();
                SqlCommand command = new SqlCommand("select SUM(Ammount) as total from Expenditure_table where payment_date = '" + date1 + "'", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                amount = Convert.ToSingle(reader["total"]);
                reader.Close();
                /*sqlcon.Close();*/

                return amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Expenditures Found On This Day!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                sqlcon.Close();
            }


        }

    }

}



