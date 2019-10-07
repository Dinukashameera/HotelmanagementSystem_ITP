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
    public partial class CaterCustomerOrder : MetroFramework.Forms.MetroForm
    
    {
        private SqlConnection sqlCon = DBConnection.getConnection();
        public CaterCustomerOrder()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Crud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet3.Breakfast1' table. You can move, or remove it, as needed.
            //this.breakfast1TableAdapter.Fill(this.blue_Lotus_HotelDataSet3.Breakfast1);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.PCustomer' table. You can move, or remove it, as needed.
            //this.pCustomerTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.PCustomer);
            FillDataGrid();
            FillDataGridOrder();
            FillDataGridLunch();
            FillDataGridDinner();
            FillDataGridTransport();
            FillDataGridTheme();
            FilldgvFinalOrder();
            Reset();
        }

        
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
           
        }

        public static bool ValidateString(string string1)
        {
            List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "1","2","3","4","5","6","7","8","9","0" };
            // Check for length
            if (string1.Length > 15)
            {
                MessageBox.Show("Name too Long");
                return false;
            }
       
            else
            {
                //Iterate your list of invalids and check if input has one
                foreach (string s in invalidChars)
                {
                    if (string1.Contains(s))
                    {
                        MessageBox.Show("Name contains invalid character: " + s);
                        return false;
                    }
                }
                MessageBox.Show("Name tests succesful");
                return true;
            }
        }

        private bool ValidateNIC(string txtID)
        {
            if (!string.IsNullOrEmpty(txtID))
            {
                char[] letter = txtID.ToCharArray();
                if (letter.Length == 10)
                {
                    if (letter[9] == 'v' | letter[9] == 'x')
                    {
                        for (int i = 0; i <= (letter.Length - 2); i++)
                        {
                            if (char.IsNumber(letter[i]) == false)
                            {
                                MessageBox.Show(string.Format("NIC letter {0 } is not allowed, all Should be numbers except the last one.", letter[i]));
                                return false;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("NIC Last letter should be x or v in simple letters");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("NIC Length should be 10 ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("NIC is null");
                return false;
            }
        }

        

        private void BtnSv_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtID.Text == "" || txtName.Text == "")
                {
                    MessageBox.Show("Input NIC and Name");
                }
                

                else if(ValidateNIC(txtID.Text) == true & ValidateString(txtName.Text) == true)
                {
                   
                        if(sqlCon.State == ConnectionState.Closed)
                            sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("NewCustomer", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@NIC", txtID.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", txtMail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Address", txtAdd.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@mobile", txtTel.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Saved succesfully");
                        FillDataGrid();
                        Reset();
                    
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGrid()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("search1",sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", txtSrch.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", txtSrch.Text.Trim());
           
            
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvCus.DataSource = dtbl;
            sqlCon.Close();
        }

        void FillDataGridOrder()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchOrder", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", txtsrchOrder.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", txtsrchOrder.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvOrder.DataSource = dtbl;
            sqlCon.Close();
        }

        void FillDataGridLunch()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchlunch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", textBox7.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textBox7.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlCon.Close();
        }

        private void FillDataGridDinner()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchDinner", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", textBox32.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textBox32.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridDinner.DataSource = dtbl;
            sqlCon.Close();
        }

        private void FillDataGridTransport()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchTransport", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", textBox32.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textBox32.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridTransport.DataSource = dtbl;
            sqlCon.Close();
        }

        private void FillDataGridTheme()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchTheme", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", textBox32.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textBox32.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridTheme.DataSource = dtbl;
            sqlCon.Close();
        }

        private void FilldgvFinalOrder()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("searchFOrder", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@id", textBox43.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@finalised", textBox43.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvFinalOrder.DataSource = dtbl;
            sqlCon.Close();
        }

        void Reset()
        {
            txtID.Text = txtName.Text = txtMail.Text = txtSrch.Text = txtAdd.Text = txtTel.Text = "";
            btnEdit.Text = "Edit";
            btnDelete.Enabled = false;
        }

        private void DgvCus_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCus.CurrentRow.Index != -1)
            {
                txtID.Text = dgvCus.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvCus.CurrentRow.Cells[2].Value.ToString();
                txtMail.Text = dgvCus.CurrentRow.Cells[3].Value.ToString();
                txtAdd.Text = dgvCus.CurrentRow.Cells[4].Value.ToString();
                txtTel.Text = dgvCus.CurrentRow.Cells[5].Value.ToString();
                btnEdit.Text = "Update";
                btnEdit.BackColor = Color.Blue;
                btnDelete.Enabled = true;
                button31.Visible = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text=="Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("NewCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@NIC", txtID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtMail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAdd.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@mobile", txtTel.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGrid();
                    Reset();
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DgvCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteCustomer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
              
                sqlCmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
              
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGrid();
                Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void DgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvOrder_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void BtneditOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtOrderNo.Text = txtPack.Text = txtTea.Text = txtMeals.Text = txtCurry.Text = "";
            btnEdit.Text = "Edit";
            btnDeleteOrder.Enabled = false;
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) - Double.Parse(textBox41.Text) + Double.Parse(textBox42.Text)).ToString();
           
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            FillDataGridOrder();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            txtOrderNo.Text = txtPack.Text = txtTea.Text = txtMeals.Text = txtCurry.Text = "";
            btnEdit.Text = "Edit";
            btnDeleteOrder.Enabled = false;
        }

        private void BtneditOrder_Click_1(object sender, EventArgs e)
        {
            if (btneditOrder.Text == "Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("breakfastPro", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Pack", txtPack.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@orderno", txtOrderNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", txtTea.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@meal", txtMeals.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", txtCurry.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGridOrder();
                    txtOrderNo.Text = txtPack.Text = txtTea.Text = txtMeals.Text = txtCurry.Text = txtPrice.Text = "";
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

        private void DgvOrder_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow.Index != -1)
            {
                txtOrderNo.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                txtPack.Text = dgvOrder.CurrentRow.Cells[1].Value.ToString();
                txtTea.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
                txtMeals.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
                txtCurry.Text = dgvOrder.CurrentRow.Cells[4].Value.ToString();
                txtPrice.Text = dgvOrder.CurrentRow.Cells[5].Value.ToString();
                btneditOrder.Text = "Update";
                btneditOrder.BackColor = Color.Blue;
                btnDeleteOrder.Enabled = true;
                button26.Visible = true;
            }
        }

        private void BtnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteorder", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", txtOrderNo.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGridOrder();
                txtOrderNo.Text = txtPack.Text = txtTea.Text = txtMeals.Text = txtCurry.Text = txtPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("breakfast", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@Pack", txtPack.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tea", txtTea.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@meal", txtMeals.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@curry", txtCurry.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved succesfully");
                FillDataGridOrder();
                txtOrderNo.Text = txtPack.Text = txtTea.Text = txtMeals.Text = txtCurry.Text = txtPrice.Text = "";
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

        private void DgvOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox29.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox30.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                button7.Text = "Update";
                button7.BackColor = Color.Blue;
                button6.Enabled = true;
                button27.Visible = true;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("lunch", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Pack", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@orderno", textBox6.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@meal", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dessert", textBox30.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", textBox29.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGridLunch();
                    ResetLunch();
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

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FillDataGridLunch();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            FillDataGridDinner();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            FillDataGridTransport();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            FillDataGridTheme();
        }

        private void DataGridDinner_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridDinner.CurrentRow.Index != -1)
            {
                textBox31.Text = dataGridDinner.CurrentRow.Cells[0].Value.ToString();
                textBox14.Text = dataGridDinner.CurrentRow.Cells[1].Value.ToString();
                textBox13.Text = dataGridDinner.CurrentRow.Cells[2].Value.ToString();
                textBox9.Text = dataGridDinner.CurrentRow.Cells[3].Value.ToString();
                textBox12.Text = dataGridDinner.CurrentRow.Cells[4].Value.ToString();
                textBox11.Text = dataGridDinner.CurrentRow.Cells[5].Value.ToString();
                textBox10.Text = dataGridDinner.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridDinner.CurrentRow.Cells[7].Value.ToString();
                button12.Text = "Update";
                button12.BackColor = Color.Blue;
                button11.Enabled = true;
                button28.Visible = true;
            }
        }

        private void DataGridTransport_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridTransport.CurrentRow.Index != -1)
            {
                textBox20.Text = dataGridTransport.CurrentRow.Cells[0].Value.ToString();
                textBox19.Text = dataGridTransport.CurrentRow.Cells[1].Value.ToString();
                textBox18.Text = dataGridTransport.CurrentRow.Cells[2].Value.ToString();
                textBox16.Text = dataGridTransport.CurrentRow.Cells[3].Value.ToString();
                textBox17.Text = dataGridTransport.CurrentRow.Cells[4].Value.ToString();
                textBox33.Text = dataGridTransport.CurrentRow.Cells[5].Value.ToString();
                textBox15.Text = dataGridTransport.CurrentRow.Cells[6].Value.ToString();
                button17.Text = "Update";
                button17.BackColor = Color.Blue;
                button16.Enabled = true;
                button29.Visible = true;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("transportDet", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@delDate", textBox19.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@retDate", textBox18.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@madeDate", textBox16.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Location", textBox17.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@distance", textBox33.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox15.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@orderno", textBox20.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGridTransport();
                    resetTransport();
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

        private void DataGridTheme_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridTheme.CurrentRow.Index != -1)
            {
                textBox27.Text = dataGridTheme.CurrentRow.Cells[0].Value.ToString();
                textBox26.Text = dataGridTheme.CurrentRow.Cells[1].Value.ToString();
                textBox25.Text = dataGridTheme.CurrentRow.Cells[2].Value.ToString();
                textBox23.Text = dataGridTheme.CurrentRow.Cells[3].Value.ToString();
                textBox24.Text = dataGridTheme.CurrentRow.Cells[4].Value.ToString();
                textBox34.Text = dataGridTheme.CurrentRow.Cells[5].Value.ToString();
                textBox35.Text = dataGridTheme.CurrentRow.Cells[7].Value.ToString();
                textBox36.Text = dataGridTheme.CurrentRow.Cells[6].Value.ToString();
                textBox22.Text = dataGridTheme.CurrentRow.Cells[8].Value.ToString();
                button22.Text = "Update";
                button22.BackColor = Color.Blue;
                button21.Enabled = true;
                button30.Visible = true;
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            
                textBox38.Text = (Double.Parse(txtOrderNo.Text)).ToString();
                txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) + Double.Parse(txtPrice.Text)).ToString();
            
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            textBox37.Text = (Double.Parse(textBox6.Text)).ToString();
            txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) + Double.Parse(textBox1.Text)).ToString();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            textBox39.Text = (Double.Parse(textBox31.Text)).ToString();
            txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) + Double.Parse(textBox8.Text)).ToString();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            textBox40.Text = (Double.Parse(textBox20.Text)).ToString();
            txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) + Double.Parse(textBox15.Text)).ToString();
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            textBox44.Text = (Double.Parse(textBox27.Text)).ToString();
            txtFinalTot.Text = (Double.Parse(txtFinalTot.Text) + Double.Parse(textBox22.Text)).ToString();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("transport", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@delDate", textBox19.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@retDate", textBox18.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@madeDate", textBox16.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Location", textBox17.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@distance", textBox33.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@price", textBox15.Text.Trim());
                

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved succesfully");
                FillDataGridTransport();
                resetTransport();
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

        public static bool ValidateStringFinal(string string1)
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
                        MessageBox.Show("Value contain invalid character in " + string1 + ": " + s);
                        return false;
                    }
                }

                return true;
            }
        }

        private void Button24_Click_1(object sender, EventArgs e)
        {
            if (button24.Text == "Update")
            {
                if (txtNIC.Text == "")
                {
                    MessageBox.Show("Fill field 'NIC:' ");
                }
                else if (ValidateNIC(txtNIC.Text) == true & ValidateStringFinal(textBox38.Text) == true & ValidateStringFinal(textBox37.Text) == true & ValidateStringFinal(textBox39.Text) == true & ValidateStringFinal(textBox40.Text) == true & ValidateStringFinal(textBox44.Text) == true & ValidateStringFinal(textBox41.Text) == true & ValidateStringFinal(textBox42.Text) == true)
                {


                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                            sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("finalOrderPro", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@breakfast", textBox38.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@lunch", textBox37.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@dinner", textBox39.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@theme", textBox44.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@transport", textBox40.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@advance", textBox41.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@fine", textBox42.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@total", txtFinalTot.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@finalised", cmbStat.SelectedItem);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Updated succesfully");
                        FilldgvFinalOrder();
                        resetFinal();
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
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("finalOrderPro", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@breakfast", textBox38.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lunch", textBox37.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dinner", textBox39.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@theme", textBox44.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@transport", textBox40.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@advance", textBox41.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@fine", textBox42.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@total", txtFinalTot.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@finalised", cmbStat.SelectedItem);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved succesfully");
                    FilldgvFinalOrder();
                    resetFinal();
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

        private void BtnSrchFOrd_Click(object sender, EventArgs e)
        {
            FilldgvFinalOrder();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            txtNIC.Text = txtID.Text;
            MessageBox.Show("NIC passed, refer Order tab");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ResetLunch();
        }

        private void ResetLunch()
        {
            textBox6.Text = textBox5.Text = textBox4.Text = textBox2.Text = textBox3.Text = textBox29.Text = textBox30.Text = textBox7.Text = textBox1.Text = " ";
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            resetDinner();
        }

        private void resetDinner()
        {
            textBox31.Text = textBox14.Text = textBox13.Text = textBox9.Text = textBox12.Text = textBox11.Text = textBox10.Text = textBox8.Text = textBox32.Text = "";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            resetTransport();
        }

        private void resetTransport()
        {
            textBox21.Text = textBox33.Text = textBox17.Text = textBox16.Text = textBox18.Text = textBox19.Text = textBox20.Text = textBox15.Text = "";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            resetTheme();
        }

        private void resetTheme()
        {
            textBox28.Text = textBox34.Text = textBox24.Text = textBox23.Text = textBox25.Text = textBox26.Text = textBox27.Text = textBox22.Text = textBox35.Text = textBox36.Text = "";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("dinnerPro", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Pack", textBox14.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@orderno", textBox31.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", textBox11.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@meal", textBox13.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", textBox9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dessert", textBox12.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", textBox10.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGridDinner();
                    resetDinner();
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

        private void Button22_Click(object sender, EventArgs e)
        {
            if (button22.Text == "Update")
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("themeFur", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@type", textBox19.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@chairs", textBox18.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tables", textBox16.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@plates", textBox17.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@cups", textBox33.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@employees", textBox15.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tent", textBox15.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox15.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@orderno", textBox20.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated succesfully");
                    FillDataGridTheme();
                    resetTheme();
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

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deletelunch", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", textBox6.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGridLunch();
                ResetLunch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("lunchMod", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", textBox5.Text.Trim());
                   
                    sqlCmd.Parameters.AddWithValue("@tea", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@meal", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dessert", textBox30.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", textBox29.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved succesfully");
                    FillDataGridLunch();
                    ResetLunch();
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

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deletedinner", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", textBox31.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGridDinner();
                resetDinner();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteTrans", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", textBox20.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGridTransport();
                resetTransport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteTheme", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", textBox27.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FillDataGridTheme();
                resetTheme();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("dinner", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", textBox14.Text.Trim());
                    
                    sqlCmd.Parameters.AddWithValue("@tea", textBox11.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@meal", textBox13.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", textBox9.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", textBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@dessert", textBox12.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", textBox10.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("saved succesfully");
                    FillDataGridDinner();
                    resetDinner();
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

        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("theme", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@type", textBox19.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@chairs", textBox18.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tables", textBox16.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@plates", textBox17.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@cups", textBox33.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@employees", textBox15.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@tent", textBox15.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@price", textBox15.Text.Trim());
                

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved succesfully");
                FillDataGridTheme();
                resetTheme();
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

        private void DgvFinalOrder_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFinalOrder.CurrentRow.Index != -1)
            {
                txtNIC.Text = dgvFinalOrder.CurrentRow.Cells[0].Value.ToString();
                textBox38.Text = dgvFinalOrder.CurrentRow.Cells[1].Value.ToString();
                textBox37.Text = dgvFinalOrder.CurrentRow.Cells[2].Value.ToString();
                textBox39.Text = dgvFinalOrder.CurrentRow.Cells[3].Value.ToString();
                textBox44.Text = dgvFinalOrder.CurrentRow.Cells[4].Value.ToString();
                textBox40.Text = dgvFinalOrder.CurrentRow.Cells[5].Value.ToString();
                textBox41.Text = dgvFinalOrder.CurrentRow.Cells[7].Value.ToString();
                textBox42.Text = dgvFinalOrder.CurrentRow.Cells[6].Value.ToString();
                txtFinalTot.Text = dgvFinalOrder.CurrentRow.Cells[8].Value.ToString();
                cmbStat.SelectedValue = dgvFinalOrder.CurrentRow.Cells[8].Value.ToString();
                button24.Text = "Update";
                button24.BackColor = Color.Blue;
             
                button32.Visible = true;
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            resetFinal();
        }

        private void resetFinal()
        {
            txtNIC.Text = textBox38.Text = textBox37.Text = textBox39.Text = textBox44.Text = textBox40.Text = textBox41.Text = textBox42.Text = txtFinalTot.Text = "";
            button24.Text = "Submit";
            button24.BackColor = Color.SkyBlue;
            cmbStat.SelectedItem = null;
            button32.Visible = false;
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("deleteFinal", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@id", txtNIC.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                FilldgvFinalOrder();
                resetFinal();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {
            CateringOrderReportForm cateringOrderReport = new CateringOrderReportForm();
            cateringOrderReport.Show();
        }
    }
}
