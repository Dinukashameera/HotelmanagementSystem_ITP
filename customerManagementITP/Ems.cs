using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using customerManagementITP;

namespace EmpManagementSystem
{

    public partial class EmployeeMangementSystem : MetroFramework.Forms.MetroForm

    {

        // SqlConnection sqlCon = new SqlConnection(@" Data Source=DESKTOP-HRF0I37;Initial Catalog=Blue_Lotus_Hotel;Integrated Security=True");
        private SqlConnection sqlcon = DBConnection.getConnection();
        public EmployeeMangementSystem()
        {
            InitializeComponent();
            showNextEmpId();
            showNextSalId();
            showNextLeaveId();

        }
        public void showNextLeaveId()
        {
            int lastLeaveId = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlcmd1 = new SqlCommand("SELECT TOP 1 LeaveID FROM EmpLeaves ORDER BY LeaveID DESC", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();

            try
            {
                lastLeaveId = Convert.ToInt32(sqlDr["LeaveID"]);
            }
            catch (Exception ex)
            {
                lastLeaveId = 0;
            }
            sqlDr.Close();
            DBConnection.closeDBConnection();

            txtLeaveID.Text = Convert.ToString(lastLeaveId + 1);

        }
        public void showNextSalId()
        {
            int lastSalID = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlcmd1 = new SqlCommand("SELECT TOP 1 SalaryID FROM Salary ORDER BY SalaryID DESC", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();

            try
            {
                lastSalID = Convert.ToInt32(sqlDr["SalaryID"]);
            }
            catch (Exception ex)
            {
                lastSalID = 0;
            }
            sqlDr.Close();
            DBConnection.closeDBConnection();

            txtSalaryID.Text = Convert.ToString(lastSalID + 1);

        }
        public void showNextEmpId()
        {
            int lastEmpID = 0;
            DBConnection.openDBConnection();

            SqlCommand sqlcmd1 = new SqlCommand("SELECT TOP 1 Emp_ID FROM Emplyoees ORDER BY Emp_ID DESC", sqlcon);
            SqlDataReader sqlDr = sqlcmd1.ExecuteReader();
            sqlDr.Read();

            try
            {
                lastEmpID = Convert.ToInt32(sqlDr["Emp_ID"]);
            }
            catch (Exception ex)
            {
                lastEmpID = 0;
            }
            sqlDr.Close();
            DBConnection.closeDBConnection();

            txtEmpID1.Text = Convert.ToString(lastEmpID + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MetroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MetroTextBox11_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel31_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox25_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {

        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroLabel68_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel69_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel71_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel72_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox57_Click(object sender, EventArgs e)
        {

        }

        private void MetroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroLabel73_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox58_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton8_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroTextBox35_Click(object sender, EventArgs e)
        {

        }

        private void MetroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        AddEmployee ad1 = new AddEmployee();
        private void BtnAddEmp_Click(object sender, EventArgs e)
        {



            ad1.Emp_ID1 = txtEmpID1.Text.Trim().ToString();
            ad1.First_Name1 = txtFirstName1.Text.Trim().ToString();
            ad1.Last_Name1 = txtLastName1.Text.Trim().ToString();
            ad1.DOB1 = dateTimeDOB1.Value.ToString();
            ad1.NIC1 = txtNIC1.Text.Trim().ToString();
            /*  ad1.Gender1 = rdMale1.Text.Trim().ToString();
          }
          {
              ad1.Gender1 = rdFemale1.Text.Trim().ToString();
          }
          {*/
            ad1.Gender1 = ad1.Gender1;
            ad1.Contact_No1 = txtContactNo1.Text.Trim().ToString();
            ad1.Address_Line_11 = txtAdd11.Text.Trim().ToString();
            ad1.Address_Line_21 = txtAdd21.Text.Trim().ToString();
            ad1.City_Town1 = txtCityTown1.Text.Trim().ToString();
            ad1.Department1 = cmbboxDept1.Text.Trim().ToString();
            ad1.Designation1 = cmbDesignation1.Text.Trim().ToString();
            ad1.Date_Hired1 = dateTimeDhired1.Value.ToString();
            ad1.Basic_Salary1 = txtBsal1.Text.Trim().ToString();
            ad1.Email1 = txtEmail1.Text.Trim().ToString();


            ad1.addNewEmployee();




            try
            {
                newlyAddedEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ! Check Your inputs. ");
            }


        }

        private void TxtEmpID1_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void newlyAddedEmployee()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchEmployees", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtEmpID1.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            newlyaddedemp.DataSource = dtbl;

            sqlcon.Close();
        }
        void newlyAddedLeaveRequest()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchLeave", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@LeaveID", txtLeaveID.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtEmpIDLE.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            RequestLeave.DataSource = dtbl;

            sqlcon.Close();
        }
        void fillDataGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchEmployees", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtSeEmpId2.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            addedEmps.DataSource = dtbl;

            sqlcon.Close();
        }
        void fillDataGridView3()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchEmployees", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtSeEmpId3.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            upsearch.DataSource = dtbl;

            sqlcon.Close();
        }

        void viewAttendanceList()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAttendanceList", sqlcon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            attendancegrid.DataSource = dtbl;

            sqlcon.Close();

        }

        void viewAllEmps()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAllEmployees", sqlcon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            addedEmps.DataSource = dtbl;

            sqlcon.Close();

        }
        void viewAllSalaryRecords()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAllSalaryRecords", sqlcon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            saldet.DataSource = dtbl;

