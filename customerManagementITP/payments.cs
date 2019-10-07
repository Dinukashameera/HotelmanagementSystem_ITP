using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hall_Reservation
{
    class payment
    {
        private static SqlConnection sqlcon = DBConnection.getConnection();

        private String cus_id;
        private String totAmount;
        private String paymentMode;
        private int AdvancedPerc;
        private String AdvancedAmount;
        private String Status;
        private String Date;
        private String paidAmount;
        private String resAmount;
        private String completedDate;

        public string Cus_id { get => cus_id; set => cus_id = value; }
        public string TotAmount { get => totAmount; set => totAmount = value; }
        public string PaymentMode { get => paymentMode; set => paymentMode = value; }
        public string AdvancedAmount1 { get => AdvancedAmount; set => AdvancedAmount = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Date1 { get => Date; set => Date = value; }
        public int AdvancedPerc2 { get => AdvancedPerc; set => AdvancedPerc = value; }
        public string PaidAmount { get => paidAmount; set => paidAmount = value; }
        public string ResAmount { get => resAmount; set => resAmount = value; }
        public string CompletedDate { get => completedDate; set => completedDate = value; }

        public payment() { }

        public int halltypeprice(String hall)
        {
            DBConnection.openDBConnection();
            SqlCommand sql = new SqlCommand("select price from HRS_BLH_halltype where hall_type = '" + hall + "'", sqlcon);
            SqlDataReader sqldr = sql.ExecuteReader();
            sqldr.Read();

            int hallprice = Convert.ToInt32(sqldr["price"]);
            sqldr.Close();
            DBConnection.closeDBConnection();

            return hallprice;

        }

        public int foodtypeprice(String foodtype) {

            int foodprice = 0;

            if (foodtype == "premium")
            {
                foodprice = 70000;
            }
            else
                foodprice = 50000;

            return foodprice;
        }

        public int etypeprice(String eventtype)
        {
            DBConnection.openDBConnection();
            SqlCommand sql = new SqlCommand("select price from HRS_BLH_eventtype where event_type = '" + eventtype + "'", sqlcon);
            SqlDataReader sqldr = sql.ExecuteReader();
            sqldr.Read();

            int eventprice = Convert.ToInt32(sqldr["price"]);
            sqldr.Close();
            DBConnection.closeDBConnection();

            return eventprice;
        }

        public int barprice(String bar)
        {
            int barprice = 0;

            if (bar == "yes")
            {
                barprice = 10000;
            }
            else
                barprice = 0;

            return barprice;
        }

       /* public float advamount(float AdvancedPerc, float tot)
        {
           
            if(AdvancedPerc == 0.4)
            {
                tot = tot * AdvancedPerc;
            }
            else if(AdvancedPerc == 0.5)
            {
                tot = tot * AdvancedPerc;
            }
            else
            {
                tot = tot * AdvancedPerc;
            }

            return tot;
        }*/

        public void add() {

            DBConnection.openDBConnection();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("HRS_payment_add", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@paymentID", 0);
                sqlCmd.Parameters.AddWithValue("@cusID", Cus_id);
                sqlCmd.Parameters.AddWithValue("@paymentMode", PaymentMode);
                sqlCmd.Parameters.AddWithValue("@date", Date1);
                sqlCmd.Parameters.AddWithValue("@totAmount", TotAmount);
                sqlCmd.Parameters.AddWithValue("@paidAmount", PaidAmount);
                sqlCmd.Parameters.AddWithValue("@status", Status1);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }



        }

        public DataTable viewPendingPayments()
        {

            SqlCommand cmd = new SqlCommand("Select * from HRS_BLH_payments where status = 'Pending'", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;


        }

        

        public void updateCompletedDetails()
        {


            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("updateCompletedDetails", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@cusid", Cus_id);
            sqlCmd.Parameters.AddWithValue("@completedDate", CompletedDate);
            sqlCmd.Parameters.AddWithValue("@resAmount", ResAmount);
            sqlCmd.Parameters.AddWithValue("@status", Status1);


            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Completed successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            DBConnection.closeDBConnection();



        }

        public DataTable viewcutomercompleted()
        {
            SqlCommand cmd = new SqlCommand("Select * from HRS_customer_completed", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;
        }

        public DataTable viewcutomerpending()
        {
            SqlCommand cmd = new SqlCommand("Select * from HRS_customer_pending", sqlcon);
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqladpt = new SqlDataAdapter(cmd);
            sqladpt.Fill(dtbl);
            return dtbl;
        }


    }

}
    
