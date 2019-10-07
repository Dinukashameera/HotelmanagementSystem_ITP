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
    public partial class ThemeMenu : MetroFramework.Forms.MetroForm
    {

        public double menuVal;
        

        public ThemeMenu()
        {
            InitializeComponent();
        }

        private void ThemeMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Theme f3 = new Theme();
            
            f3.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Food_Menu f4 = new Food_Menu();
            
            f4.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            transportation f5 = new transportation();
            f5.Show();
        }

        public void TxtTotMenu_TextChanged(object sender, EventArgs e)
        {
            
           
         
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CaterCustomerOrder f6 = new CaterCustomerOrder();
            f6.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Theme f3 = new Theme();
            f3.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Food_Menu f4 = new Food_Menu();
            f4.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            transportation f5 = new transportation();
            f5.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            CaterCustomerOrder f6 = new CaterCustomerOrder();
            f6.Show();
        }
    }
}
