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
    public partial class CheckedCustomerForm : Form
    {
        public CheckedCustomerForm()
        {
            InitializeComponent();
        }

        private void CheckedCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Blue_Lotus_HotelDataSet.Accomodation' table. You can move, or remove it, as needed.
            this.AccomodationTableAdapter.Fill(this.Blue_Lotus_HotelDataSet.Accomodation);

            this.reportViewer1.RefreshReport();
        }
    }
}
