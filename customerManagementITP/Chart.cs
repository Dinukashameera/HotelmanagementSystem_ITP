using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace customerManagementITP
{


    class Chart
    {
        private SqlConnection sqlcon = DBConnection.getConnection();



        public DataTable getYearData(String year)
        {
            SqlCommand command = new SqlCommand("select YEAR(CAST(Checked_out_date as datetime)) as Year,Sum(Total) as Total from CheckedOutCustomer group by YEAR(CAST(Checked_out_date as datetime))", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@year", year);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }

        public DataTable getMonthData(String year)
        {
            SqlCommand command = new SqlCommand("select Month(CAST(Checked_out_date as datetime)) as Month,Sum(Total) as Total from CheckedOutCustomer Where YEAR(CAST(Checked_out_date as datetime)) = @year group by Month(CAST(Checked_out_date as datetime))", sqlcon);
            command.CommandType = CommandType.Text;

           command.Parameters.AddWithValue("@year", year);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }

        public DataTable getWeekhData(String year,String month)
        {

            //finding therespective month for the srting month value
            int monthNumber = 0;
            switch (month)
            {
                case "January":
                    monthNumber = 1;
                    break;
                case "Febraury":
                    monthNumber = 2;
                    break;

                case "March":
                    monthNumber = 3;
                    break;
                case "April":
                    monthNumber = 4;
                    break;

                case "May":
                    monthNumber = 5;
                    break;
                case "June":
                    monthNumber = 6;
                    break;

                case "July":
                    monthNumber = 7;
                    break;
                case "August":
                    monthNumber = 8;
                    break;
                case "September":
                    monthNumber = 9;
                    break;
                case "October":
                    monthNumber = 10;
                    break;
                    
                case "November":
                    monthNumber = 11;
                    break;
                case "December":
                    monthNumber = 12;
                    break;


            }






            SqlCommand command = new SqlCommand("select CONVERT(varchar,Checked_out_date,1) as date,SUM(Total) as total from CheckedOutCustomer Where YEAR(CAST(Checked_out_date as datetime)) = @year and Month(CAST(Checked_out_date as datetime)) = @month Group by Checked_out_date", sqlcon);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@month", monthNumber.ToString());
            command.Parameters.AddWithValue("@year", year);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable datatable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            return datatable;
        }



    }
}
