using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerManagementITP
{
    class GymCharges
    {
        private static SqlConnection sqlcon = DBConnection.getConnection();  //create db connection


        public static double returnGymCharges(String description)
        {
            double fee = 0f;
            DBConnection.openDBConnection();
            SqlCommand sqlcmd = new SqlCommand("select charge from Gym_Charges where description_ = '" + description + "'", sqlcon);
            SqlDataReader sqlDr = sqlcmd.ExecuteReader();
            sqlDr.Read();
            fee = Convert.ToDouble(sqlDr["charge"]);
            sqlDr.Close();
            DBConnection.openDBConnection();
            return fee;
        }
    }
}
