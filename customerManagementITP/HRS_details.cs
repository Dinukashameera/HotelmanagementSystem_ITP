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
//using System.Web.UI.WebControls;

namespace Hall_Reservation
{
    public partial class HRS_MAIN : MetroFramework.Forms.MetroForm
    {
        public HRS_MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet11.HRS_BLH_payments' table. You can move, or remove it, as needed.
            //this.hRS_BLH_paymentsTableAdapter.Fill(this.blue_Lotus_HotelDataSet11.HRS_BLH_payments);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet11.HRS_BLH_damage' table. You can move, or remove it, as needed.
            //this.hRS_BLH_damageTableAdapter.Fill(this.blue_Lotus_HotelDataSet11.HRS_BLH_damage);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet11.HRS_BLH_customer' table. You can move, or remove it, as needed.
           // this.hRS_BLH_customerTableAdapter.Fill(this.blue_Lotus_HotelDataSet11.HRS_BLH_customer);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet11.HRS_BLH_hall' table. You can move, or remove it, as needed.
           // this.hRS_BLH_hallTableAdapter.Fill(this.blue_Lotus_HotelDataSet11.HRS_BLH_hall);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet.HRS_hall_detail' table. You can move, or remove it, as needed.
            //this.hRS_hall_detailTableAdapter.Fill(this.blue_Lotus_HotelDataSet.HRS_hall_detail);

            dgvDamageItems.DataSource = di.viewSearch();
            dgvPersonalDetails.DataSource = pd.viewSearch();
            dgvHallDetails.DataSource = hd.viewSearch();
            dgvpendingpay.DataSource = pay.viewPendingPayments();
            dgvpartiallypaidcus.DataSource = pay.viewcutomerpending();
            dgvcompletedcustomer.DataSource = pay.viewcutomercompleted();

            //to disable the cus_id column in personal details grid
            //dgvPersonalDetails.Columns[0].Visible = false;
        }

        public void displaydgvDamageItems()
        {
            di.ItemNo = txtSearchDItems.Text.Trim().ToString();

            //DataTable dt = di.search();
        }
        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void MetroLink2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QUA6BDC\SQLEXPRESS;Initial Catalog=Blue_Lotus_Hotel;Integrated Security=True");

