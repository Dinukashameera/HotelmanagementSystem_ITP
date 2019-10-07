using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pract._1
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Register_Customer f1 = new Register_Customer();
            this.Hide();
            f1.Show();
        }

        private void RegCus_Click(object sender, EventArgs e)
        {
            Customer_Login f2 = new Customer_Login();
            this.Hide();
            f2.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void CustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void CustomerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void CustomerBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
           

        }

        private void CustomerDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
