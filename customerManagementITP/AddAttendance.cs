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
    class AddAttendance
    {
        private String Emp_ID;
        private int Year_;
        private int Month_;
        private int Day_1;
        private int Day_2;
        private int Day_3;
        private int Day_4;
        private int Day_5;
        private int Day_6;
        private int Day_7;
        private int Day_8;
        private int Day_9;
        private int Day_10;
        private int Day_11;
        private int Day_12;
        private int Day_13;
        private int Day_14;
        private int Day_15;
        private int Total_Attendance;
        private SqlConnection sqlcon = DBConnection.getConnection();

        public string Emp_ID1 { get => Emp_ID; set => Emp_ID = value; }
        public int Year_1 { get => Year_; set => Year_ = value; }
        public int Month_1 { get => Month_; set => Month_ = value; }
        public int Day_16 { get => Day_1; set => Day_1 = value; }
        public int Day_21 { get => Day_2; set => Day_2 = value; }
        public int Day_31 { get => Day_3; set => Day_3 = value; }
        public int Day_41 { get => Day_4; set => Day_4 = value; }
        public int Day_51 { get => Day_5; set => Day_5 = value; }
        public int Day_61 { get => Day_6; set => Day_6 = value; }
        public int Day_71 { get => Day_7; set => Day_7 = value; }
        public int Day_81 { get => Day_8; set => Day_8 = value; }
        public int Day_91 { get => Day_9; set => Day_9 = value; }
        public int Day_101 { get => Day_10; set => Day_10 = value; }
        public int Day_111 { get => Day_11; set => Day_11 = value; }
        public int Day_121 { get => Day_12; set => Day_12 = value; }
        public int Day_131 { get => Day_13; set => Day_13 = value; }
        public int Day_141 { get => Day_14; set => Day_14 = value; }
        public int Day_151 { get => Day_15; set => Day_15 = value; }
        public int Total_Attendance1 { get => Total_Attendance; set => Total_Attendance = value; }

        public AddAttendance()
        {

        }
        public void updateEmpAttendance(int month, int year, int day, int EmpID)
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateAttendance", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", EmpID);
            sqlcmd.Parameters.AddWithValue("@Year_ ", year);
            sqlcmd.Parameters.AddWithValue("@Month_", month);
            sqlcmd.Parameters.AddWithValue("@Day_", day);
        

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee Attendance is Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }

        public void addAttendance()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("AddAttendance", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID1);
            sqlcmd.Parameters.AddWithValue("@Year_ ", Year_1);
            sqlcmd.Parameters.AddWithValue("@Month_", Month_);
            sqlcmd.Parameters.AddWithValue("@Day_1", Day_16);
            sqlcmd.Parameters.AddWithValue("@Day_2", Day_21);
            sqlcmd.Parameters.AddWithValue("@Day_3", Day_31);
            sqlcmd.Parameters.AddWithValue("@Day_4", Day_41);
            sqlcmd.Parameters.AddWithValue("@Day_5", Day_51);
            sqlcmd.Parameters.AddWithValue("@Day_6", Day_61);
            sqlcmd.Parameters.AddWithValue("@Day_7", Day_71);
            sqlcmd.Parameters.AddWithValue("@Day_8", Day_81);
            sqlcmd.Parameters.AddWithValue("@Day_9", Day_91);
            sqlcmd.Parameters.AddWithValue("@Day_10", Day_101);
            sqlcmd.Parameters.AddWithValue("@Day_11", Day_111);
            sqlcmd.Parameters.AddWithValue("@Day_12", Day_121);
            sqlcmd.Parameters.AddWithValue("@Day_13", Day_131);
            sqlcmd.Parameters.AddWithValue("@Day_14", Day_141);
            sqlcmd.Parameters.AddWithValue("@Day_15", Day_151);
            sqlcmd.Parameters.AddWithValue("@Total_Attendance", Total_Attendance1);


            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee is Added to the table !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }
        public void deleteEmpFromAttendance()

        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("DeleteEmpFromAttendance", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID1);
            try
            {
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Employee is deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("EMP id does not exist / is null !");
            }

            DBConnection.closeDBConnection();
        }



    }
}
