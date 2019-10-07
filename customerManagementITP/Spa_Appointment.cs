using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerManagementITP;

namespace SPA
{
    class Spa_Appointment
    {
        private String appointmentnum;
        private int customerId;
        private String customerName;
        private String customerContactNumber;
        private String roomNumber;
        private bool needHeadMassage;
        private int NumOfCumtomheadMassage;
        private bool needFootMassage;
        private int NumOfCumtomFootMassage;
        private bool needFullBodyMassage;
        private int NumOfCumtomFullBodyMassage;
        private bool needFacial;
        private int NumOfCumtomFacial;
        private int totalnumOfCustomer;
        private String appointmentDate;
        private String nationality;
        private float total;
        private float discount;
        private String appointmentSearchText;

        private SqlConnection sqlcon = DBConnection.getConnection();

        public string AppointmentNum { get => appointmentnum; set => appointmentnum = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerContactNumber { get => customerContactNumber; set => customerContactNumber = value; }
        public bool NeedHeadMassage { get => needHeadMassage; set => needHeadMassage = value; }
        public int NumOfCumtomheadMassage_ { get => NumOfCumtomheadMassage; set => NumOfCumtomheadMassage = value; }
        public bool NeedFootMassage { get => needFootMassage; set => needFootMassage = value; }
        public int NumOfCumtomFootMassage_ { get => NumOfCumtomFootMassage; set => NumOfCumtomFootMassage = value; }
        public bool NeedFullBodyMassage { get => needFullBodyMassage; set => needFullBodyMassage = value; }
        public int NumOfCumtomFullBodyMassage_ { get => NumOfCumtomFullBodyMassage; set => NumOfCumtomFullBodyMassage = value; }
        public bool NeedFacial { get => needFacial; set => needFacial = value; }
        public int NumOfCumtomFacial_ { get => NumOfCumtomFacial; set => NumOfCumtomFacial = value; }
        public int TotalnumOfCustomer { get => totalnumOfCustomer; set => totalnumOfCustomer = value; }
        public string AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public float Total { get => total; set => total = value; }
        public float Discount { get => discount; set => discount = value; }
        public string AppointmentSearchText { get => appointmentSearchText; set => appointmentSearchText = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }

        public void saveAppointment() {

            DBConnection.openDBConnection();

            appointment_Charges(); //calc charges

            SqlCommand sqlCommand = new SqlCommand("spa_AddAppointment", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@roomNum", roomNumber);
            sqlCommand.Parameters.AddWithValue("@customer_Id", customerId);
            sqlCommand.Parameters.AddWithValue("@cumtomerName", customerName);          
            sqlCommand.Parameters.AddWithValue("@customerContactNum", customerContactNumber);
            sqlCommand.Parameters.AddWithValue("@needHeadMassage", needHeadMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersHeadMassage", NumOfCumtomheadMassage);
            sqlCommand.Parameters.AddWithValue("@needFootMassage", needFootMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFootMassage", NumOfCumtomFootMassage);
            sqlCommand.Parameters.AddWithValue("@needFullBodyMassage", needFullBodyMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFullBodyMassage", NumOfCumtomFullBodyMassage);
            sqlCommand.Parameters.AddWithValue("@needFacial", needFacial);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFacial", NumOfCumtomFacial);
            sqlCommand.Parameters.AddWithValue("@numOfCustomers", totalnumOfCustomer);
            sqlCommand.Parameters.AddWithValue("@appoinmentDate_", appointmentDate);
            sqlCommand.Parameters.AddWithValue("@nationality", nationality);
            sqlCommand.Parameters.AddWithValue("@total", total);
            sqlCommand.Parameters.AddWithValue("@discount", discount);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public DataTable AppointmentDataView()
        {
            DBConnection.openDBConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("spa_ViewSearchAppointment", sqlcon);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@searchText ", appointmentSearchText);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DBConnection.closeDBConnection();
            return dataTable;
        }
        public void AppointmentUpdate(string appointmentId)
        {
            DBConnection.openDBConnection();

            appointment_Charges(); //calc charges


            SqlCommand sqlCommand = new SqlCommand("spa_EditAppointment", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@appointmentNum", appointmentId);
            sqlCommand.Parameters.AddWithValue("@roomNum", roomNumber);
            sqlCommand.Parameters.AddWithValue("@customer_Id", customerId);
            sqlCommand.Parameters.AddWithValue("@cumtomerName", customerName);   
            sqlCommand.Parameters.AddWithValue("@customerContactNum", customerContactNumber);
            sqlCommand.Parameters.AddWithValue("@needHeadMassage", needHeadMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersHeadMassage", NumOfCumtomheadMassage);
            sqlCommand.Parameters.AddWithValue("@needFootMassage", needFootMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFootMassage", NumOfCumtomFootMassage);
            sqlCommand.Parameters.AddWithValue("@needFullBodyMassage", needFullBodyMassage);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFullBodyMassage", NumOfCumtomFullBodyMassage);
            sqlCommand.Parameters.AddWithValue("@needFacial", needFacial);
            sqlCommand.Parameters.AddWithValue("@numOfCustomersFacial", NumOfCumtomFacial);
            sqlCommand.Parameters.AddWithValue("@numOfCustomers", totalnumOfCustomer);
            sqlCommand.Parameters.AddWithValue("@appoinmentDate_", appointmentDate);
            sqlCommand.Parameters.AddWithValue("@nationality", nationality);
            sqlCommand.Parameters.AddWithValue("@total", total);
            sqlCommand.Parameters.AddWithValue("@discount", discount);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public void Spa_AppointmentDelete(string appointmentId)
        {
            DBConnection.openDBConnection();
            SqlCommand sqlCommand = new SqlCommand("spa_DeleteAppointment", sqlcon);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@appointmentNum", appointmentId);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBConnection.closeDBConnection();
        }

        public void appointment_Charges() {

                float chargeHeadMsg = 1000;
                float chargeFootMsg = 1200;
                float chargeBodyMsg = 3000;
                float chargeFacial = 2000;

                if (needFootMassage == false && needHeadMassage == false && needFullBodyMassage == false && needFacial == true)
                {
                    total = chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == false && needHeadMassage == false && needFullBodyMassage == true && needFacial == false)
                {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage;
                }
                else if (needFootMassage == false && needHeadMassage == false && needFullBodyMassage == true && needFacial == true)
                {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == true && needHeadMassage == false && needFullBodyMassage == false && needFacial == false)
                {
                    total = chargeFootMsg * NumOfCumtomFootMassage;
                }
                else if (needFootMassage == true && needHeadMassage == false && needFullBodyMassage == false && needFacial == true)
            {
                    total = chargeFootMsg * NumOfCumtomFootMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == true && needHeadMassage == false && needFullBodyMassage == true && needFacial == false)
            {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeFootMsg * NumOfCumtomFootMassage;
                }
                else if (needFootMassage == true && needHeadMassage == false && needFullBodyMassage == true && needFacial == true)
            {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeFootMsg * NumOfCumtomFootMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == false && needHeadMassage == true && needFullBodyMassage == false && needFacial == false)
            {
                    total = chargeHeadMsg * NumOfCumtomheadMassage;
                }
                else if (needFootMassage == false && needHeadMassage == true && needFullBodyMassage == false && needFacial == true)
            {
                    total = chargeHeadMsg * NumOfCumtomheadMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == false && needHeadMassage == true && needFullBodyMassage == true && needFacial == false)
            {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeHeadMsg * NumOfCumtomheadMassage;
                }
                else if (needFullBodyMassage == true && needHeadMassage == true && needFacial == true && needFootMassage == false)
                {
                    total = chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeHeadMsg * NumOfCumtomheadMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == true && needHeadMassage == true && needFullBodyMassage == false && needFacial == false)
                {
                    total = chargeFootMsg * NumOfCumtomFootMassage + chargeHeadMsg * NumOfCumtomheadMassage;
                }
                else if (needFootMassage == true && needHeadMassage == true && needFacial == true && needFullBodyMassage == false)
                {
                    total = chargeFootMsg * NumOfCumtomFootMassage + chargeHeadMsg * NumOfCumtomheadMassage + chargeFacial * NumOfCumtomFacial;
                }
                else if (needFootMassage == true && needHeadMassage == true && needFullBodyMassage == true && needFacial == false)
                {
                    total = chargeFootMsg * NumOfCumtomFootMassage + chargeHeadMsg * NumOfCumtomheadMassage + chargeBodyMsg * NumOfCumtomFullBodyMassage;
                }
                else if (needFootMassage == true && needHeadMassage == true && needFullBodyMassage == true && needFacial == true)
                {
                    total = chargeFootMsg * NumOfCumtomFootMassage + chargeHeadMsg * NumOfCumtomheadMassage + chargeBodyMsg * NumOfCumtomFullBodyMassage + chargeFacial * NumOfCumtomFacial;
                }

                if (totalnumOfCustomer >= 5)
                {
                    discount = total * 0.05f;
                }
                else if (totalnumOfCustomer < 5)
                {
                    discount = 0;
                }
        }
    }
}
