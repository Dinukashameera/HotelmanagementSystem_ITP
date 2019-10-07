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
    public partial class SpaCompletedAppointmentsReportForm : Form
    {
        public SpaCompletedAppointmentsReportForm()
        {
            InitializeComponent();
        }

        private void SpaCompletedAppointmentsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SpaCompletedAppointmentDetailsReportDataSet.getSpaCompletedAppointmentDetailsReport' table. You can move, or remove it, as needed.
            this.getSpaCompletedAppointmentDetailsReportTableAdapter.Fill(this.SpaCompletedAppointmentDetailsReportDataSet.getSpaCompletedAppointmentDetailsReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
