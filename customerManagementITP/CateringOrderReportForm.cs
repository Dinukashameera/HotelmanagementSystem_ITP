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
    public partial class CateringOrderReportForm : Form
    {
        public CateringOrderReportForm()
        {
            InitializeComponent();
        }

        private void CateringOrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CateringDataset.FinalOrder' table. You can move, or remove it, as needed.
            this.FinalOrderTableAdapter.Fill(this.CateringDataset.FinalOrder);

            this.reportViewer1.RefreshReport();
        }
    }
}
