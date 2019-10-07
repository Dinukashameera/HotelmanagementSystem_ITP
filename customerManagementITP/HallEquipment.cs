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
    class HallEquipment
    {

        //sql connection object 
        private SqlConnection hsqlcon = DBConnection.getConnection();

        private String HEquipmentID;
        private String HEquipmentCategorie;
        private String HEquipmentBrand;
        private String HEquipmentModel;
        private String HDescription;
        private int HQuantity;
        private float HUnitPrice;
        private float HTotalPrice;
        private DateTime HPurchasedDate;
        private int HEntryID;
        private String searchHallContent;

        public string HEquipmentID1 { get => HEquipmentID; set => HEquipmentID = value; }
        public string HEquipmentCategorie1 { get => HEquipmentCategorie; set => HEquipmentCategorie = value; }
        public string HEquipmentBrand1 { get => HEquipmentBrand; set => HEquipmentBrand = value; }
        public string HEquipmentModel1 { get => HEquipmentModel; set => HEquipmentModel = value; }
        public string HDescription1 { get => HDescription; set => HDescription = value; }
        public int HQuantity1 { get => HQuantity; set => HQuantity = value; }
        public float HUnitPrice1 { get => HUnitPrice; set => HUnitPrice = value; }
        public float HTotalPrice1 { get => HTotalPrice; set => HTotalPrice = value; }
        public DateTime HPurchasedDate1 { get => HPurchasedDate; set => HPurchasedDate = value; }
        public int HEntryID1 { get => HEntryID; set => HEntryID = value; }
        public string SearchHallContent { get => searchHallContent; set => searchHallContent = value; }

        //Add hall equipment
        public bool insertHEquipment()
        {
            DBConnection.openDBConnection();

            SqlCommand hsqlCmd = new SqlCommand("AddHallEquipment", hsqlcon);
            hsqlCmd.CommandType = CommandType.StoredProcedure;

            hsqlCmd.Parameters.AddWithValue("@HEquipmentID", HEquipmentID);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentCategorie", HEquipmentCategorie);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentBrand", HEquipmentBrand);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentModel", HEquipmentModel);
            hsqlCmd.Parameters.AddWithValue("@HDescription", HDescription);
            hsqlCmd.Parameters.AddWithValue("@HQuantity", HQuantity);
            hsqlCmd.Parameters.AddWithValue("@HUnitPrice", HUnitPrice);
            //hsqlCmd.Parameters.AddWithValue("@HTotalPrice", HTotalPrice);
            //hsqlCmd.Parameters.AddWithValue("@HPurchasedDate", HPurchasedDate);

           

            if (hsqlCmd.ExecuteNonQuery() == 1)
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

        //update hall equipment
        public bool updateEquipment()
        {

            DBConnection.openDBConnection();

            SqlCommand hsqlCmd = new SqlCommand("UpdateHallStock", hsqlcon);
            hsqlCmd.CommandType = CommandType.StoredProcedure;


            hsqlCmd.Parameters.AddWithValue("@HEquipmentID", HEquipmentID);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentCategorie", HEquipmentCategorie);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentBrand", HEquipmentBrand);
            hsqlCmd.Parameters.AddWithValue("@HEquipmentModel", HEquipmentModel);
            hsqlCmd.Parameters.AddWithValue("@HDescription", HDescription);
            hsqlCmd.Parameters.AddWithValue("@HQuantity", HQuantity);
            hsqlCmd.Parameters.AddWithValue("@HUnitPrice",HUnitPrice);

            if (hsqlCmd.ExecuteNonQuery() == 1)
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
        //search hall equipment
        public DataTable viewSearchHall()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchHallEquipment", hsqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchHallContent", SearchHallContent);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentID", EquipmentID1);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie1);
            DataTable dth = new DataTable();//datatable object for save the data
            sqlda.Fill(dth);//get the data record

            DBConnection.closeDBConnection();

            return dth;
        }

        //remove hall equipment
        public void RemoveHallEquipment(int HEntryID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("RemoveHallEquipment", hsqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@HEntryID", HEntryID);
            sqlCmd.ExecuteNonQuery();




            DBConnection.closeDBConnection();

        }

    }
}
