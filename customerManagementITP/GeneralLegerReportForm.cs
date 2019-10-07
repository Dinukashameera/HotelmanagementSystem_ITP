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
    public partial class GeneralLegerReportForm : Form
    {
        String Date, Dept;
        public GeneralLegerReportForm(String date,String dept)
        {
            InitializeComponent();
            this.Date = date;
            this.Dept = dept;
        }

        private void GeneralLegerReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GeneralLegerDataSet.IncomeExpense' table. You can move, or remove it, as needed.
            this.IncomeExpenseTableAdapter.Fill(this.GeneralLegerDataSet.IncomeExpense,Date,Dept);

            this.reportViewer1.RefreshReport();
        }
    }
}
