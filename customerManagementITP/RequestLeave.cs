using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using customerManagementITP;

namespace EmpManagementSystem
{
    class RequestLeave
    {
        private int LeaveID;
        private int Emp_ID;
        private string LeaveDate;
        private string Category;
        private string LeaveStatus;
        private SqlConnection sqlcon = DBConnection.getConnection();

        public int LeaveID1 { get => LeaveID; set => LeaveID = value; }
        public int Emp_ID1 { get => Emp_ID; set => Emp_ID = value; }
        public string LeaveDate1 { get => LeaveDate; set => LeaveDate = value; }
        public string Category1 { get => Category; set => Category = value; }
        public string LeaveStatus1 { get => LeaveStatus; set => LeaveStatus = value; }

        //SqlCommand sqlcmd = new SqlCommand("RequestLeave", sqlcon);

        public void RequestNewLeave()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("RequestLeave", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            /*sqlcmd.Parameters.AddWithValue("@LeaveID", LeaveID);*/
            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            sqlcmd.Parameters.AddWithValue("@LeaveDate", LeaveDate);
            sqlcmd.Parameters.AddWithValue("@Category", Category);
            sqlcmd.Parameters.AddWithValue("@LeaveStatus", LeaveStatus);
           

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Leave Request is succesfully sent !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }

        public void UpdateLeave()
        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("UpdateLeaveStatus", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@LeaveID", LeaveID);
            sqlcmd.Parameters.AddWithValue("@LeaveStatus", LeaveStatus);


            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Leave Request is responded !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();

        }

        public void deleteEmpFromLeave()

        {
            DBConnection.openDBConnection();

            SqlCommand sqlcmd = new SqlCommand("DeleteEmpFromLeave", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Emp_ID", Emp_ID);

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Employee is deleted !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DBConnection.closeDBConnection();
        }
    }
}