        private void BtnPDSubmit_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddCus_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }

        private void ML_nxt_Click(object sender, EventArgs e)
        {
            new HRS_filter().Show();
            this.Hide();
        }


        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
        Personal_details pd = new Personal_details();
        private void BtnPDAdd_Click_1(object sender, EventArgs e)
        {
            pd.First_name = txtEmail.Text.Trim().ToString();
            pd.Last_name = txtLastName.Text.Trim().ToString();
            pd.Nic = txtNIC.Text.Trim().ToString();
            pd.Address = txtAddress.Text.Trim().ToString();
            pd.Email = txtFirstName.Text.Trim().ToString();
            pd.Phone = txtMobile.Text.Trim().ToString();
            pd.Lang = cmbLang.Text.Trim().ToString();

            if (txtEmail.Text == "" || txtLastName.Text == "" || txtNIC.Text == "" || txtAddress.Text == ""
                || txtFirstName.Text == "" || txtMobile.Text == "" || cmbLang.Text == null)
            {
                MessageBox.Show("fields cannot be null!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pd.Add();
                dgvPersonalDetails.DataSource = pd.viewSearch();
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            new hall_Information_HRS().Show();
            this.Hide();
        }

        Hall_details hd = new Hall_details();
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Premium";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Gold";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Silver";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Bronze";
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            hd.Bar = "yes";
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            hd.Bar = "No";
        }

        private void BtnHDSubmit_Click(object sender, EventArgs e)
        {
        }

        private void Label31_Click(object sender, EventArgs e)
        {

        }

        private void Label32_Click(object sender, EventArgs e)
        {

        }

        Damage_items di = new Damage_items();
        private void Button2_Click_1(object sender, EventArgs e)
        {
            di.ItemNo = txtitemNo.Text.Trim().ToString();
            di.ItemName = txtitemname.Text.Trim().ToString();
            di.ItemDes = txtitemdesc.Text.Trim().ToString();
            di.HallDes = txthalldesc.Text.Trim().ToString();

            di.Add();
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        Damage_items disearch = new Damage_items();
        DataTable dt = new DataTable();
        private void Button5_Click(object sender, EventArgs e)
        {
            dgvDamageItems.DataSource = disearch.search(txtSearchDItems.Text.ToString());
        }

        private void DgvDamageItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvDamageItems_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDamageItems.CurrentRow.Index != -1)
            {
                txtitemNo.Text = dgvDamageItems.CurrentRow.Cells[0].Value.ToString();
                txtitemname.Text = dgvDamageItems.CurrentRow.Cells[1].Value.ToString();
                txtitemdesc.Text = dgvDamageItems.CurrentRow.Cells[2].Value.ToString();
                txthalldesc.Text = dgvDamageItems.CurrentRow.Cells[3].Value.ToString();

                btnDISave.Text = "Update";
                btnDIDel.Enabled = true;
            }
        }

        private void BtnDIAdd_Click(object sender, EventArgs e)
        {
            if (btnDISave.Text == "Add")
            {
                di.ItemNo = txtitemNo.Text.Trim().ToString();
                di.ItemName = txtitemname.Text.Trim().ToString();
                di.ItemDes = txtitemdesc.Text.Trim().ToString();
                di.HallDes = txthalldesc.Text.Trim().ToString();

                di.Add();
                dgvDamageItems.DataSource = di.viewSearch();
            }
            else
            {

                di.ItemNo = txtitemNo.Text.Trim().ToString();
                di.ItemName = txtitemname.Text.Trim().ToString();
                di.ItemDes = txtitemdesc.Text.Trim().ToString();
                di.HallDes = txthalldesc.Text.Trim().ToString();

                di.update();
                dgvDamageItems.DataSource = di.viewSearch();
            }
        }

        private void DgvDamageItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //reset
        private void BtnDIUpdate_Click(object sender, EventArgs e)
        {
            txtitemNo.Text = txtitemname.Text = txtitemdesc.Text = txthalldesc.Text = "";
            btnDISave.Text = "Save";
            btnDIDel.Enabled = false;
        }

        private void BtnDIDel_Click(object sender, EventArgs e)
        {
            di.ItemNo = txtitemNo.Text.Trim().ToString();
            di.ItemName = txtitemname.Text.Trim().ToString();
            di.ItemDes = txtitemdesc.Text.Trim().ToString();
            di.HallDes = txthalldesc.Text.Trim().ToString();

            di.delete();
            dgvDamageItems.DataSource = di.viewSearch();
        }

        private void TxtSearchDItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPDReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = txtLastName.Text = txtNIC.Text = txtMobile.Text =
                txtFirstName.Text = txtAddress.Text = cmbLang.Text = "";
            btnDISave.Text = "Save";
            btnDIDel.Enabled = false;
        }

        private void BtnPDDelete_Click(object sender, EventArgs e)
        {

        }

        private void DgvPersonalDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Cus_id = 0;
        private void DgvPersonalDetails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPersonalDetails.CurrentRow.Index != -1)
            {
                Cus_id = Convert.ToInt32(dgvPersonalDetails.CurrentRow.Cells[0].Value.ToString());
                txtEmail.Text = dgvPersonalDetails.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvPersonalDetails.CurrentRow.Cells[2].Value.ToString();
                txtNIC.Text = dgvPersonalDetails.CurrentRow.Cells[3].Value.ToString();
                cmbLang.Text = dgvPersonalDetails.CurrentRow.Cells[4].Value.ToString();
                txtAddress.Text = dgvPersonalDetails.CurrentRow.Cells[5].Value.ToString();
                txtFirstName.Text = dgvPersonalDetails.CurrentRow.Cells[6].Value.ToString();
                txtMobile.Text = dgvPersonalDetails.CurrentRow.Cells[7].Value.ToString();

            }

            btnPDReset.Enabled = true;
            btnPDAdd.Enabled = true;
            dgvPersonalDetails.Columns[0].Visible = true;
        }

        private void BtnPDUpdate_Click(object sender, EventArgs e)
        {
            pd.First_name = txtEmail.Text.Trim().ToString();
            pd.Last_name = txtLastName.Text.Trim().ToString();
            pd.Nic = txtNIC.Text.Trim().ToString();
            pd.Address = txtAddress.Text.Trim().ToString();
            pd.Email = txtFirstName.Text.Trim().ToString();
            pd.Phone = txtMobile.Text.Trim().ToString();
            pd.Lang = cmbLang.Text.Trim().ToString();

            pd.update();
            dgvPersonalDetails.DataSource = pd.viewSearch();
        }

        private void DgvPersonalDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //halldetails_add
        private void Button4_Click(object sender, EventArgs e)
        {
            hd.CusID = txtcusIdHD.Text.Trim().ToString();
            hd.Halltype = hd.Halltype;
            hd.HallName1 = cmbHallName.Text.Trim().ToString();
            hd.Eventtype = cmbEventType.Text.Trim().ToString();
            hd.Date1 = dateTimeHD.Value.ToString();
            hd.Time = txtTime.Text.Trim().ToString();
            hd.AmPm = cmbAmPm.Text.Trim().ToString();
            hd.FoodType = cmbFoodType.Text.Trim().ToString();
            hd.Bar = hd.Bar;
            hd.Status = cmbStatus.Text.Trim().ToString();
            hd.Notes = txtAddNotes.Text.Trim().ToString();


            if (txtcusIdHD.Text == "" || hd.Halltype == "" || cmbHallName.Text == null || cmbEventType.Text == null ||
                txtTime.Text == "" || cmbAmPm.Text == null || cmbFoodType.Text == null
                || hd.Bar == "" || cmbStatus.Text == null)
            {
                MessageBox.Show("Fields cannot be empty!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hd.Add();
                dgvHallDetails.DataSource = hd.viewSearch();
            }


        }
        //halldetails_update
        private void Button2_Click_2(object sender, EventArgs e)
        {
            hd.CusID = txtcusIdHD.Text.Trim().ToString();
            hd.Halltype = hd.Halltype;
            hd.HallName1 = cmbHallName.Text.Trim().ToString();
            hd.Eventtype = cmbEventType.Text.Trim().ToString();
            hd.Date1 = dateTimeHD.Value.ToString();
            hd.Time = txtTime.Text.Trim().ToString();
            hd.AmPm = cmbAmPm.Text.Trim().ToString();
            hd.FoodType = cmbFoodType.Text.Trim().ToString();
            hd.Bar = hd.Bar;
            hd.Status = cmbStatus.Text.Trim().ToString();
            hd.Notes = txtAddNotes.Text.Trim().ToString();

            hd.update();
            dgvHallDetails.DataSource = hd.viewSearch();
        }

        //halldetails_reset
        private void Button1_Click(object sender, EventArgs e)
        {
            txtcusIdHD.Text = cmbHallName.Text = cmbEventType.Text = txtTime.Text = hd.Halltype = hd.Bar =
            cmbAmPm.Text = cmbFoodType.Text = cmbStatus.Text =
            txtAddNotes.Text = "";

            rdBronze.Checked = false;
            rdPremium.Checked = false;
            rdSilver.Checked = false;
            rdBronze.Checked = false;
            rdYes.Checked = false;
            rdNo.Checked = false;
        }

        private void TxtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvHallDetails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHallDetails.CurrentRow.Index != -1)
            {
                txtcusIdHD.Text = dgvHallDetails.CurrentRow.Cells[1].Value.ToString();
                cmbHallName.Text = dgvHallDetails.CurrentRow.Cells[2].Value.ToString();
                String HallType = dgvHallDetails.CurrentRow.Cells[3].Value.ToString();
                cmbEventType.Text = dgvHallDetails.CurrentRow.Cells[4].Value.ToString();
                dateTimeHD.Text = dgvHallDetails.CurrentRow.Cells[5].Value.ToString();
                txtTime.Text = dgvHallDetails.CurrentRow.Cells[6].Value.ToString();
                cmbAmPm.Text = dgvHallDetails.CurrentRow.Cells[7].Value.ToString();
                cmbFoodType.Text = dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
                String Bar = dgvHallDetails.CurrentRow.Cells[12].Value.ToString();
                cmbStatus.Text = dgvHallDetails.CurrentRow.Cells[8].Value.ToString();
                txtAddNotes.Text = dgvHallDetails.CurrentRow.Cells[13].Value.ToString();

                if (HallType == "Premium")
                {
                    rdPremium.Checked = true;
                }
                else if (HallType == "Gold")
                {
                    rdGold.Checked = true;
                }
                else if (HallType == "Silver")
                {
                    rdSilver.Checked = true;
                }
                else if (HallType == "Bronze")
                {
                    rdBronze.Checked = true;
                }

                if (Bar == "yes")
                {
                    rdYes.Checked = true;
                }
                else if (Bar == "No")
                {
                    rdNo.Checked = true;
                }
            }

            btnHDAdd.Enabled = true;
            btnHDReset.Enabled = true;
            dgvHallDetails.Columns[0].Visible = false;
        }

        private void Label27_Click(object sender, EventArgs e)
        {

        }

        private void GbHallType_Enter(object sender, EventArgs e)
        {

        }
        //validating time in hall detail
        private void TxtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char time = e.KeyChar;
            if (!Char.IsDigit(time) && time != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //validating cusid in hall details
        private void TxtcusIdHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char cusID = e.KeyChar;
            if (!Char.IsDigit(cusID) && cusID != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }

        private void CmbHallName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void CmbHallName_Validating(object sender, CancelEventArgs e)
        {
            if (cmbHallName.SelectedItem == null)
            {
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //validation for qty in halldetails
        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char qty = e.KeyChar;
            if (!Char.IsDigit(qty) && qty != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }

        private void Txtitemname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }

        }
        //personal details - first name
        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }
        //personal details - last name
        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }
        //personal details - phone number 
        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char phone = e.KeyChar;
            if (!Char.IsDigit(phone) && phone != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MetroLink1_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TxtAddNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtitemNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ML_nxt_Click_1(object sender, EventArgs e)
        {
            new HRS_filter().Show();
            this.Hide();
        }

        private void MetroLink2_Click_1(object sender, EventArgs e)
        {
            new hall_Information_HRS().Show();
            this.Hide();
        }
        //add personal details
        private void BtnPDAdd_Click(object sender, EventArgs e)
        {
            pd.First_name = txtFirstName.Text.Trim().ToString();
            pd.Last_name = txtLastName.Text.Trim().ToString();
            pd.Nic = txtNIC.Text.Trim().ToString();
            pd.Address = txtAddress.Text.Trim().ToString();
            pd.Email = txtEmail.Text.Trim().ToString();
            pd.Phone = txtMobile.Text.Trim().ToString();
            pd.Lang = cmbLang.Text.Trim().ToString();

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtNIC.Text == "" || txtAddress.Text == ""
            || txtEmail.Text == "" || txtMobile.Text == "" || cmbLang.SelectedItem == null)
            {
                MessageBox.Show("fields cannot be null!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                pd.Add();
                dgvPersonalDetails.DataSource = pd.viewSearch();
            }


        }
        //reset personal details
        private void BtnPDReset_Click_1(object sender, EventArgs e)
        {
            txtEmail.Text = txtLastName.Text = txtNIC.Text = txtMobile.Text =
              txtFirstName.Text = txtAddress.Text = cmbLang.Text = "";
            btnDISave.Text = "Save";
            btnDIDel.Enabled = false;
            btnPDAdd.Enabled = true;
        }
        //update personal details
        private void BtnPDUpdate_Click_1(object sender, EventArgs e)
        {
            pd.First_name = txtEmail.Text.Trim().ToString();
            pd.Last_name = txtLastName.Text.Trim().ToString();
            pd.Nic = txtNIC.Text.Trim().ToString();
            pd.Address = txtAddress.Text.Trim().ToString();
            pd.Email = txtFirstName.Text.Trim().ToString();
            pd.Phone = txtMobile.Text.Trim().ToString();
            pd.Lang = cmbLang.Text.Trim().ToString();

            pd.update();
            dgvPersonalDetails.DataSource = pd.viewSearch();
        }
        //double click - personal details
        private void DgvPersonalDetails_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvPersonalDetails.CurrentRow.Index != -1)
            {
                Cus_id = Convert.ToInt32(dgvPersonalDetails.CurrentRow.Cells[0].Value.ToString());
                txtEmail.Text = dgvPersonalDetails.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvPersonalDetails.CurrentRow.Cells[2].Value.ToString();
                txtNIC.Text = dgvPersonalDetails.CurrentRow.Cells[3].Value.ToString();
                cmbLang.Text = dgvPersonalDetails.CurrentRow.Cells[4].Value.ToString();
                txtAddress.Text = dgvPersonalDetails.CurrentRow.Cells[5].Value.ToString();
                txtFirstName.Text = dgvPersonalDetails.CurrentRow.Cells[6].Value.ToString();
                txtMobile.Text = dgvPersonalDetails.CurrentRow.Cells[7].Value.ToString();

            }

            btnPDReset.Enabled = true;
            btnPDAdd.Enabled = true;
            dgvPersonalDetails.Columns[0].Visible = true;
        }
        //validation for first name
        private void TxtFirstName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }
        //validation for last name
        private void TxtLastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }
        //validation for mobile number
        private void TxtMobile_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char phone = e.KeyChar;
            if (!Char.IsDigit(phone) && phone != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //------------------hall details---------------------------
        private void BtnHDAdd_Click(object sender, EventArgs e)
        {
            hd.CusID = txtcusIdHD.Text.Trim().ToString();
            hd.Halltype = hd.Halltype;
            hd.HallName1 = cmbHallName.Text.Trim().ToString();
            hd.Eventtype = cmbEventType.Text.Trim().ToString();
            hd.Date1 = dateTimeHD.Value.ToString();
            hd.Time = txtTime.Text.Trim().ToString();
            hd.AmPm = cmbAmPm.Text.Trim().ToString();
            hd.FoodType = cmbFoodType.Text.Trim().ToString();
            //hd.AdditionalFood = hd.AdditionalFood;
           /* foreach (var checkedItem in this.checkedListBoxAdditionalFoods.CheckedItems)
            {

                hd.AdditionalFood += checkedItem.ToString() + ",";

            }
            hd.AdditionalFood = hd.AdditionalFood.TrimEnd(',');*/



            //hd.Qty = txtQty.Text.Trim().ToString();
            hd.Bar = hd.Bar;
            hd.Status = cmbStatus.Text.Trim().ToString();
            hd.Notes = txtAddNotes.Text.Trim().ToString();


/*            if (txtcusIdHD.Text == "" || hd.Halltype == "" || cmbHallName.SelectedItem == null || cmbEventType.SelectedItem == null
                || txtTime.Text == "" || cmbAmPm.SelectedItem == null || cmbFoodType.SelectedItem == null ||hd.Bar == "" || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Fields cannot be empty!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {*/
                hd.Add();
                dgvHallDetails.DataSource = hd.viewSearch();
            //}

        }

        private void BtnHDUpdate_Click(object sender, EventArgs e)
        {
            hd.CusID = txtcusIdHD.Text.Trim().ToString();
            hd.Halltype = hd.Halltype;
            hd.HallName1 = cmbHallName.Text.Trim().ToString();
            hd.Eventtype = cmbEventType.Text.Trim().ToString();
            hd.Date1 = dateTimeHD.Value.ToString();
            hd.Time = txtTime.Text.Trim().ToString();
            hd.AmPm = cmbAmPm.Text.Trim().ToString();
            hd.FoodType = cmbFoodType.Text.Trim().ToString();
            //hd.AdditionalFood = hd.AdditionalFood;
            //hd.Qty = txtQty.Text.Trim().ToString();
            hd.Bar = hd.Bar;
            hd.Status = cmbStatus.Text.Trim().ToString();
            hd.Notes = txtAddNotes.Text.Trim().ToString();

            hd.update();
            dgvHallDetails.DataSource = hd.viewSearch();
        }

        private void BtnHDReset_Click(object sender, EventArgs e)
        {
            txtcusIdHD.Text = cmbHallName.Text = cmbEventType.Text = txtTime.Text = hd.Halltype = 
             hd.Bar =  cmbAmPm.Text = cmbFoodType.Text = cmbStatus.Text = txtAddNotes.Text = "";

            // clear the checkboxes
           /*if (chkboxaddfood.SelectedIndex != -1)
            {
                chkboxaddfood.SelectedIndex = -1;
            }*/
            //2581504//
            rdBronze.Checked = false;
            rdPremium.Checked = false;
            rdSilver.Checked = false;
            rdBronze.Checked = false;
            rdYes.Checked = false;
            rdNo.Checked = false;

            btnHDAdd.Enabled = true;
        }

        private void DgvHallDetails_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvHallDetails.CurrentRow.Index != -1)
            {
                txtcusIdHD.Text = dgvHallDetails.CurrentRow.Cells[1].Value.ToString();
                cmbHallName.Text = dgvHallDetails.CurrentRow.Cells[2].Value.ToString();
                String HallType = dgvHallDetails.CurrentRow.Cells[3].Value.ToString();
                cmbEventType.Text = dgvHallDetails.CurrentRow.Cells[4].Value.ToString();
                dateTimeHD.Text = dgvHallDetails.CurrentRow.Cells[5].Value.ToString();
                txtTime.Text = dgvHallDetails.CurrentRow.Cells[6].Value.ToString();
                cmbAmPm.Text = dgvHallDetails.CurrentRow.Cells[7].Value.ToString();
                cmbFoodType.Text = dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
                //String addfood = dgvHallDetails.CurrentRow.Cells[10].Value.ToString();
               // txtQty.Text = dgvHallDetails.CurrentRow.Cells[11].Value.ToString();
                String Bar = dgvHallDetails.CurrentRow.Cells[12].Value.ToString();
                cmbStatus.Text = dgvHallDetails.CurrentRow.Cells[8].Value.ToString();
                txtAddNotes.Text = dgvHallDetails.CurrentRow.Cells[13].Value.ToString();

                if (HallType == "Premium")
                {
                    rdPremium.Checked = true;
                }
                else if (HallType == "Gold")
                {
                    rdGold.Checked = true;
                }
                else if (HallType == "Silver")
                {
                    rdSilver.Checked = true;
                }
                else if (HallType == "Bronze")
                {
                    rdBronze.Checked = true;
                }

                if (Bar == "Yes")
                {
                    rdYes.Checked = true;
                }
                else if (Bar == "No")
                {
                    rdNo.Checked = true;
                }

                /*if (chkboxaddfood.SelectedIndex >= 0)
                {
                    addfood = "";
                    foreach (ListViewItem s in chkboxaddfood.Items)
                    {
                        if (s.Selected)
                        {

                            addfood += s + ",";

                        }
                    }
                    addfood = addfood.Substring(0, addfood.Length - 1);
                }
                else
                {
                    addfood = "";
                }*/
            }

            btnHDAdd.Enabled = false;
            btnHDReset.Enabled = true;
            dgvHallDetails.Columns[0].Visible = false;
        }

        private void RdPremium_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Premium";
        }

        private void RdGold_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Gold";
        }

        private void RdSilver_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Silver";
        }

        private void RdBronze_CheckedChanged(object sender, EventArgs e)
        {
            hd.Halltype = "Bronze";
        }

        private void RdYes_CheckedChanged(object sender, EventArgs e)
        {
            hd.Bar = "Yes";
        }

        private void RdNo_CheckedChanged(object sender, EventArgs e)
        {
            hd.Bar = "No";
        }
        //validation for hall details
        private void TxtTime_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char time = e.KeyChar;
            if (!Char.IsDigit(time) && time != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }

        private void TxtcusIdHD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char cusID = e.KeyChar;
            if (!Char.IsDigit(cusID) && cusID != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }

        

        private void TxtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Char qty = e.KeyChar;
            if (!Char.IsDigit(qty) && qty != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //-----------------damaged items-----------------------------
        private void BtnDISave_Click(object sender, EventArgs e)
        {
            if (btnDISave.Text == "ADD")
            {
                di.ItemNo = txtitemNo.Text.Trim().ToString();
                di.ItemName = txtitemname.Text.Trim().ToString();
                di.ItemDes = txtitemdesc.Text.Trim().ToString();
                di.HallDes = txthalldesc.Text.Trim().ToString();

                di.Add();
                dgvDamageItems.DataSource = di.viewSearch();
            }
            else
            {

                di.ItemNo = txtitemNo.Text.Trim().ToString();
                di.ItemName = txtitemname.Text.Trim().ToString();
                di.ItemDes = txtitemdesc.Text.Trim().ToString();
                di.HallDes = txthalldesc.Text.Trim().ToString();

                di.update();
                dgvDamageItems.DataSource = di.viewSearch();
            }
        }

        private void BtnDIDel_Click_1(object sender, EventArgs e)
        {
            di.ItemNo = txtitemNo.Text.Trim().ToString();
            di.ItemName = txtitemname.Text.Trim().ToString();
            di.ItemDes = txtitemdesc.Text.Trim().ToString();
            di.HallDes = txthalldesc.Text.Trim().ToString();

            di.delete();
            dgvDamageItems.DataSource = di.viewSearch();
        }

        private void BtnDIReset_Click(object sender, EventArgs e)
        {
            txtitemNo.Text = txtitemname.Text = txtitemdesc.Text = txthalldesc.Text = "";
            btnDISave.Text = "ADD";
            btnDIDel.Enabled = false;
        }

        private void BtnDISearch_Click(object sender, EventArgs e)
        {
            dgvDamageItems.DataSource = disearch.search(txtSearchDItems.Text.ToString());
        }

        private void DgvDamageItems_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvDamageItems.CurrentRow.Index != -1)
            {
                txtitemNo.Text = dgvDamageItems.CurrentRow.Cells[0].Value.ToString();
                txtitemname.Text = dgvDamageItems.CurrentRow.Cells[1].Value.ToString();
                txtitemdesc.Text = dgvDamageItems.CurrentRow.Cells[2].Value.ToString();
                txthalldesc.Text = dgvDamageItems.CurrentRow.Cells[3].Value.ToString();

                btnDISave.Text = "UPDATE";
                btnDIDel.Enabled = true;
            }
        }

        private void DgvPersonalDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvPersonalDetails_DoubleClick_2(object sender, EventArgs e)
        {
            if (dgvPersonalDetails.CurrentRow.Index != -1)
            {
                Cus_id = Convert.ToInt32(dgvPersonalDetails.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dgvPersonalDetails.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvPersonalDetails.CurrentRow.Cells[2].Value.ToString();
                txtNIC.Text = dgvPersonalDetails.CurrentRow.Cells[3].Value.ToString();
                cmbLang.Text = dgvPersonalDetails.CurrentRow.Cells[4].Value.ToString();
                txtAddress.Text = dgvPersonalDetails.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvPersonalDetails.CurrentRow.Cells[6].Value.ToString();
                txtMobile.Text = dgvPersonalDetails.CurrentRow.Cells[7].Value.ToString();

            }

            btnPDReset.Enabled = true;
            btnPDAdd.Enabled = false;
            dgvPersonalDetails.Columns[0].Visible = true;
        }

        payment paymnet = new payment();
        private void DgvHallDetails_DoubleClick_2(object sender, EventArgs e)
        {
            if (dgvHallDetails.CurrentRow.Index != -1)
            {
                txtcusIdHD.Text = dgvHallDetails.CurrentRow.Cells[1].Value.ToString();
                cmbHallName.Text = dgvHallDetails.CurrentRow.Cells[2].Value.ToString();
                String HallType = dgvHallDetails.CurrentRow.Cells[3].Value.ToString();
                cmbEventType.Text = dgvHallDetails.CurrentRow.Cells[4].Value.ToString();
                dateTimeHD.Text = dgvHallDetails.CurrentRow.Cells[5].Value.ToString();
                txtTime.Text = dgvHallDetails.CurrentRow.Cells[6].Value.ToString();
                cmbAmPm.Text = dgvHallDetails.CurrentRow.Cells[7].Value.ToString();
                cmbFoodType.Text = dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
                //cmbAddFood.Text = dgvHallDetails.CurrentRow.Cells[10].Value.ToString();
                //xtQty.Text = dgvHallDetails.CurrentRow.Cells[11].Value.ToString();
                String Bar = dgvHallDetails.CurrentRow.Cells[10].Value.ToString();
                cmbStatus.Text = dgvHallDetails.CurrentRow.Cells[8].Value.ToString();
                txtAddNotes.Text = dgvHallDetails.CurrentRow.Cells[11].Value.ToString();

                //define variables
                String halltype = dgvHallDetails.CurrentRow.Cells[3].Value.ToString();
                String eventtype = dgvHallDetails.CurrentRow.Cells[4].Value.ToString();
                String foodtype = dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
                String bar = dgvHallDetails.CurrentRow.Cells[10].Value.ToString();

                //amount fields
                txtamtht.Text = (paymnet.halltypeprice(halltype)).ToString();
                txtamtet.Text = (paymnet.etypeprice(eventtype)).ToString();
                txtamtft.Text = (paymnet.foodtypeprice(foodtype)).ToString();
                txtamtbar.Text = (paymnet.barprice(bar)).ToString();

                //categories
                txtcatht.Text = dgvHallDetails.CurrentRow.Cells[3].Value.ToString();
                txtcatet.Text = dgvHallDetails.CurrentRow.Cells[4].Value.ToString();
                txtcatft.Text = dgvHallDetails.CurrentRow.Cells[9].Value.ToString();
                txtcatbar.Text = dgvHallDetails.CurrentRow.Cells[10].Value.ToString();

                txtcusIDPD.Text = dgvHallDetails.CurrentRow.Cells[1].Value.ToString();

                //tot amount
                txttotpay.Text = ((paymnet.halltypeprice(halltype)) + (paymnet.etypeprice(eventtype))
                    + (paymnet.foodtypeprice(foodtype))+ (paymnet.barprice(bar))).ToString();

                

                if (HallType == "Premium")
                {
                    rdPremium.Checked = true;
                }
                else if (HallType == "Gold")
                {
                    rdGold.Checked = true;
                }
                else if (HallType == "Silver")
                {
                    rdSilver.Checked = true;
                }
                else if (HallType == "Bronze")
                {
                    rdBronze.Checked = true;
                }

                if (Bar == "yes")
                {
                    rdYes.Checked = true;
                }
                else if (Bar == "No")
                {
                    rdNo.Checked = true;
                }

            }

            btnHDAdd.Enabled = false;
            btnHDReset.Enabled = true;
            dgvHallDetails.Columns[0].Visible = false;
        }

        private void DgvDamageItems_DoubleClick_2(object sender, EventArgs e)
        {
            if (dgvDamageItems.CurrentRow.Index != -1)
            {
                txtitemNo.Text = dgvDamageItems.CurrentRow.Cells[0].Value.ToString();
                txtitemname.Text = dgvDamageItems.CurrentRow.Cells[1].Value.ToString();
                txtitemdesc.Text = dgvDamageItems.CurrentRow.Cells[2].Value.ToString();
                txthalldesc.Text = dgvDamageItems.CurrentRow.Cells[3].Value.ToString();

                btnDISave.Text = "UPDATE";
                btnDIDel.Enabled = true;
            }
        }

        private void MetroLink1_Click_2(object sender, EventArgs e)
        {
            new HRS_filter().Show();
            this.Hide();
        }

        payment pay = new payment();

        private void Label25_Click(object sender, EventArgs e)
        {
           // txttotpay.Text = pay.getTot(Cus_id, ); 
        }

        private void ComboBox2_Click(object sender, EventArgs e)
        {
        }

        private void Btncal_Click(object sender, EventArgs e)
        {
            //pay.AdvancedPerc2 = int.Parse(cmbadvamount.Text.Trim().ToString());

            //txttotadv.Text = (pay.advamount(pay.AdvancedPerc2, int.Parse(txttotpay.Text.ToString()))).ToString();
            int advamount = 0;

            if (cmbadvamount.Text.Trim().ToString() == "40%")
            {
                advamount = int.Parse(txttotpay.Text) * 40 / 100;
            }
            else if (cmbadvamount.Text.Trim().ToString() == "50%")
            {
                advamount = int.Parse(txttotpay.Text) * 50 / 100;
            }
            else
            {
                advamount = int.Parse(txttotpay.Text) * 60 / 100;
            }

            txttotadv.Text = (advamount).ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        { 
            pay.Cus_id = txtcusIDPD.Text.Trim().ToString();
            pay.TotAmount = txttotpay.Text.Trim().ToString();
            pay.PaymentMode = cmbpaymode.Text.Trim().ToString();
            pay.PaidAmount = txttotadv.Text.Trim().ToString();
            pay.Date1 = datetimeinitpay.Value.ToString();
            pay.Status1 = cmbstatuspay.Text.Trim().ToString();

           
            pay.add();
            

            dgvpendingpay.DataSource = pay.viewPendingPayments();
            dgvpartiallypaidcus.DataSource = pay.viewcutomerpending();

        }

        private void Dgvpendingpay_DoubleClick(object sender, EventArgs e)
        {
            txtcusIdpending.Text = dgvpendingpay.CurrentRow.Cells[1].Value.ToString();
            txtamounttobepaid.Text = (int.Parse(dgvpendingpay.CurrentRow.Cells[4].Value.ToString())-
                int.Parse(dgvpendingpay.CurrentRow.Cells[5].Value.ToString())).ToString();
        }

        private void BtndemoPD_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Hansani";
            txtLastName.Text = "Vichalya";
            txtNIC.Text = "978254130V";
            txtAddress.Text = "Nugegoda";
            txtEmail.Text = "hansani@gmail.com";
            txtMobile.Text = "0775544651";
            cmbLang.Text = "Sinhala";
        }

        private void BtndemoHD_Click(object sender, EventArgs e)
        {
            txtcusIdHD.Text = "1045";
            rdGold.Checked = true;
            cmbHallName.Text = "Violet";
            cmbEventType.Text = "Weddings";
            txtTime.Text = "1500";
            cmbAmPm.Text = "pm";
            cmbFoodType.Text = "Gold";
            rdNo.Checked = true;
            cmbStatus.Text = "reserved";
            txtAddNotes.Text = "Need the hall before 1200 pm";

        }

        private void Button2_Click_3(object sender, EventArgs e)
        {

            cmbpaymode.Text = "By Cash";
            cmbadvamount.Text = "40%";
            cmbstatuspay.Text = "Pending";
        }

        private void Btnpaidpay_Click(object sender, EventArgs e)
        {
            pay.Cus_id = txtcusIdpending.Text.Trim().ToString();
            pay.ResAmount = txtamounttobepaid.Text.Trim().ToString();
            pay.CompletedDate = datetimecompleted.Value.ToString();
            pay.Status1 = "Completed";

            pay.updateCompletedDetails();
            dgvpendingpay.DataSource = pay.viewPendingPayments();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-QUA6BDC\SQLEXPRESS;Initial Catalog=Blue_Lotus_Hotel;Integrated Security=True");

        /*public void filterCompleteCustomerDataGrid()
        {

            DBConnection.OpenDBConnection();
            SqlDataAdapter sqlda = new SqlDataAdapter("completeCusFilter", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlda.SelectCommand.Parameters.AddWithValue("@reservedDate", dateTimereserved.Value.ToString());

            DataTable dtbl = new DataTable();

            sqlda.Fill(dtbl);
            dgvpartiallypaidcus.DataSource = dtbl;

            DBConnection.CloseDBConnection();

        }*/

        private void BtnsearchResv_Click(object sender, EventArgs e)
        {
            //filterCompleteCustomerDataGrid();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            txtitemNo.Text = "B001";
            txtitemname.Text = "Cupboard";
            txtitemdesc.Text = "Broken";
            txthalldesc.Text = "Hall Anemone";
        }

        private void Dgvcompletedcustomer_DoubleClick(object sender, EventArgs e)
        {
            //txtdeletecus.Text = dgvcompletedcustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnsaveRep_Click(object sender, EventArgs e)
        {


            HRSreportForm hRSreportForm = new HRSreportForm(datetimereportstart.Text, satetimereportend.Text);
            hRSreportForm.Show();
        }
        /* private void CheckedListBoxAdditionalFoods_SelectedIndexChanged(object sender, EventArgs e)
{
if (chkboxaddfood.SelectedIndex >= 0)
{
string state1 = "";
foreach (ListItem s in chkboxaddfood.Items)
{
if (s.Selected)
{

state1 += s + ",";

}
}
state1 = state1.Substring(0, state1.Length - 1);

hd.AdditionalFood = (state1);



}
else
{
hd.AdditionalFood = "";
}
}

/* string strCheckValue = "";

if (chk.Checked)

{

strCheckValue = strCheckValue + "," + chk1.Text;

}

if (chk2.Checked)

{

strCheckValue = strCheckValue + "," + chk2.Text;

}

strCheckValue = strCheckValue.TrimStart(',');*/
    }

     /*   private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "Cutlets";
        }

        private void Chkbocrolls_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "Chinese Rolls";
        }

        private void Chkboxpatties_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "Patties";
        }

        private void Chkboxnuts_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "Cashew Nuts";
        }

        private void Chkboxcheese_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "Cheese";
        }

        private void Chkboxfries_CheckedChanged(object sender, EventArgs e)
        {
            hd.AdditionalFood = "French Fries";
        }
    }*/
}