            sqlcon.Close();

        }
        void viewallLeaves()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("ViewAllLeaveRequests", sqlcon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            metroGrid1.DataSource = dtbl;

            sqlcon.Close();

        }
        void fillDataGridView4()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchEmployees", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtSeEmpId4.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            delemp.DataSource = dtbl;

            sqlcon.Close();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void AddedEmps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmpID2.Text = addedEmps.CurrentRow.Cells[0].Value.ToString();
                txtFirstName2.Text = addedEmps.CurrentRow.Cells[1].Value.ToString();
                txtLastName2.Text = addedEmps.CurrentRow.Cells[2].Value.ToString();
                txtNIC2.Text = addedEmps.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB2.Text = addedEmps.CurrentRow.Cells[4].Value.ToString();
                cmbGender2.Text = addedEmps.CurrentRow.Cells[5].Value.ToString();
                txtEmail2.Text = addedEmps.CurrentRow.Cells[6].Value.ToString();
                txtContactNo2.Text = addedEmps.CurrentRow.Cells[7].Value.ToString();
                txtAdd12.Text = addedEmps.CurrentRow.Cells[8].Value.ToString();
                txtAdd22.Text = addedEmps.CurrentRow.Cells[9].Value.ToString();
                txtCityTown2.Text = addedEmps.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept2.Text = addedEmps.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation2.Text = addedEmps.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired2.Text = addedEmps.CurrentRow.Cells[13].Value.ToString();
                txtBsal2.Text = addedEmps.CurrentRow.Cells[14].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }



        }

        private void MetroGrid4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroLabel11_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroButton11_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroButton12_Click(object sender, EventArgs e)
        {
            AddAttendance aa1 = new AddAttendance();

            aa1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();


            aa1.Day_16 = 0;
            aa1.Day_21 = 0;
            aa1.Day_31 = 0;
            aa1.Day_41 = 0;
            aa1.Day_51 = 0;
            aa1.Day_61 = 0;
            aa1.Day_71 = 0;
            aa1.Day_81 = 0;
            aa1.Day_91 = 0;
            aa1.Day_101 = 0;
            aa1.Day_111 = 0;
            aa1.Day_121 = 0;
            aa1.Day_131 = 0;
            aa1.Day_141 = 0;
            aa1.Day_151 = 0;
            aa1.Total_Attendance1 = 0;

            aa1.addAttendance();

            try
            {
                newlyAddedEmptoAtt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void newlyAddedEmptoAtt()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchAttendanceEmps", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@Emp_ID", txtEmpIDAtt.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            attendancegrid.DataSource = dtbl;

            sqlcon.Close();
        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RdMale2_CheckedChanged(object sender, EventArgs e)
        {

            ad1.Gender1 = "Male";

        }

        private void RdFemale2_CheckedChanged(object sender, EventArgs e)
        {
            ad1.Gender1 = "Female";
        }

        private void MetroLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void AddedEmps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void MetroLabel78_Click(object sender, EventArgs e)
        {

        }
        void viewSalaryDetails()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("SearchSalary", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDa.SelectCommand.Parameters.AddWithValue("@SalaryID", txtSalaryID.Text.Trim());
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
            saldet.DataSource = dtbl;

            sqlcon.Close();
        }


        private void MetroButton9_Click(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();

            as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
            as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
            as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
            as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
            as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());

            double tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;

            as1.updateSalary();

            try
            {
                viewSalaryDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }

        }

        private void MetroButton8_Click_1(object sender, EventArgs e)
        {


            AddSalary as1 = new AddSalary();

            as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
            as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
            as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
            as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
            as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());

            double tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;

            /*float tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;


            txtTotal.Text = (tot.ToString());*/

            txtTotal.Text = as1.gettot().ToString();

        }

        private void MetroLabel79_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel76_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton10_Click(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();

            rl1.LeaveID1 = int.Parse(txtLeaveID.Text.Trim().ToString());
            rl1.Emp_ID1 = int.Parse(txtEmpIDLE.Text.Trim().ToString());
            rl1.LeaveDate1 = txtLeaveDateLE.Value.ToString();
            rl1.Category1 = cmbLeaveCategoryLE.Text.Trim().ToString();
            rl1.LeaveStatus1 = "Pending";

            rl1.RequestNewLeave();


            try
            {
                newlyAddedLeaveRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }


        }

        private void MetroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNameLE_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton8_Click_2(object sender, EventArgs e)
        {
            try
            {
                viewallLeaves();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void MetroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void Upsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Upsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmpID3.Text = upsearch.CurrentRow.Cells[0].Value.ToString();
                txtFirstName3.Text = upsearch.CurrentRow.Cells[1].Value.ToString();
                txtLastName3.Text = upsearch.CurrentRow.Cells[2].Value.ToString();
                txtNIC3.Text = upsearch.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB3.Text = upsearch.CurrentRow.Cells[4].Value.ToString();
                cmbGender3.Text = upsearch.CurrentRow.Cells[5].Value.ToString();
                //rdFemale3.Text = upsearch.CurrentRow.Cells[5].Value.ToString();
                txtEmail3.Text = upsearch.CurrentRow.Cells[6].Value.ToString();
                txtContactNo3.Text = upsearch.CurrentRow.Cells[7].Value.ToString();
                txtAdd13.Text = upsearch.CurrentRow.Cells[8].Value.ToString();
                txtAdd23.Text = upsearch.CurrentRow.Cells[9].Value.ToString();
                txtCityTown3.Text = upsearch.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept3.Text = upsearch.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation3.Text = upsearch.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired3.Text = upsearch.CurrentRow.Cells[13].Value.ToString();
                txtBsal3.Text = upsearch.CurrentRow.Cells[14].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }
        }

        private void Upsearch_DoubleClick(object sender, EventArgs e)
        {

        }

        private void MetroButton5_Click_1(object sender, EventArgs e)
        {
            AddEmployee ad2 = new AddEmployee();

            ad2.Emp_ID1 = txtEmpID3.Text.Trim().ToString();
            ad2.First_Name1 = txtFirstName3.Text.Trim().ToString();
            ad2.Last_Name1 = txtLastName3.Text.Trim().ToString();
            ad2.NIC1 = txtNIC3.Text.Trim().ToString();
            ad2.DOB1 = dateTimeDOB3.Value.ToString();
            ad2.Gender1 = cmbGender3.Text.Trim().ToString();

            ad2.Email1 = txtEmail1.Text.Trim().ToString();
            ad2.Contact_No1 = txtContactNo3.Text.Trim().ToString();
            ad2.Address_Line_11 = txtAdd13.Text.Trim().ToString();
            ad2.Address_Line_21 = txtAdd23.Text.Trim().ToString();
            ad2.City_Town1 = txtCityTown3.Text.Trim().ToString();
            ad2.Department1 = cmbboxDept3.Text.Trim().ToString();
            ad2.Designation1 = cmbDesignation3.Text.Trim().ToString();
            ad2.Date_Hired1 = dateTimeDhired3.Value.ToString();
            ad2.Basic_Salary1 = txtBsal3.Text.Trim().ToString();

            ad2.updateEmployee();

        }

        private void MetroLabel77_Click(object sender, EventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroButton2_Click_2(object sender, EventArgs e)

        {
            RequestLeave rl1 = new RequestLeave();
            rl1.LeaveID1 = int.Parse(txtLeaveIDup.Text.Trim().ToString());
            rl1.LeaveStatus1 = cmbRes.Text.Trim().ToString();
            rl1.UpdateLeave();
        }

        private void Delemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtEmpID4.Text = delemp.CurrentRow.Cells[0].Value.ToString();
                txtFirstName4.Text = delemp.CurrentRow.Cells[1].Value.ToString();
                txtLastName4.Text = delemp.CurrentRow.Cells[2].Value.ToString();
                txtNIC4.Text = delemp.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB4.Text = delemp.CurrentRow.Cells[4].Value.ToString();
                cmbGender4.Text = delemp.CurrentRow.Cells[5].Value.ToString();
                txtEmail4.Text = delemp.CurrentRow.Cells[6].Value.ToString();
                txtContactNo4.Text = delemp.CurrentRow.Cells[7].Value.ToString();
                txtAdd14.Text = delemp.CurrentRow.Cells[8].Value.ToString();
                txtAdd24.Text = delemp.CurrentRow.Cells[9].Value.ToString();
                txtCityTown4.Text = delemp.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept4.Text = delemp.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation4.Text = delemp.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired4.Text = delemp.CurrentRow.Cells[13].Value.ToString();
                txtBsal4.Text = delemp.CurrentRow.Cells[14].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }
        }

        private void Delemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {

            AddEmployee ad3 = new AddEmployee();
            ad3.Emp_ID1 = txtSeEmpId4.Text.Trim().ToString();


            ad3.deleteEmployee();
        }

        private void BtnViewAllEmps_Click(object sender, EventArgs e)
        {
            try
            {
                viewAllEmps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void BtnViewAttendanceList_Click(object sender, EventArgs e)
        {
            try
            {
                viewAttendanceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void BtnUpdateAttendance_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click_2(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();
            as1.Emp_ID1 = txtDeleteEmpRecords.Text.Trim().ToString();


            as1.deleteEmpFromSalary();
        }

        private void MetroButton8_Click_3(object sender, EventArgs e)
        {
            try
            {
                viewAllSalaryRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            AddAttendance AD1 = new AddAttendance();
            AD1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();


            AD1.deleteEmpFromAttendance();
        }

        private void MetroButton5_Click_2(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();
            rl1.Emp_ID1 = int.Parse(txtDeleteEmpsFromLeave.Text.Trim().ToString());


            rl1.deleteEmpFromLeave();
        }

        private void TxtEmail1_Click(object sender, EventArgs e)
        {

        }

        private void TxtContactNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Phone Number");
                this.Show();
            }

        }

        private void TxtContactNo1_Click(object sender, EventArgs e)
        {

        }

        private void TxtContactNo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Phone Number");
                this.Show();
            }
        }

        private void TxtBsal3_Click(object sender, EventArgs e)
        {

        }

        private void TxtBsal3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Salary");
                this.Show();
            }
        }

        private void TxtOtHours_Click(object sender, EventArgs e)
        {

        }

        private void TxtOtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for OT Hours ");
                this.Show();
            }
        }

        private void TxtOtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for OT Rate");
                this.Show();
            }
        }

        private void TxtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for Bonus");
                this.Show();
            }
        }

        private void TxtAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for Allowance");
                this.Show();
            }
        }

        private void TxtDeduction_Click(object sender, EventArgs e)
        {

        }

        private void TxtDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for Deduction");
                this.Show();
            }
        }

        private void TxtContactNo2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RdMale1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RdFemale1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RdMale2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void RdFemale2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void RdMale1_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void RdFemale1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void RdMale1_CheckedChanged_2(object sender, EventArgs e)
        {
            ad1.Gender1 = "Male";
        }

        private void RdFemale1_CheckedChanged_2(object sender, EventArgs e)
        {
            ad1.Gender1 = "Female";
        }

        private void RdMale2_CheckedChanged_2(object sender, EventArgs e)
        {
        }

        private void RdFemale2_CheckedChanged_2(object sender, EventArgs e)
        {
        }

        private void MetroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void TxtDesig4_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel54_Click(object sender, EventArgs e)
        {

        }

        private void AddedEmps_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtFirstName2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtFirstName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtFirstName3_Click(object sender, EventArgs e)
        {

        }

        private void TxtFirstName3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtLastName3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtLastName1_Click(object sender, EventArgs e)
        {

        }

        private void TxtLastName1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtCityTown1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid input for the city/town !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtCityTown3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter a valid input for the city/town !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtDesig1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Designation should be a character value !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtDesig3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Designation should be a character value !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtBsal4_Click(object sender, EventArgs e)
        {

        }

        private void TxtBsal1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Salary");
                this.Show();
            }
        }

        private void TxtMonthAtt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (ch != 1 && ch != 2 && ch != 3 && ch != 4 && ch != 5 && ch != 6 && ch != 7 && ch != 8 && ch != 9 && ch != 10 && ch != 11 && ch != 12)
            {
                e.Handled = true;
                MessageBox.Show("Month should be 1 - 12");
                this.Show();
            }
        }

        private void BtnAddEmp_Click_1(object sender, EventArgs e)
        {
            try
            {
                ad1.Emp_ID1 = txtEmpID1.Text.Trim().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entered EMP ID already exists");
            }
            ad1.First_Name1 = txtFirstName1.Text.Trim().ToString();
            ad1.Last_Name1 = txtLastName1.Text.Trim().ToString();
            ad1.DOB1 = dateTimeDOB1.Value.ToString();
            ad1.NIC1 = txtNIC1.Text.Trim().ToString();
            ad1.Gender1 = cmbGender.Text.Trim().ToString();
            ad1.Contact_No1 = txtContactNo1.Text.Trim().ToString();
            ad1.Address_Line_11 = txtAdd11.Text.Trim().ToString();
            ad1.Address_Line_21 = txtAdd21.Text.Trim().ToString();
            ad1.City_Town1 = txtCityTown1.Text.Trim().ToString();
            ad1.Department1 = cmbboxDept1.Text.Trim().ToString();
            ad1.Designation1 = cmbDesignation1.Text.Trim().ToString();
            ad1.Date_Hired1 = dateTimeDhired1.Value.ToString();
            ad1.Basic_Salary1 = txtBsal1.Text.Trim().ToString();
            ad1.Email1 = txtEmail1.Text.Trim().ToString();


            if (ad1.NIC1.Length != 10)
            {
                MessageBox.Show("Invalid NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ad1.Contact_No1.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ad1.IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad1.addNewEmployee();
            }


            try
            {
                newlyAddedEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ! Check Your inputs. ");
            }

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                viewAllEmps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddEmployee ad2 = new AddEmployee();

            ad2.Emp_ID1 = txtEmpID3.Text.Trim().ToString();
            ad2.First_Name1 = txtFirstName3.Text.Trim().ToString();
            ad2.Last_Name1 = txtLastName3.Text.Trim().ToString();
            ad2.NIC1 = txtNIC3.Text.Trim().ToString();
            ad2.DOB1 = dateTimeDOB3.Value.ToString();
            ad2.Gender1 = cmbGender3.Text.Trim().ToString();
            ad2.Email1 = txtEmail1.Text.Trim().ToString();
            ad2.Contact_No1 = txtContactNo3.Text.Trim().ToString();
            ad2.Address_Line_11 = txtAdd13.Text.Trim().ToString();
            ad2.Address_Line_21 = txtAdd23.Text.Trim().ToString();
            ad2.City_Town1 = txtCityTown3.Text.Trim().ToString();
            ad2.Department1 = cmbboxDept3.Text.Trim().ToString();
            ad2.Designation1 = cmbDesignation3.Text.Trim().ToString();
            ad2.Date_Hired1 = dateTimeDhired3.Value.ToString();
            ad2.Basic_Salary1 = txtBsal3.Text.Trim().ToString();

            if (ad2.NIC1.Length != 10)
            {
                MessageBox.Show("Invalid NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ad2.Contact_No1.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ad2.IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad2.updateEmployee();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            AddEmployee ad3 = new AddEmployee();
            ad3.Emp_ID1 = txtSeEmpId4.Text.Trim().ToString();


            ad3.deleteEmployee();
        }

        private void Add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            AddSalary as1 = new AddSalary();

            as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
            as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
            as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
            as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
            as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());

            double tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;

            /*float tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;


            txtTotal.Text = (tot.ToString());*/

            txtTotal.Text = as1.gettot().ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();

            as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
            as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
            as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
            as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
            as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());

            double tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;



            try
            {
                if (as1.OT_Hours1 == null)
                {
                    MessageBox.Show("Enter OT hours as 0, Do not leave it NULL");
                }
                if (as1.OT_Rate1 == null)
                {
                    MessageBox.Show("Enter OT Rate as 0, Do not leave it NULL");
                }
                if (as1.Bonus1 == null)
                {
                    MessageBox.Show("Enter Bonus as 0, Do not leave it NULL");
                }


                as1.updateSalary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter an exsisting Emp ID !");
            }


            try
            {
                viewSalaryDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();
            as1.Emp_ID1 = txtDeleteEmpRecords.Text.Trim().ToString();

            try
            {
                as1.deleteEmpFromSalary();
            }
            catch
            {
                MessageBox.Show("Enter an exsisting Emp ID !");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                viewAllSalaryRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();

            rl1.LeaveID1 = int.Parse(txtLeaveID.Text.Trim().ToString());
            rl1.Emp_ID1 = int.Parse(txtEmpIDLE.Text.Trim().ToString());
            rl1.LeaveDate1 = txtLeaveDateLE.Value.ToString();
            rl1.Category1 = cmbLeaveCategoryLE.Text.Trim().ToString();
            rl1.LeaveStatus1 = "Pending";

            try
            {
                rl1.RequestNewLeave();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Enter an exsisting EMP ID !");
            }

            try
            {
                newlyAddedLeaveRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                viewallLeaves();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();
            rl1.Emp_ID1 = int.Parse(txtDeleteEmpsFromLeave.Text.Trim().ToString());

            try
            {
                rl1.deleteEmpFromLeave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter an exsisting EMP ID !");
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();
            rl1.LeaveID1 = int.Parse(txtLeaveIDup.Text.Trim().ToString());
            rl1.LeaveStatus1 = cmbRes.Text.Trim().ToString();

            try
            {
                rl1.UpdateLeave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter an exsisting EMP ID !");
            }


        }

        private void Button17_Click(object sender, EventArgs e)
        {
            try
            {
                viewAttendanceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            AddAttendance aa1 = new AddAttendance();

            aa1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();


            aa1.Day_16 = 0;
            aa1.Day_21 = 0;
            aa1.Day_31 = 0;
            aa1.Day_41 = 0;
            aa1.Day_51 = 0;
            aa1.Day_61 = 0;
            aa1.Day_71 = 0;
            aa1.Day_81 = 0;
            aa1.Day_91 = 0;
            aa1.Day_101 = 0;
            aa1.Day_111 = 0;
            aa1.Day_121 = 0;
            aa1.Day_131 = 0;
            aa1.Day_141 = 0;
            aa1.Day_151 = 0;
            aa1.Total_Attendance1 = 0;

            try
            {
                aa1.addAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a current Employee !");
            }

            try
            {
                newlyAddedEmptoAtt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {

            AddAttendance AD1 = new AddAttendance();
            AD1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();

            try
            {
                AD1.deleteEmpFromAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a current Employee !");
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtEmail2_Validating(object sender, CancelEventArgs e)
        {
        }

        private void TxtLeaveIDup_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MetroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel80_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click_2(object sender, EventArgs e)
        {

        }

        private void MetroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel6_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel15_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel10_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel13_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void TxtBsal1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddEmp_Click_2(object sender, EventArgs e)
        {
            /*try
            {
                ad1.Emp_ID1 = txtEmpID1.Text.Trim().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entered EMP ID already exists");
            }*/
            ad1.First_Name1 = txtFirstName1.Text.Trim().ToString();
            ad1.Last_Name1 = txtLastName1.Text.Trim().ToString();
            ad1.DOB1 = dateTimeDOB1.Value.ToString();
            ad1.NIC1 = txtNIC1.Text.Trim().ToString();
            ad1.Gender1 = cmbGender.Text.Trim().ToString();
            ad1.Contact_No1 = txtContactNo1.Text.Trim().ToString();
            ad1.Address_Line_11 = txtAdd11.Text.Trim().ToString();
            ad1.Address_Line_21 = txtAdd21.Text.Trim().ToString();
            ad1.City_Town1 = txtCityTown1.Text.Trim().ToString();
            ad1.Department1 = cmbboxDept1.Text.Trim().ToString();
            ad1.Designation1 = cmbDesignation1.Text.Trim().ToString();
            ad1.Date_Hired1 = dateTimeDhired1.Value.ToString();
            ad1.Basic_Salary1 = txtBsal1.Text.Trim().ToString();
            ad1.Email1 = txtEmail1.Text.Trim().ToString();

            if (ad1.Last_Name1 == "")
            {
                MessageBox.Show("Last Name can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.First_Name1 == "")
            {
                MessageBox.Show("First Name can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Designation1 == "")
            {
                MessageBox.Show("Designation can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Date_Hired1 == null)
            {
                MessageBox.Show("Department can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Department1 == "")
            {
                MessageBox.Show("Department can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Address_Line_21 == "")
            {
                MessageBox.Show("Address Line 2 can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Address_Line_11 == "")
            {
                MessageBox.Show("Address Line 1 can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.DOB1 == null)
            {
                MessageBox.Show("DOB can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((ad1.NIC1.Length != 10) && !Regex.Match(ad1.NIC1, "/^[0-9]{9}[vVxX]$/").Success)
            {
                MessageBox.Show("Invalid NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.Contact_No1.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad1.IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad1.addNewEmployee();

            }


            try
            {
                newlyAddedEmployee();
                showNextEmpId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ! Check Your inputs. ");
            }

            


        }


        private void SEARCH_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                viewAllEmps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            AddEmployee ad2 = new AddEmployee();

            ad2.Emp_ID1 = txtEmpID3.Text.Trim().ToString();
            ad2.First_Name1 = txtFirstName3.Text.Trim().ToString();
            ad2.Last_Name1 = txtLastName3.Text.Trim().ToString();
            ad2.NIC1 = txtNIC3.Text.Trim().ToString();
            ad2.DOB1 = dateTimeDOB3.Value.ToString();
            ad2.Gender1 = cmbGender3.Text.Trim().ToString();
            ad2.Email1 = txtEmail3.Text.Trim().ToString();
            ad2.Contact_No1 = txtContactNo3.Text.Trim().ToString();
            ad2.Address_Line_11 = txtAdd13.Text.Trim().ToString();
            ad2.Address_Line_21 = txtAdd23.Text.Trim().ToString();
            ad2.City_Town1 = txtCityTown3.Text.Trim().ToString();
            ad2.Department1 = cmbboxDept3.Text.Trim().ToString();
            ad2.Designation1 = cmbDesignation3.Text.Trim().ToString();
            ad2.Date_Hired1 = dateTimeDhired3.Value.ToString();
            ad2.Basic_Salary1 = txtBsal3.Text.Trim().ToString();


            if (ad2.Last_Name1 == "")
            {
                MessageBox.Show("Last Name can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.First_Name1 == "")
            {
                MessageBox.Show("First Name can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Designation1 == "")
            {
                MessageBox.Show("Designation can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Date_Hired1 == null)
            {
                MessageBox.Show("Department can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Department1 == null)
            {
                MessageBox.Show("Department can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Address_Line_21 == "")
            {
                MessageBox.Show("Address Line 2 can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Address_Line_11 == "")
            {
                MessageBox.Show("Address Line 1 can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.DOB1 == null)
            {
                MessageBox.Show("DOB can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((ad2.NIC1.Length != 10) && !Regex.Match(ad2.NIC1, "/^[0-9]{9}[vVxX]$/").Success)
            {
                MessageBox.Show("Invalid NIC Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.Contact_No1.Length != 10)
            {
                MessageBox.Show("Invalid Phone Number !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ad2.IsEmailValid() == false)
            {
                MessageBox.Show("Invalid Email Address !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad2.updateEmployee();
            }

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            AddEmployee ad3 = new AddEmployee();
            ad3.Emp_ID1 = txtSeEmpId4.Text.Trim().ToString();


            ad3.deleteEmployee();
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();

            as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            try
            {
                as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
                as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
                as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
                as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
                as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the Values First.");
            }





            txtTotal.Text = as1.gettot().ToString();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();

            /* as1.SalaryID1 = txtSalaryID.Text.Trim().ToString();*/
            as1.Emp_ID1 = txtEmpIDsal.Text.Trim().ToString();
            try
            {
                as1.OT_Hours1 = float.Parse(txtOtHours.Text.Trim().ToString());
                as1.OT_Rate1 = float.Parse(txtOtRate.Text.Trim().ToString());
                as1.Bonus1 = float.Parse(txtBonus.Text.Trim().ToString());
                as1.Allowance1 = float.Parse(txtAllowance.Text.Trim().ToString());
                as1.Deduction1 = float.Parse(txtDeduction.Text.Trim().ToString());
                as1.Month_1 =int.Parse(nupSalMonth.Text.Trim().ToString());
                as1.Year_1 = int.Parse(cmbSalYear.Text.Trim().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("salary is calculated for given values.");
            }

            double tot = ((as1.OT_Hours1 * as1.OT_Rate1) + as1.Bonus1 + as1.Allowance1 - as1.Deduction1);
            as1.Total1 = tot;


/*
            try
            {
                if ((as1.OT_Hours1).ToString() == "")
                {
                    MessageBox.Show("Enter OT hours as 0, Do not leave it NULL");
                }
                else if ((as1.OT_Rate1).ToString() == "")
                {
                    MessageBox.Show("Enter OT Rate as 0, Do not leave it NULL");
                }
                else if ((as1.Deduction1).ToString() == "")
                {
                    MessageBox.Show("Enter Deduction as 0, Do not leave it NULL");
                }
                else if ((as1.Allowance1).ToString() == "")
                {
                    MessageBox.Show("Enter Allowance as 0, Do not leave it NULL");
                }
                else if ((as1.Bonus1).ToString() == "")
                {
                    MessageBox.Show("Enter Bonus as 0, Do not leave it NULL");
                }*/
                as1.updateSalary();



           /* }
            catch (Exception ex)
            {
                MessageBox.Show("Enter an exsisting Emp ID !");
            }
*/

            try
            {
                viewSalaryDetails();
                showNextSalId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }


           


        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            AddSalary as1 = new AddSalary();
            as1.Emp_ID1 = txtDeleteEmpRecords.Text.Trim().ToString();

            try
            {
                as1.deleteEmpFromSalary();
            }
            catch
            {
                MessageBox.Show("Enter an exsisting Emp ID !");
            }
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                viewAllSalaryRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();

            /* rl1.LeaveID1 = txtLeaveID.Text.Trim().ToString();*/
            rl1.Emp_ID1 = int.Parse(txtEmpIDLE.Text.Trim().ToString());
            rl1.LeaveDate1 = txtLeaveDateLE.Value.ToString();
            rl1.Category1 = cmbLeaveCategoryLE.Text.Trim().ToString();
            rl1.LeaveStatus1 = "Pending";




            try
            {

                if (rl1.Emp_ID1 == null)
                {
                    MessageBox.Show("Emp ID can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rl1.LeaveDate1 == null)
                {
                    MessageBox.Show("Leave Date can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rl1.Category1 == null)
                {
                    MessageBox.Show("Category can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                rl1.RequestNewLeave();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Enter an exsisting EMP ID !");
            }

            try
            {
                newlyAddedLeaveRequest();
                showNextLeaveId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }

           
        }

        private void Button13_Click_1(object sender, EventArgs e)
        {

            RequestLeave rl1 = new RequestLeave();
            rl1.LeaveID1 = int.Parse(txtLeaveIDup.Text.Trim().ToString());
            rl1.LeaveStatus1 = cmbRes.Text.Trim().ToString();


            /*if (rl1.LeaveID1 == null)
            {
                MessageBox.Show("Leave ID can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            if (rl1.LeaveStatus1 == null)
            {
                MessageBox.Show("Leave Status can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rl1.UpdateLeave();




        }

        private void Button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                viewallLeaves();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button11_Click_1(object sender, EventArgs e)
        {
            RequestLeave rl1 = new RequestLeave();
            rl1.Emp_ID1 = int.Parse(txtDeleteEmpsFromLeave.Text.Trim().ToString());

            try
            {
                if (rl1.Emp_ID1 == null)
                {
                    MessageBox.Show("Emp ID can not be null !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rl1.deleteEmpFromLeave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter an exsisting EMP ID !");
            }
        }

        private void Button17_Click_1(object sender, EventArgs e)
        {
            try
            {
                viewAttendanceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        AddAttendance aa1 = new AddAttendance();
        private void Button15_Click_1(object sender, EventArgs e)
        {

            aa1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();

            try
            {
                aa1.deleteEmpFromAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a current Employee !");
            }

        }

        private void Button16_Click_1(object sender, EventArgs e)
        {


            aa1.Emp_ID1 = txtEmpIDAtt.Text.Trim().ToString();


            aa1.Day_16 = 0;
            aa1.Day_21 = 0;
            aa1.Day_31 = 0;
            aa1.Day_41 = 0;
            aa1.Day_51 = 0;
            aa1.Day_61 = 0;
            aa1.Day_71 = 0;
            aa1.Day_81 = 0;
            aa1.Day_91 = 0;
            aa1.Day_101 = 0;
            aa1.Day_111 = 0;
            aa1.Day_121 = 0;
            aa1.Day_131 = 0;
            aa1.Day_141 = 0;
            aa1.Day_151 = 0;
            aa1.Total_Attendance1 = 0;

            try
            {

                aa1.addAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a current Employee !");
            }

            try
            {
                newlyAddedEmptoAtt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void MetroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Saldet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdd22_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MetroLabel33_Click(object sender, EventArgs e)
        {

        }

        private void TxtSeEmpId3_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel34_Click(object sender, EventArgs e)
        {

        }

        private void CmbGender3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroLabel48_Click(object sender, EventArgs e)
        {

        }

        private void TxtBsal3_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel39_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Delemp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBsal4_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroLabel56_Click(object sender, EventArgs e)
        {

        }

        private void TxtContactNo4_Click(object sender, EventArgs e)
        {

        }

        private void TxtDeleteEmpsFromLeave_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel79_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtEmpToUp_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddedEmps_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtEmpID2.Text = addedEmps.CurrentRow.Cells[0].Value.ToString();
                txtFirstName2.Text = addedEmps.CurrentRow.Cells[1].Value.ToString();
                txtLastName2.Text = addedEmps.CurrentRow.Cells[2].Value.ToString();
                txtNIC2.Text = addedEmps.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB2.Text = addedEmps.CurrentRow.Cells[4].Value.ToString();
                cmbGender2.Text = addedEmps.CurrentRow.Cells[5].Value.ToString();
                txtEmail2.Text = addedEmps.CurrentRow.Cells[6].Value.ToString();
                txtContactNo2.Text = addedEmps.CurrentRow.Cells[7].Value.ToString();
                txtAdd12.Text = addedEmps.CurrentRow.Cells[8].Value.ToString();
                txtAdd22.Text = addedEmps.CurrentRow.Cells[9].Value.ToString();
                txtCityTown2.Text = addedEmps.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept2.Text = addedEmps.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation2.Text = addedEmps.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired2.Text = addedEmps.CurrentRow.Cells[13].Value.ToString();
                txtBsal2.Text = addedEmps.CurrentRow.Cells[14].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }

        }

        private void Upsearch_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmpID3.Text = upsearch.CurrentRow.Cells[0].Value.ToString();
                txtFirstName3.Text = upsearch.CurrentRow.Cells[1].Value.ToString();
                txtLastName3.Text = upsearch.CurrentRow.Cells[2].Value.ToString();
                txtNIC3.Text = upsearch.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB3.Text = upsearch.CurrentRow.Cells[4].Value.ToString();
                cmbGender3.Text = upsearch.CurrentRow.Cells[5].Value.ToString();
                //rdFemale3.Text = upsearch.CurrentRow.Cells[5].Value.ToString();
                txtEmail3.Text = upsearch.CurrentRow.Cells[6].Value.ToString();
                txtContactNo3.Text = upsearch.CurrentRow.Cells[7].Value.ToString();
                txtAdd13.Text = upsearch.CurrentRow.Cells[8].Value.ToString();
                txtAdd23.Text = upsearch.CurrentRow.Cells[9].Value.ToString();
                txtCityTown3.Text = upsearch.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept3.Text = upsearch.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation3.Text = upsearch.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired3.Text = upsearch.CurrentRow.Cells[13].Value.ToString();
                txtBsal3.Text = upsearch.CurrentRow.Cells[14].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }
        }

        private void Delemp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmpID4.Text = delemp.CurrentRow.Cells[0].Value.ToString();
                txtFirstName4.Text = delemp.CurrentRow.Cells[1].Value.ToString();
                txtLastName4.Text = delemp.CurrentRow.Cells[2].Value.ToString();
                txtNIC4.Text = delemp.CurrentRow.Cells[3].Value.ToString();
                dateTimeDOB4.Text = delemp.CurrentRow.Cells[4].Value.ToString();
                cmbGender4.Text = delemp.CurrentRow.Cells[5].Value.ToString();
                txtEmail4.Text = delemp.CurrentRow.Cells[6].Value.ToString();
                txtContactNo4.Text = delemp.CurrentRow.Cells[7].Value.ToString();
                txtAdd14.Text = delemp.CurrentRow.Cells[8].Value.ToString();
                txtAdd24.Text = delemp.CurrentRow.Cells[9].Value.ToString();
                txtCityTown4.Text = delemp.CurrentRow.Cells[10].Value.ToString();
                cmbboxDept4.Text = delemp.CurrentRow.Cells[11].Value.ToString();
                cmbDesignation4.Text = delemp.CurrentRow.Cells[12].Value.ToString();
                dateTimeDhired4.Text = delemp.CurrentRow.Cells[13].Value.ToString();
                txtBsal4.Text = delemp.CurrentRow.Cells[14].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured !");
            }
        }

        private void TxtFirstName4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtFirstName3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }

        }

        private void TxtFirstName1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtLastName1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtNIC1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtContactNo1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Phone Number");
                this.Show();
            }
        }

        private void TxtBsal1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Salary");
                this.Show();
            }
        }

        private void TxtLastName3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Name can only contain characters !", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtContactNo3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Phone Number");
                this.Show();
            }
        }

        private void TxtBsal3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Salary");
                this.Show();
            }
        }

        private void TxtOtHours_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtOtHours_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for OT Hours ");
                this.Show();
            }
        }

        private void TxtOtRate_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for OT Rate ");
                this.Show();
            }
        }

        private void TxtBonus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for OT Bonus ");
                this.Show();
            }
        }

        private void TxtAllowance_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for Allowance ");
                this.Show();
            }
        }

        private void TxtDeduction_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;



            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid input for Deduction ");
                this.Show();
            }
        }

        private void TxtLeaveIDup_Click_1(object sender, EventArgs e)
        {

        }

        private void Button14_Click_1(object sender, EventArgs e)
        {
            AddAttendance aa1 = new AddAttendance();


            int month = int.Parse(nupMonthAttendance.Value.ToString());
            int year = int.Parse(cmbYearAttendance.Text.ToString());
            int day = int.Parse(nupDateAttendance.Value.ToString());

            int EmpID = int.Parse(txtEmpToUp.Text.ToString());

            aa1.updateEmpAttendance(month, year, day, EmpID);

        }

        private void TxtOtRate_Click(object sender, EventArgs e)
        {

        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {


        }

        private void MetroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void RequestLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NupDateAttendance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NupRecordAttendace_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbYearAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            txtFirstName1.Text = "Chamika";
            txtLastName1.Text = "Perera";
            dateTimeDOB1.Value = DateTime.Today;
            txtNIC1.Text = "962061540v";
            cmbGender.SelectedIndex = 0;
            txtContactNo1.Text = "0717291782";
            txtAdd11.Text = "Kurunegala Road";
            txtAdd21.Text = "Old Town";
            txtCityTown1.Text = "Madampe";
            cmbboxDept1.Text = "Finance Department";
            cmbDesignation1.Text = "Finance Manager";
            dateTimeDhired1.Value = DateTime.Today;
            txtBsal1.Text = "25000";
            txtEmail1.Text = "chamika@gmail.com";
        }

        private void UpEmpDEMO_Click(object sender, EventArgs e)
        {
            txtFirstName3.Text = "Dinuka ";
            txtLastName3.Text = "Shameera";
            dateTimeDOB3.Value = DateTime.Today;
            txtNIC3.Text = "972061540v";
            cmbGender.SelectedIndex = 0;
            txtContactNo3.Text = "0778331022";
            txtAdd13.Text = "Lane 1";
            txtAdd23.Text = "Colombo Road ";
            txtCityTown3.Text = "Ja-Ela";
            cmbboxDept3.Text = "Spa Department";
            cmbDesignation3.Text = "Spa Manager";
            dateTimeDhired3.Value = DateTime.Today;
            txtBsal3.Text = "35000";
            txtEmail3.Text = "dinuka@gmail.com";

        }

        private void SalaryDEMO_Click(object sender, EventArgs e)
        {
            txtEmpIDsal.Text = "25";
            txtOtHours.Text = "5";
            txtOtRate.Text = "500";
            txtBonus.Text = "650";
            txtAllowance.Text = "450";
            txtDeduction.Text = "550";
            nupSalMonth.Value = 1;
            cmbSalYear.Text = "2019";
        }

        private void RequestLeaveDEMO_Click(object sender, EventArgs e)
        {
            txtEmpIDLE.Text = "25";
            txtLeaveDateLE.Value = DateTime.Today;
            cmbLeaveCategoryLE.Text = "Personal";
            
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
           txtEmpIDAtt.Text = "25";
           nupMonthAttendance.Value = 1;
           cmbYearAttendance.Text = "2019";
           nupDateAttendance.Value = 1;
           txtEmpToUp.Text = "1";
           nupRecordAttendace.Value = 1;
        }

        private void ButEMPRESET_Click(object sender, EventArgs e)
        {
            txtFirstName1.Text = "";
            txtLastName1.Text = "";
            dateTimeDOB1.Value = DateTime.Today;
            txtNIC1.Text = "";
            cmbGender.SelectedIndex = 0;
            txtContactNo1.Text = "";
            txtAdd11.Text = "";
            txtAdd21.Text = "";
            txtCityTown1.Text = "";
            cmbboxDept1.Text = "";
            cmbDesignation1.Text = "";
            dateTimeDhired1.Value = DateTime.Today;
            txtBsal1.Text = "";
            txtEmail1.Text = "";
        }

        private void BtnSalRESET_Click(object sender, EventArgs e)
        {
            txtEmpIDsal.Text = "";
            txtOtHours.Text = "";
            txtOtRate.Text = "";
            txtBonus.Text = "";
            txtAllowance.Text = "";
            txtDeduction.Text = "";
        }

        private void BtnLeaveRESET_Click(object sender, EventArgs e)
        {
            txtEmpIDLE.Text = "";
            txtLeaveDateLE.Value = DateTime.Today;
            cmbLeaveCategoryLE.Text = "";
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            txtEmpIDAtt.Text = "";
            nupMonthAttendance.Value = 1;
            cmbYearAttendance.Text = "";
            nupDateAttendance.Value = 1;
            txtEmpToUp.Text = "";
            nupRecordAttendace.Value = 0;
        }

        private void CmbDesignation4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDesignation1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveSalReport_Click(object sender, EventArgs e)
        {


        }

        private void ReportEMS_Click(object sender, EventArgs e)
        {
            salaryReportForm salaryReportForm = new salaryReportForm();
            salaryReportForm.Show();
        }
    }
}
