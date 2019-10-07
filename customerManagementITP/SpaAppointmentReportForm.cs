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
    public partial class SpaAppointmentReportForm : Form
    {
        public SpaAppointmentReportForm()
        {
            InitializeComponent();
        }

        private void SpaAppointmentReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SpaAppointmentDetailsReportDataSet.getSpaAppointmentDetailsReport' table. You can move, or remove it, as needed.
            this.getSpaAppointmentDetailsReportTableAdapter.Fill(this.SpaAppointmentDetailsReportDataSet.getSpaAppointmentDetailsReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
