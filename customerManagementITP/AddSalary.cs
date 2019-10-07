using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using customerManagementITP;

namespace EmpManagementSystem
{
    class AddSalary
    {
        private String SalaryID;
        private String Emp_ID;
        private float OT_Hours;
        private float OT_Rate;
        private float Bonus;
        private float Allowance;
        private float Deduction;
        private double Total = 0.00;
        private int Year_;
        private int Month_;
        private SqlConnection sqlcon = DBConnection.getConnection();

        public AddSalary()
        {

        }

        public string SalaryID1 { get => SalaryID; set => SalaryID = value; }
        public string Emp_ID1 { get => Emp_ID; set => Emp_ID = value; }
        public float OT_Hours1 { get => OT_Hours; set => OT_Hours = value; }
        public float OT_Rate1 { get => OT_Rate; set => OT_Rate = value; }
        public float Bonus1 { get => Bonus; set => Bonus = value; }
        public float Allowance1 { get => Allowance; set => Allowance = value; }
        public float Deduction1 { get => Deduction; set => Deduction = value; }
        public double Total1 { get => Total; set => Total = value; }
        public int Year_1 { get => Year_; set => Year_ = value; }
        public int Month_1 { get => Month_; set => Month_ = value; }

       // SqlCommand sqlcmd = new SqlCommand("UpdateSalary", sqlcon);

        public void updateSalary()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateSalary", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

           /* sqlcmd.Parameters.AddWithValue("@SalaryID", SalaryID);*/
            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            sqlcmd.Parameters.AddWithValue("@OT_Hours", OT_Hours);
            sqlcmd.Parameters.AddWithValue("@OT_Rate", OT_Rate);
            sqlcmd.Parameters.AddWithValue("@Bonus", Bonus);
            sqlcmd.Parameters.AddWithValue("@Allowance", Allowance);
            sqlcmd.Parameters.AddWithValue("@Deduction", Deduction);
            sqlcmd.Parameters.AddWithValue("@Total", Total);
            sqlcmd.Parameters.AddWithValue("@Month_", Month_);
            sqlcmd.Parameters.AddWithValue("@Year_", Year_);




            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Salary is updated !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }
        public double gettot()
        {
            Total1 = (OT_Hours1 * OT_Rate1)+ Bonus1+ Allowance1- Deduction1;

            
            return Total1;


        }
        public void deleteEmpFromSalary()

        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("DeleteEmpFromSalary", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee is deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }
    }
}
