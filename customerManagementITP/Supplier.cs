using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using customerManagementITP;

namespace Stock_Management_System
{
    class Supplier
    {
        private SqlConnection ssqlcon = DBConnection.getConnection();

        private int SEntryID;
        private string SID;
        private string SName;
        private String SEmail;
        private int SContact;
        private String SDescription;
        private String searchSupplierContent;

        public int SEntryID1 { get => SEntryID; set => SEntryID = value; }
        public string SID1 { get => SID; set => SID = value; }
        public string SName1 { get => SName; set => SName = value; }
        public string SEmail1 { get => SEmail; set => SEmail = value; }
        public int SContact1 { get => SContact; set => SContact = value; }
        public string SDescription1 { get => SDescription; set => SDescription = value; }
        public string SearchSupplierContent { get => searchSupplierContent; set => searchSupplierContent = value; }

        //Add hall equipment
        public bool insertSuppliers()
        {
            DBConnection.openDBConnection();

            SqlCommand ssqlCmd = new SqlCommand("AddSupplier", ssqlcon);
            ssqlCmd.CommandType = CommandType.StoredProcedure;

            ssqlCmd.Parameters.AddWithValue("@SID", SID);
            ssqlCmd.Parameters.AddWithValue("@SName", SName);
            ssqlCmd.Parameters.AddWithValue("@SEmail", SEmail);
            ssqlCmd.Parameters.AddWithValue("@SContact", SContact);
            ssqlCmd.Parameters.AddWithValue("@SDescription", SDescription);
           

            if (ssqlCmd.ExecuteNonQuery() == 1)
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

        //update Supplier 
        public bool updateSupplier()
        {

            DBConnection.openDBConnection();

            SqlCommand ssqlCmd = new SqlCommand("UpdateSupplier", ssqlcon);
            ssqlCmd.CommandType = CommandType.StoredProcedure;


            ssqlCmd.Parameters.AddWithValue("@SID", SID);
            ssqlCmd.Parameters.AddWithValue("@SName", SName);
            ssqlCmd.Parameters.AddWithValue("@SEmail", SEmail);
            ssqlCmd.Parameters.AddWithValue("@SContact", SContact);
            ssqlCmd.Parameters.AddWithValue("@SDescription", SDescription);

            if (ssqlCmd.ExecuteNonQuery() == 1)
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

        //search Supplier equipment
        public DataTable viewSearchSupplier()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchSupplier", ssqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchSupplierContent", searchSupplierContent);
            DataTable dts = new DataTable();//datatable object for save the data
            sqlda.Fill(dts);//get the data record

            DBConnection.closeDBConnection();

            return dts;
        }

        //remove hall equipment
        public void RemoveSupplier(int SEntryID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("RemoveSupplier", ssqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@SEntryID", SEntryID);
            sqlCmd.ExecuteNonQuery();




            DBConnection.closeDBConnection();

        }

      



        
    }
}
