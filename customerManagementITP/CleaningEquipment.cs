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
    class CleaningEquipment
    {

        //sql connection object 
        private SqlConnection csqlcon = DBConnection.getConnection();

        private int CEntryID;
        private String CItemIdID;
        private String CItemName;
        private int CQuantity;
        private float CUnitPrice;
        private float CTotalPrice;
        private String searchCleaningContent;



        public int CEntryID1 { get => CEntryID; set => CEntryID = value; }
        public string CItemIdID1 { get => CItemIdID; set => CItemIdID = value; }
        public string CItemName1 { get => CItemName; set => CItemName = value; }
        public int CQuantity1 { get => CQuantity; set => CQuantity = value; }
        public float CUnitPrice1 { get => CUnitPrice; set => CUnitPrice = value; }
        public string SearchCleaningContent { get => searchCleaningContent; set => searchCleaningContent = value; }
        public float CTotalPrice1 { get => CTotalPrice; set => CTotalPrice = value; }

        //public float CTotalPrice1 { get => CTotalPrice; set => CTotalPrice = value; }

        //Add hall equipment
        public bool insertCEquipment()
        {
            DBConnection.openDBConnection();

            SqlCommand csqlCmd = new SqlCommand("AddCleaningEquipment", csqlcon);
            csqlCmd.CommandType = CommandType.StoredProcedure;

            csqlCmd.Parameters.AddWithValue("@CItemIdID", CItemIdID);
            csqlCmd.Parameters.AddWithValue("@CItemName", CItemName);
            csqlCmd.Parameters.AddWithValue("@CQuantity", CQuantity);
            csqlCmd.Parameters.AddWithValue("@CUnitPrice", CUnitPrice);
            //csqlCmd.Parameters.AddWithValue("@CTotalPrice", CUnitPrice);
            



            if (csqlCmd.ExecuteNonQuery() == 1)
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

        //update Cleaning equipment
        public bool updateCEquipment()
        {

            DBConnection.openDBConnection();

            SqlCommand csqlCmd = new SqlCommand("updateCEquipment", csqlcon);
            csqlCmd.CommandType = CommandType.StoredProcedure;


            csqlCmd.Parameters.AddWithValue("@CItemIdID", CItemIdID);
            csqlCmd.Parameters.AddWithValue("@CItemName", CItemName);
            csqlCmd.Parameters.AddWithValue("@CQuantity", CQuantity);
            csqlCmd.Parameters.AddWithValue("@CUnitPrice", CUnitPrice);

            if (csqlCmd.ExecuteNonQuery() == 1)
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

        //search cleaning equipment
        public DataTable viewSearchCleaning()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchCleaningEquipment", csqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchCleaningContent", SearchCleaningContent);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentID", EquipmentID1);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie1);
            DataTable dtc = new DataTable();//datatable object for save the data
            sqlda.Fill(dtc);//get the data record

            DBConnection.closeDBConnection();

            return dtc;
        }


        //remove Cleaning equipment
        public void RemoveCleaningEquipment(int CEntryID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("RemoveCleaningEquipment", csqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@CEntryID", CEntryID);
            sqlCmd.ExecuteNonQuery();

            DBConnection.closeDBConnection();

        }



    }
}
