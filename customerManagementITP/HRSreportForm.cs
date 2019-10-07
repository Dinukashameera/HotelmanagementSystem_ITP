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
    public partial class HRSreportForm : Form
    {
        String start, end;

        public HRSreportForm(String start, String end)
        {
            InitializeComponent();
            this.start = start;
            this.end = end;
        }

        private void HRSreportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HRSreportDataSet.HRS_customer_completed' table. You can move, or remove it, as needed.
            this.HRS_customer_completedTableAdapter.Fill(this.HRSreportDataSet.HRS_customer_completed, start, end);

            this.reportViewer1.RefreshReport();
        }
    }
}
