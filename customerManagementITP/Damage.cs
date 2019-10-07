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
    class Damage
    {

        //sql connection object 
        private SqlConnection Dsqlcon = DBConnection.getConnection();

        private String item_no;
        private String item_name;
        private String item_des;
        private String Hall_des;
        private String item_name1; 
        private String searchDmageContent;

        public string Item_no { get => item_no; set => item_no = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Item_des { get => item_des; set => item_des = value; }
        public string Hall_des1 { get => Hall_des; set => Hall_des = value; }
        public string Item_name1 { get => item_name1; set => item_name1 = value; }
        public string SearchDmageContent { get => searchDmageContent; set => searchDmageContent = value; }



        //search Supplier equipment
        public DataTable viewSearchDamage()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchDamage", Dsqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchDmageContent", searchDmageContent);
            DataTable dtd = new DataTable();//datatable object for save the data
            sqlda.Fill(dtd);//get the data record

            DBConnection.closeDBConnection();

            return dtd;
        }





    }
}
