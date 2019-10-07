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
    public partial class ExpenditureReportForm : Form
    {
        String Date;
        public ExpenditureReportForm(String date)
        {
            InitializeComponent();
            this.Date = date;
        }

        private void ExpenditureReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ExpenditureDataSet.Expenditure_table' table. You can move, or remove it, as needed.
            this.Expenditure_tableTableAdapter.Fill(this.ExpenditureDataSet.Expenditure_table,Date);

            this.reportViewer1.RefreshReport();
        }
    }
}
