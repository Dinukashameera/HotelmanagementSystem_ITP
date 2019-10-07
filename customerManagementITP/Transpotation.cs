using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerManagementITP;

namespace Stock_Management_System
{
    class Transpotation
    {

        private SqlConnection tsqlcon = DBConnection.getConnection();
        private int TEntryID;
        private String TvehicalID;
        private String TVehicalCategory;
        private String TvehicleLicenseNo;
        private String TDriverName;
        private int TDriverMobileNo;
        private string searchTranspotationContent;

        public int TEntryID1 { get => TEntryID; set => TEntryID = value; }
        public string TvehicalID1 { get => TvehicalID; set => TvehicalID = value; }
        public string TVehicalCategory1 { get => TVehicalCategory; set => TVehicalCategory = value; }
        public string SearchTranspotationContent { get => searchTranspotationContent; set => searchTranspotationContent = value; }
        public string TvehicleLicenseNo1 { get => TvehicleLicenseNo; set => TvehicleLicenseNo = value; }
        public string TDriverName1 { get => TDriverName; set => TDriverName = value; }
        public int TDriverMobileNo1 { get => TDriverMobileNo; set => TDriverMobileNo = value; }

        //Add vehical equipment
        public bool insertTEquipment()
        {
            DBConnection.openDBConnection();

            SqlCommand tsqlCmd = new SqlCommand("Addvehical", tsqlcon);
            tsqlCmd.CommandType = CommandType.StoredProcedure;

            tsqlCmd.Parameters.AddWithValue("@TvehicalID", TvehicalID);
            tsqlCmd.Parameters.AddWithValue("@TVehicalCategory", TVehicalCategory);
            tsqlCmd.Parameters.AddWithValue("@TvehicleLicenseNo", TvehicleLicenseNo);
            tsqlCmd.Parameters.AddWithValue("@TDriverName", TDriverName);
            tsqlCmd.Parameters.AddWithValue("@TDriverMobileNo", TDriverMobileNo);



            if (tsqlCmd.ExecuteNonQuery() == 1)
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

        public bool updateTEquipment()
        {

            DBConnection.openDBConnection();

            SqlCommand tsqlCmd = new SqlCommand("updateTEquipment", tsqlcon);
            tsqlCmd.CommandType = CommandType.StoredProcedure;


            tsqlCmd.Parameters.AddWithValue("@TvehicalID", TvehicalID);
            tsqlCmd.Parameters.AddWithValue("@TVehicalCategory", TVehicalCategory);
            tsqlCmd.Parameters.AddWithValue("@TvehicleLicenseNo", TvehicleLicenseNo);
            tsqlCmd.Parameters.AddWithValue("@TDriverName", TDriverName);
            tsqlCmd.Parameters.AddWithValue("@TDriverMobileNo", TDriverMobileNo);

            if (tsqlCmd.ExecuteNonQuery() == 1)
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

        //search  Transpotation  
        public DataTable viewSearchTranspotation()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchVehical", tsqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchTranspotationContent", searchTranspotationContent);
            DataTable dtt = new DataTable();//datatable object for save the data
            sqlda.Fill(dtt);//get the data record

            DBConnection.closeDBConnection();

            return dtt;
        }

        public void Removetranspotation(int TEntryID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("RemoveVehical", tsqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@TEntryID", TEntryID);
            sqlCmd.ExecuteNonQuery();

            DBConnection.closeDBConnection();

        }
    }
}