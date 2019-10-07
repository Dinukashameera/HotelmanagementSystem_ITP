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
    public partial class ExpenseReportForm : Form
    {
        String Date, Dept;


        public ExpenseReportForm(String date , String dept)
        {
            InitializeComponent();
            this.Date = date;
            this.Dept = dept;
        }

        private void ExpenseReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ExpenseDataSet.TotalExpenses' table. You can move, or remove it, as needed.
            this.TotalExpensesTableAdapter.Fill(this.ExpenseDataSet.TotalExpenses,Date,Dept);

            this.reportViewer1.RefreshReport();
        }
    }
}
