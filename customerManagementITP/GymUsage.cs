using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerManagementITP
{
    class GymUsage
    {
        private String roomId;
        private int numOfMales;
        private int numOfFemales;
        private int numOfChildren;
        private int numOfAdults;
        private String nationality;
        private String searchText;
        private bool needTrainer;
        private int custIdentity;

        private double discountAmount;

        private double trainerFee = GymCharges.returnGymCharges("Trainer Fee");
        private double feePerAdult = GymCharges.returnGymCharges("Fee Per Adult");
        private double feePerChild = GymCharges.returnGymCharges("Fee Per Child");
        private double discountPercentage = GymCharges.returnGymCharges("Discount Percentage");


        private SqlConnection sqlcon = DBConnection.getConnection();

        public string RoomId { get => roomId; set => roomId = value; }
        public int NumOfMales { get => numOfMales; set => numOfMales = value; }
        public int NumOfFemales { get => numOfFemales; set => numOfFemales = value; }
        public int NumOfChildren { get => numOfChildren; set => numOfChildren = value; }
        public int NumOfAdults { get => numOfAdults; set => numOfAdults = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string SearchText { get => searchText; set => searchText = value; }
        public bool NeedTrainer { get => needTrainer; set => needTrainer = value; }
        public int CustIdentity { get => custIdentity; set => custIdentity = value; }
        public double TrainerFee { get => trainerFee; set => trainerFee = value; }
        public double FeePerAdult { get => feePerAdult; set => feePerAdult = value; }
        public double FeePerChild { get => feePerChild; set => feePerChild = value; }
        public double DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }


        public void save() {

            try
            {
                DBConnection.openDBConnection();

                //retreive registered customer's ID from data base
                custIdentity = returnCustomerIdentity();


                double fee = calcFee();

                //set parameters to stored procedure
                SqlCommand sqlCommand = new SqlCommand("SubmitGymUsageDetail", sqlcon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@customer_id", custIdentity);
                sqlCommand.Parameters.AddWithValue("@room", roomId);
                sqlCommand.Parameters.AddWithValue("@numberOfAdults", numOfAdults);
                sqlCommand.Parameters.AddWithValue("@numberOfChildren", numOfChildren);
                sqlCommand.Parameters.AddWithValue("@numberOfMale", numOfMales);
                sqlCommand.Parameters.AddWithValue("@numberOfFemale", numOfFemales);
                sqlCommand.Parameters.AddWithValue("@needTrainer", needTrainer);
                sqlCommand.Parameters.AddWithValue("@nationality", nationality);
                sqlCommand.Parameters.AddWithValue("@fee", fee);

                sqlCommand.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)


                MessageBox.Show("Successfully submited", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //store values to payment table
                SqlCommand sqlcmd1 = new SqlCommand("AddGymUsageFeeToPayment", sqlcon);
                sqlcmd1.CommandType = CommandType.StoredProcedure;

                sqlcmd1.Parameters.AddWithValue("@Customer_id", custIdentity);
                sqlcmd1.Parameters.AddWithValue("@Description", "Gym Cost");
                sqlcmd1.Parameters.AddWithValue("@Total", fee);

                sqlcmd1.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeDBConnection();
            }


        }


        public void update(int id)
        {
            if ((numOfAdults + numOfChildren) != (numOfMales + numOfFemales))
            {
                MessageBox.Show("Addition of Number of Adults and Number of Children should be equal to addtion of Number of Children and Number of Children. \nPlease Check again and Sumbit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("UpdateGymUsageDetail", sqlcon);   //create SqlCommand object by passing name of the stored procedure and connection object
                sqlcmd.CommandType = CommandType.StoredProcedure;   //set command type as Stored procedure

                //retreive registered customer's ID from data base
                custIdentity = returnCustomerIdentity();

                //set parameters to stored procedure
                sqlcmd.Parameters.AddWithValue("@useId", id);
                sqlcmd.Parameters.AddWithValue("@room", roomId);
                sqlcmd.Parameters.AddWithValue("@customer_id", custIdentity);
                sqlcmd.Parameters.AddWithValue("@numberOfAdults", numOfAdults);
                sqlcmd.Parameters.AddWithValue("@numberOfChildren", numOfChildren);
                sqlcmd.Parameters.AddWithValue("@numberOfMale", numOfMales);
                sqlcmd.Parameters.AddWithValue("@numberOfFemale", numOfFemales);
                sqlcmd.Parameters.AddWithValue("@needTrainer", needTrainer);
                sqlcmd.Parameters.AddWithValue("@nationality", nationality);
                sqlcmd.Parameters.AddWithValue("@fee", calcFee());

                sqlcmd.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)
                MessageBox.Show("Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection.closeDBConnection();

            }

        }

        public DataTable viewOrSearch()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("VieworSearchGymUsageDetail", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@seacrhText", SearchText);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);

            DBConnection.closeDBConnection();

            return dt;
        }

        public void delete(int id)
        {
            if (MessageBox.Show("Are you sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                DBConnection.openDBConnection();

                SqlCommand sqlcmd = new SqlCommand("DeleteGymUsageDetail", sqlcon);   //create SqlCommand object by passing name of the stored procedure and connection object
                sqlcmd.CommandType = CommandType.StoredProcedure;   //set command type as Stored procedure
                sqlcmd.Parameters.AddWithValue("@useId", id);

                sqlcmd.ExecuteNonQuery();  //execute the created sql command( stored procedure / query)
                MessageBox.Show("Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DBConnection.closeDBConnection();
            }
        }



        public double calcFee()
        {
            double fee;
            if (needTrainer == true)
            {
                if (numOfAdults >= 5)
                {
                    fee = (numOfAdults * FeePerAdult) + (numOfChildren * FeePerChild);

                    fee = fee - (fee * (DiscountPercentage / 100.0f));  // if numOfAdults >= 5 , give 5% discount

                    fee = fee + TrainerFee;

                    discountAmount = fee * (DiscountPercentage / 100.0f);
                }
                else
                {
                    fee = TrainerFee + (numOfAdults * FeePerAdult) + (numOfChildren * FeePerChild);
                }

                return fee;
            }
            else
            {

                if (numOfAdults >= 5)
                {
                    fee = (numOfAdults * FeePerAdult) + (numOfChildren * FeePerChild);

                    fee = fee - (fee * (DiscountPercentage / 100.0f));

                    discountAmount = fee * (DiscountPercentage / 100.0f);
                }
                else
                {
                    fee = (numOfAdults * FeePerAdult) + (numOfChildren * FeePerChild);
                }
                return fee;
            }
        }

        public int returnCustomerIdentity()
        {
            //retreive registered customer's ID from data base
            int custIDentity = 0;
            DBConnection.openDBConnection();
            SqlCommand sqlcmd1 = new SqlCommand("select customer_id from Accomodation where accID = '" + roomId + "'", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();
            custIDentity = Convert.ToInt32(sqlDr["customer_id"]);
            sqlDr.Close();
            DBConnection.openDBConnection();
            return custIDentity;
        }















    }
}
