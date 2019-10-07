using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace customerManagementITP
{
    class DBConnection
    {
        private static SqlConnection sqlcon;

        public static SqlConnection getConnection()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=msi;Initial Catalog=Blue_Lotus_Hotel;Integrated Security=True");
            }
            return sqlcon;
        }

        private DBConnection() { }  //in order to use singleton

        public static void openDBConnection()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        public static void closeDBConnection()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }


}





//private SqlConnection conn = new SqlConnection(@"Data Source=msi;Initial Catalog=Blue_Lotus_Hotel;Integrated Security=True");


/*
 
         class DBConnection
    {
        private static SqlConnection sqlcon;

        public static SqlConnection getConnection()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(@"Data Source=LAPTOP-BUUAJ2F4\SQLEXPRESS;Initial Catalog=BLUELOTUS;Integrated Security=True");
            }
            return sqlcon;
        }

        private DBConnection() { }  //in order to use singleton

        public static void openDBConnection() {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        public static void closeDBConnection()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }
     
     
     
     
     
     
     
     */
