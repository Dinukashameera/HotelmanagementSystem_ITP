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
    public partial class salaryReportForm : Form
    {
        public salaryReportForm()
        {
            InitializeComponent();
        }

        private void SalaryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salaryReportDataset.Salary' table. You can move, or remove it, as needed.
            this.SalaryTableAdapter.Fill(this.salaryReportDataset.Salary);

            this.reportViewer1.RefreshReport();
        }
    }
}
