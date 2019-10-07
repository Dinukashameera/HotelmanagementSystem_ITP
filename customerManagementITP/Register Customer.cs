using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pract._1
{
    public partial class Register_Customer : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-HF49OAS\DJSQL;Initial Catalog=Blue_Lotus_Hotel;Persist Security Info=True;User ID=sa;Password=DJcreations1@");
        public Register_Customer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("NewCustomer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@NIC", txtNIC.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", txtAd.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@mobile", txtTel.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
