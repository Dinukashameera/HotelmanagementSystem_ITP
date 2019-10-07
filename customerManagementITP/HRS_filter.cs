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
using customerManagementITP;

namespace Hall_Reservation
{
    
    public partial class HRS_filter : MetroFramework.Forms.MetroForm
    {
        private SqlConnection sqlcon = DBConnection.getConnection();
        public HRS_filter()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet2.hrs_cus_hall_filter' table. You can move, or remove it, as needed.
           // this.hrs_cus_hall_filterTableAdapter.Fill(this.blue_Lotus_HotelDataSet2.hrs_cus_hall_filter);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.HRS_BLH_customer' table. You can move, or remove it, as needed.
           // this.hRS_BLH_customerTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.HRS_BLH_customer);

        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }

        private void BtnMakeReserve_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }
        //form5 - filtering customer details by using reservation dates
        public void filterCustomerDataGrid() {

            DBConnection.openDBConnection();
            SqlDataAdapter sqlda = new SqlDataAdapter("FilterDate_cus", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlda.SelectCommand.Parameters.AddWithValue("@dateStart", dateTimestart.Value.ToString());
            sqlda.SelectCommand.Parameters.AddWithValue("@dateEnd", dateTimeend.Value.ToString());

            DataTable dtbl = new DataTable();

            sqlda.Fill(dtbl);
            dgvFilterDate.DataSource = dtbl;

            DBConnection.closeDBConnection();
        }
        private void BtnFilterSearch_Click(object sender, EventArgs e)
        {
            filterCustomerDataGrid();
        }

        private void MetroLink2_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }
    }
}
