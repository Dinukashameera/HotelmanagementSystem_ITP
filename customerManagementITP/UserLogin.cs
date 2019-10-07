using customerManagementITP;
using GYM;
using Hall_Reservation;
using Stock_Management_System;
using Kitchen_Management_System;
using EmpManagementSystem;
using Pract._1;
using SPA;
using FinanceManagement_Blue_Lotus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLotusLogin
{
    public partial class UserLogin : MetroFramework.Forms.MetroForm
    {
        public UserLogin()
        {
            InitializeComponent();
            cmbusertype.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;

            if (username == "c" && password == "c")
            {
                CustomerForm form = new CustomerForm();
                
                form.Show();

            } else if (username == "g" && password == "g")
            {
                GymManagementForm gymForm = new GymManagementForm();
                gymForm.Show();
            }
            else if (username == "i" && password == "i")
            {
                StockManagement gymForm = new StockManagement();
                gymForm.Show();
            }
            else if (username == "k" && password == "k")
            {
                KMS gymForm = new KMS();
                gymForm.Show();
            }
            else if (username == "h" && password == "h")
            {
               HRS_MAIN hallMain = new HRS_MAIN();
                hallMain.Show();
            }
            else if (username == "e" && password == "e")
            {
                EmployeeMangementSystem ems = new EmployeeMangementSystem();
                ems.Show();
            }
            else if (username == "s" && password == "s")
            {
                spaForm spa = new spaForm();
                spa.Show();

            }
            else if (username == "f" && password == "f")
            {
                FinanceForm finance = new FinanceForm();
                finance.Show();

            }
            else if (username == "cat" && password == "cat")
            {
                ThemeMenu themenu = new ThemeMenu();
                themenu.Show();

            }

        }
    }
}
