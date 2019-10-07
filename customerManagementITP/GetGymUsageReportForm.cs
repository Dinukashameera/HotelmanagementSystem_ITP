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
    public partial class GetGymUsageReportForm : Form
    {
        public GetGymUsageReportForm()
        {
            InitializeComponent();
        }

        private void GetGymUsageReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GetGymUsageReportDataset.GetGymUsageReport' table. You can move, or remove it, as needed.
            this.GetGymUsageReportTableAdapter.Fill(this.GetGymUsageReportDataset.GetGymUsageReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
