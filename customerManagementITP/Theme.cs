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
    public partial class Theme : MetroFramework.Forms.MetroForm
    {
        //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-HF49OAS\DJSQL;Initial Catalog=Blue_Lotus_Hotel;Persist Security Info=True;User ID=sa;Password=DJcreations1@");
        private SqlConnection sqlCon = DBConnection.getConnection();

        public Theme()
        {
            InitializeComponent();
        }

        private void Theme_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtPrice.Text = (Double.Parse(txtPrice.Text) + Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text) + Double.Parse(textBox5.Text) + Double.Parse(textBox3.Text) + Double.Parse(textBox4.Text) + 1000).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtTheme_DoubleClick(object sender, EventArgs e)
        {
            
        }
        //--------------------------------------------------------------updated----------------------------------------------------------------------


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            txtTheme.Text = "Tropical";
            txtPrice.Text = (300 + Double.Parse(txtPrice.Text)).ToString();

            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            txtTheme.Text = "Floral";
            txtPrice.Text = (500 + Double.Parse(txtPrice.Text)).ToString();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            txtTheme.Text = "Execuive";
            txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   

            if (comboBox1.SelectedIndex == 0 )
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                    txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
                }
               
            else if (comboBox1.SelectedIndex == 1)
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
            }
           
            else if (comboBox1.SelectedIndex == 2)
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
            }
            
            else if (comboBox1.SelectedIndex == 3)
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
            }
            
            else if (comboBox1.SelectedIndex == 4)
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
            }

            else if (comboBox1.SelectedIndex == 5)
            {

                //if (e.NewValue == CheckState.Checked)
                //{

                txtPrice.Text = (900 + Double.Parse(txtPrice.Text)).ToString();
            }


        }

        private void TxtPrice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static bool ValidateString(string string1)
        {
            List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-"};
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
                        MessageBox.Show("Values contain invalid character: " + s);
                        return false;
                    }
                }
                
                return true;
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (txtTheme.Text == "")
            {
                MessageBox.Show("Choose a theme type");
            }
            else if (ValidateString(textBox1.Text) == true & ValidateString(textBox2.Text) == true & ValidateString(textBox3.Text) == true & ValidateString(textBox4.Text) == true & ValidateString(textBox5.Text) == true)
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("theme", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");

                    sqlCmd.Parameters.AddWithValue("@type", txtTheme.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@chairs", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tables", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@plates", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cups", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@employees", textBox5.Text.Trim());
                    if (comboBox1.Text == "Size")
                    {
                        sqlCmd.Parameters.AddWithValue("@tent", "0");
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@tent", comboBox1.SelectedItem);
                    }
                    sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
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

        private void BtnTreset_Click(object sender, EventArgs e)
        {
            resetTtext();
        }

        private void resetTtext()
        {
            txtTheme.Text = "";
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = txtPrice.Text = "0";
            comboBox1.SelectedItem = null;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            txtTheme.Text = "Executive";
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = txtPrice.Text = "10";
            comboBox1.SelectedItem = 2;
        }
    }
}
