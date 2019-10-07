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
    class Kitchen
    {
        private SqlConnection ksqlcon = DBConnection.getConnection();

        private int KEntryID;
        private String KKitchenwearID;
        private String KKitchenwearName;
        private String searchKitchenContent;
        private float KTotalPrice;
        private int KQuantity;
        private float KUnitPrice;
       
        public int KEntryID1 { get => KEntryID; set => KEntryID = value; }
        public string KKitchenwearID1 { get => KKitchenwearID; set => KKitchenwearID = value; }
        public string KKitchenwearName1 { get => KKitchenwearName; set => KKitchenwearName = value; }
        public string SearchKitchenContent { get => searchKitchenContent; set => searchKitchenContent = value; }
        public float KTotalPrice1 { get => KTotalPrice; set => KTotalPrice = value; }
        public int KQuantity1 { get => KQuantity; set => KQuantity = value; }
        public float KUnitPrice1 { get => KUnitPrice; set => KUnitPrice = value; }



        //Add vehical equipment
        public bool insertKEquipment()
        {
            DBConnection.openDBConnection();

            SqlCommand ksqlCmd = new SqlCommand("AddKitchenWear", ksqlcon);
            ksqlCmd.CommandType = CommandType.StoredProcedure;

            
            ksqlCmd.Parameters.AddWithValue("@KKitchenwearID", KKitchenwearID);
            ksqlCmd.Parameters.AddWithValue("@KKitchenwearName", KKitchenwearName);
            ksqlCmd.Parameters.AddWithValue("@KQuantity", KQuantity);
            ksqlCmd.Parameters.AddWithValue("@KUnitPrice", KUnitPrice);
            

            if (ksqlCmd.ExecuteNonQuery() == 1)
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

        public bool updateKEquipment()
        {

            DBConnection.openDBConnection();

            SqlCommand ksqlCmd = new SqlCommand("updateKEquipment", ksqlcon);
            ksqlCmd.CommandType = CommandType.StoredProcedure;


            ksqlCmd.Parameters.AddWithValue("@KKitchenwearID", KKitchenwearID);
            ksqlCmd.Parameters.AddWithValue("@KKitchenwearName", KKitchenwearName);
            ksqlCmd.Parameters.AddWithValue("@KQuantity", KQuantity);
            ksqlCmd.Parameters.AddWithValue("@KUnitPrice", KUnitPrice);

            if (ksqlCmd.ExecuteNonQuery() == 1)
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

        public DataTable viewSearchKitchen()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchKitchen", ksqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchKitchenContent", searchKitchenContent);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentID", EquipmentID1);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie1);
            DataTable dtk = new DataTable();//datatable object for save the data
            sqlda.Fill(dtk);//get the data record

            DBConnection.closeDBConnection();

            return dtk;
        }

        public void RemoveKitchenWear(int KEntryID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("RemoveKitchenWear", ksqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@KEntryID", KEntryID);
            sqlCmd.ExecuteNonQuery();

            DBConnection.closeDBConnection();

        }





    }




}
