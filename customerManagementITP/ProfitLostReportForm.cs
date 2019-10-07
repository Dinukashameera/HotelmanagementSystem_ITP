using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerManagementITP
{
    public partial class ProfitLostReportForm : Form
    {

        String Dept, Date;
        public ProfitLostReportForm(String date, String dept)
        {
            InitializeComponent();
            this.Dept = dept;
            this.Date = date;
        }

        private void ProfitLostReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProfitLostDataSet.Profit' table. You can move, or remove it, as needed.
            this.ProfitTableAdapter.Fill(this.ProfitLostDataSet.Profit,Date,Dept);

            this.reportViewer1.RefreshReport();
        }
    }
}
