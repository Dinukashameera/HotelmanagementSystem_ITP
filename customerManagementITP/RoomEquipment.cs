using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerManagementITP;

namespace Stock_Management_System
{

    public class RoomEquipment  
    {

        private String EquipmentID;
        private String EquipmentCategorie;
        private String EquipmentBrand;
        private String EquipmentModel;
        private String Description;
        private int Quantity;
        private float UnitPrice;
        private float TotalPrice;
        private DateTime PurchasedDate;
        private Image Image;
        private String SearchContent;
        private int REntryID;
        private String FileName;

        //sql connection object 
        SqlConnection sqlcon = DBConnection.getConnection();

        public string EquipmentID1 { get => EquipmentID; set => EquipmentID = value; }
        public string EquipmentCategorie1 { get => EquipmentCategorie; set => EquipmentCategorie = value; }
        public string EquipmentBrand1 { get => EquipmentBrand; set => EquipmentBrand = value; }
        public string EquipmentModel1 { get => EquipmentModel; set => EquipmentModel = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public float UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public float TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
        public DateTime PurchasedDate1 { get => PurchasedDate; set => PurchasedDate = value; }
        public Image Image1 { get => Image; set => Image = value; }
        
        public string SearchContent1 { get => SearchContent; set => SearchContent = value; }
        public int REntryID1 { get => REntryID; set => REntryID = value; }
        public string FileName1 { get => FileName; set => FileName = value; }
        
        //add
        public void save() {

            //open the sqlconnection by calling method in DBconnection class
            DBConnection.openDBConnection();

            //create a sql command object 
            //parameters - StoredProcedure name and sql connection object 
            SqlCommand sqlCmd = new SqlCommand("RoomEquipmentAdd", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            

            //pass the parameters
            sqlCmd.Parameters.AddWithValue("@EquipmentID", EquipmentID);
            sqlCmd.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie);
            sqlCmd.Parameters.AddWithValue("@EquipmentBrand", EquipmentBrand);
            sqlCmd.Parameters.AddWithValue("@EquipmentModel", EquipmentModel);
            sqlCmd.Parameters.AddWithValue("@Description", Description);
            sqlCmd.Parameters.AddWithValue("@Quantity", Quantity);
            sqlCmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            //sqlCmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);//no textbox
           // sqlCmd.Parameters.AddWithValue("@PurchasedDate", PurchasedDate);
            //sqlCmd.Parameters.AddWithValue("@Image", Image);
            sqlCmd.ExecuteNonQuery();
            //MessageBox.Show("Saved Successfully");

            DBConnection.closeDBConnection();
            //close the connection by calling method in DBconnection

        }
        
        //update
        public void Update(String EquipmentID)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("UpdateRoomStock", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //entry
            //sqlCmd.Parameters.AddWithValue("@EntryID", EntryID);
            sqlCmd.Parameters.AddWithValue("@EquipmentID", EquipmentID);
            sqlCmd.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie);
            sqlCmd.Parameters.AddWithValue("@EquipmentBrand", EquipmentBrand);
            sqlCmd.Parameters.AddWithValue("@EquipmentModel", EquipmentModel);
            sqlCmd.Parameters.AddWithValue("@Description", Description);
            sqlCmd.Parameters.AddWithValue("@Quantity", Quantity);
            sqlCmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            //sqlCmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);//no textbox
           // sqlCmd.Parameters.AddWithValue("@PurchasedDate", PurchasedDate);
           // sqlCmd.Parameters.AddWithValue("@Image", Image);
            sqlCmd.ExecuteNonQuery();
            //MessageBox.Show("Saved Successfully");

            DBConnection.closeDBConnection();


        }

       
         
        //search
        public DataTable viewSearch()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchRoomEquipment", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchContent", SearchContent1);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentID", EquipmentID1);
            //sqlda.SelectCommand.Parameters.AddWithValue("@EquipmentCategorie", EquipmentCategorie1);
            DataTable dt = new DataTable();//datatable object for save the data
            sqlda.Fill(dt);//get the data record
            
            DBConnection.closeDBConnection();

            return dt;
        }

        //remove
        public void RemoveEquipment(int REntryID)
         {

                DBConnection.openDBConnection();

                SqlCommand sqlCmd = new SqlCommand("RemoveEquipment", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@REntryID", REntryID);
                sqlCmd.ExecuteNonQuery();
            



            DBConnection.closeDBConnection();

         }




        }

    } 


