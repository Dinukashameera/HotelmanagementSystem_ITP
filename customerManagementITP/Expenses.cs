using customerManagementITP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    class Expenses
    {

        private SqlConnection esqlcon = DBConnection.getConnection();

        private String ExpenseId;
        private string Department;
        private float Income;
        private float ExtraExpense;
        private float grandTotal;
        private DateTime Date;
        private String Field;
        private String Description;
        private String searchExpencesContent;


        private int searchExpenseEntryIDContent;

       
        public string Department1 { get => Department; set => Department = value; }
        public float Income1 { get => Income; set => Income = value; }
        public float GrandTotal { get => grandTotal; set => grandTotal = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
       
        public float ExtraExpense1 { get => ExtraExpense; set => ExtraExpense = value; }
        public int SearchExpenseEntryIDContent { get => searchExpenseEntryIDContent; set => searchExpenseEntryIDContent = value; }
        public string ExpenseId2 { get => ExpenseId; set => ExpenseId = value; }
        public string Field1 { get => Field; set => Field = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string SearchExpencesContent { get => searchExpencesContent; set => searchExpencesContent = value; }

        public float calSubTotal()
        {

            float total = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("select [dbo].CalcGrandTotal()", esqlcon);
            

            total = float.Parse(sqlCmd.ExecuteScalar().ToString());

            DBConnection.closeDBConnection();
            return total;

        }

        public bool insertExpense()
        {
            DBConnection.openDBConnection();

            SqlCommand ssqlCmd = new SqlCommand("AddExpense", esqlcon);
            ssqlCmd.CommandType = CommandType.StoredProcedure;

            ssqlCmd.Parameters.AddWithValue("@ExpenseId", ExpenseId);
            ssqlCmd.Parameters.AddWithValue("@Description", Description);
            ssqlCmd.Parameters.AddWithValue("@Date", Date);
            ssqlCmd.Parameters.AddWithValue("@grandTotal", grandTotal);


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

        public bool updateExpences()
        {

            DBConnection.openDBConnection();

            SqlCommand ssqlCmd = new SqlCommand("updateExpences", esqlcon);
            ssqlCmd.CommandType = CommandType.StoredProcedure;

            ssqlCmd.Parameters.AddWithValue("@ExpenseId", ExpenseId);
            ssqlCmd.Parameters.AddWithValue("@Description", Description);
            ssqlCmd.Parameters.AddWithValue("@Date", Date);
            ssqlCmd.Parameters.AddWithValue("@grandTotal", grandTotal);

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

        public DataTable viewSearchExpences()
        {

            DBConnection.openDBConnection();

            //sqlDataAdapter retriew the data
            SqlDataAdapter sqlda = new SqlDataAdapter("ViewOrSearchExpences", esqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;//specify the command type
            sqlda.SelectCommand.Parameters.AddWithValue("@searchExpencesContent", SearchExpencesContent);
           
            DataTable dtEx = new DataTable();//datatable object for save the data
            sqlda.Fill(dtEx);//get the data record

            DBConnection.closeDBConnection();

            return dtEx;
        }

        public void RemoveExpences(String ExpenseId)
        {

            DBConnection.openDBConnection();

            SqlCommand sqlCmd = new SqlCommand("Removeexpences", esqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ExpenseId", ExpenseId);
            sqlCmd.ExecuteNonQuery();




            DBConnection.closeDBConnection();

        }



    }
}
