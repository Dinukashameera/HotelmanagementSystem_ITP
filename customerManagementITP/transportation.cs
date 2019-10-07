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
using customerManagementITP;

namespace Pract._1
{
    public partial class transportation : MetroFramework.Forms.MetroForm
    {
        private SqlConnection sqlCon = DBConnection.getConnection();
        public transportation()
        {
            InitializeComponent();
        }

        private void Transportation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet2.Transport' table. You can move, or remove it, as needed.
            //this.transportTableAdapter.Fill(this.blue_Lotus_HotelDataSet2.Transport);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DelDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtSub_TextChanged(object sender, EventArgs e)
        {

        }

        public static bool ValidateString(string string1)
        {
            List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-" };
            // Check for length
            if (string1.Length > 5)
            {
                MessageBox.Show("Value too Long");
                return false;
            }

            else
            {
                //Iterate your list of invalids and check if input has one
                foreach (string s in invalidChars)
                {
                    if (string1.Contains(s))
                    {
                        MessageBox.Show("Value contain invalid character in "+ string1 + ": " + s);
                        return false;
                    }
                }

                return true;
            }
        }

        private void BtnTrans_Click(object sender, EventArgs e)
        {
            if (txtLoc.Text == "")
            {
                MessageBox.Show("Enter location");
            }
            else if (txtDis.Text == "")
            {
                MessageBox.Show("Enter Distance");
            }
            else if (txtSub.Text == "")
            {
                MessageBox.Show("Enter amount for transport");
            }
            else if(ValidateString(txtLoc.Text) == true & ValidateString(txtDis.Text) == true & ValidateString(txtSub.Text) == true)
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("transport", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@delDate", delDate.Value);
                    sqlCmd.Parameters.AddWithValue("@retDate", retDate.Value);
                    sqlCmd.Parameters.AddWithValue("@madeDate", madeDate.Value);
                    sqlCmd.Parameters.AddWithValue("@Location", txtLoc.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@distance", txtDis.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", txtSub.Text.Trim());


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
        }
    }
}
