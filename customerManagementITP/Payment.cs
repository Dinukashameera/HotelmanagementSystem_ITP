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
    class Payment
    {
        private SqlConnection sqlcon = DBConnection.getConnection();

        public Boolean insetPayment(int customerId,String description,float total)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Payment(Customer_id,Description,Total) Values(@customerId,@description,@total)", sqlcon);
            command.CommandType = CommandType.Text;

            
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@description", description);
            
            command.Parameters.AddWithValue("@total", total);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sucessfully added", "Suecess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBConnection.closeDBConnection();
                return false;

            }
        }

        // SqlCommand Totalf = new SqlCommand("SELECT dbo.Tcupom(@code)", conex1);
        // SqlParameter code1 = new SqlParameter("@code", SqlDbType.Int);
        // code1.Value = cupom;
        // SAIDA = Totalf.ExecuteScalar();




        public double calculateTotal(int customer_id)
        {
            float total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].calculateCost(@customer_Id)", sqlcon);
            command.Parameters.AddWithValue("@customer_Id", customer_id);
            DBConnection.openDBConnection();
            total = float.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }

        public double calculateIndividualCost(int customer_id,String description)
        {
            float total = 0;
            SqlCommand command = new SqlCommand("SELECT [dbo].calculateIndividualCost(@customer_Id,@Description)", sqlcon);

            command.Parameters.AddWithValue("@customer_Id", customer_id);
            command.Parameters.AddWithValue("@Description", description);

            DBConnection.openDBConnection();
            total = float.Parse(command.ExecuteScalar().ToString());
            DBConnection.closeDBConnection();
            return total;
        }

        public Boolean finalizePayment(int customer_id)
        {
            SqlCommand command = new SqlCommand("finalizePayment", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() > 0)
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

        public Boolean deletePayment(int customer_id)
        {
            SqlCommand command = new SqlCommand("Delete Payment WHERE customer_id = @customer_id", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@customer_id", customer_id);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() == 1)
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


        public DataTable displayCheckinPayment()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Payment", sqlcon);
            //command.ExecuteNonQuery();
            //connection.openConnection();
            DataTable datatable = new DataTable();
            SqlDataAdapter sqldapter = new SqlDataAdapter(command);
            sqldapter.Fill(datatable);

            return datatable;

        }




        public Boolean getAccomodationIncome(int customer_id)
        {
            SqlCommand command = new SqlCommand("getAccomodationIncome", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() > 0)
            {
               // MessageBox.Show("Payment Sucessfully Finalized", "Sucess");
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                DBConnection.closeDBConnection();
                return false;
            }
        }

        public Boolean getGYMIncome(int customer_id)
        {
            SqlCommand command = new SqlCommand("getGYMIncome", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                // MessageBox.Show("Payment Sucessfully Finalized", "Sucess");
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                DBConnection.closeDBConnection();
                return false;
            }
        }


        public Boolean getSPAIncome(int customer_id)
        {
            SqlCommand command = new SqlCommand("getSPAIncome", sqlcon);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cid", customer_id);

            DBConnection.openDBConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                // MessageBox.Show("Payment Sucessfully Finalized", "Sucess");
                DBConnection.closeDBConnection();
                return true;
            }
            else
            {
                DBConnection.closeDBConnection();
                return false;
            }
        }


    }
}
