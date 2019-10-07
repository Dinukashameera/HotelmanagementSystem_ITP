using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hall_Reservation
{
    public partial class hall_Information_HRS : MetroFramework.Forms.MetroForm
    {
        public hall_Information_HRS()
        {
            InitializeComponent();
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.HRS_BLH_EventType' table. You can move, or remove it, as needed.
           // this.hRS_BLH_EventTypeTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.HRS_BLH_EventType);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.HRS_BLH_HallType' table. You can move, or remove it, as needed.
           // this.hRS_BLH_HallTypeTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.HRS_BLH_HallType);
            // TODO: This line of code loads data into the 'blue_Lotus_HotelDataSet1.HRS_BLH_hall' table. You can move, or remove it, as needed.
           // this.hRS_BLH_hallTableAdapter.Fill(this.blue_Lotus_HotelDataSet1.HRS_BLH_hall);

            dgvHallType.DataSource = ht.viewSearch();
            dgvEventType.DataSource = ht.viewSearch();

        }

        HallType ht = new HallType();
        private void Button2_Click(object sender, EventArgs e)
        {
            
                ht.HallType1 = txtHallType.Text.Trim().ToString();
                ht.Price = double.Parse(txtPrice.Text.Trim().ToString());
                ht.Description = txtDescription.Text.Trim().ToString();

                ht.Update();
                dgvHallType.DataSource = ht.viewSearch();
            
        }

        EventType et = new EventType();
        private void Button5_Click(object sender, EventArgs e)
        {
            et.EventType1 = txtEventType.Text.Trim().ToString();
            et.Price = double.Parse(txtPrice2.Text.Trim().ToString());
            et.Description = txtDescription2.Text.Trim().ToString();

            et.Add();
        }

        private void MetroTabControl1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvHallType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //delete
        private void BtnDelHT_Click(object sender, EventArgs e)
        {
            ht.HallType1 = txtHallType.Text.Trim().ToString();
            ht.Price = double.Parse(txtPrice.Text.Trim().ToString());
            ht.Description = txtDescription.Text.Trim().ToString();

            ht.delete();
            dgvHallType.DataSource = ht.viewSearch();
        }
        //reset
        private void BtnResetHT_Click(object sender, EventArgs e)
        {
            txtHallType.Text = txtPrice.Text = txtDescription.Text = "";
            btnAddHT.Text = "ADD";
            btnDelHT.Enabled = false;
        }

        private void DgvHallType_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHallType.CurrentRow.Index != -1)
            {
                txtHallType.Text = dgvHallType.CurrentRow.Cells[0].Value.ToString();
                txtPrice.Text = dgvHallType.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvHallType.CurrentRow.Cells[2].Value.ToString();

                btnAddHT.Text = "UPDATE";
                btnDelHT.Enabled = true;
                btnResetHT.Enabled = true;

            }
        }

        private void DgvEventType_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEventType.CurrentRow.Index != -1)
            {
                txtEventType.Text = dgvEventType.CurrentRow.Cells[0].Value.ToString();
                txtPrice2.Text = dgvEventType.CurrentRow.Cells[1].Value.ToString();
                txtDescription2.Text = dgvEventType.CurrentRow.Cells[2].Value.ToString();

              
                btnDelET.Enabled = true;
                btnResetET.Enabled = true;
                btnAddET.Enabled = true;
            }
        }
        //add
        private void BtnAddET_Click(object sender, EventArgs e)
        {
            if (txtEventType.Text == "" || txtPrice2.Text == "" || txtDescription2.Text == "")
            {
                MessageBox.Show("Fields cannot be null!", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                et.EventType1 = txtEventType.Text.Trim().ToString();
                et.Price = double.Parse(txtPrice2.Text.Trim().ToString());
                et.Description = txtDescription2.Text.Trim().ToString();

                et.Add();
                dgvEventType.DataSource = et.viewSearch();

            }
        }
        //delete
        private void BtnDelET_Click(object sender, EventArgs e)
        {
            et.EventType1 = txtEventType.Text.Trim().ToString();
            et.Price = double.Parse(txtPrice2.Text.Trim().ToString());
            et.Description = txtDescription2.Text.Trim().ToString();

            et.delete();
            dgvEventType.DataSource = et.viewSearch();
        }
        //reset
        private void BtnResetET_Click(object sender, EventArgs e)
        {
            txtEventType.Text = txtPrice2.Text = txtDescription2.Text = "";
            btnAddET.Text = "ADD";
            btnDelET.Enabled = false;
            btnAddET.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            et.EventType1 = txtEventType.Text.Trim().ToString();
            et.Price = double.Parse(txtPrice2.Text.Trim().ToString());
            et.Description = txtDescription2.Text.Trim().ToString();

            et.Update();
            dgvEventType.DataSource = et.viewSearch();
        }

        //price - hall type
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char price= e.KeyChar;
            if (!Char.IsDigit(price) && price != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //price - event type
        private void TxtPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char price = e.KeyChar;
            if (!Char.IsDigit(price) && price != 8)
            {
                e.Handled = true;
                MessageBox.Show("Letters are not allowed!");
            }
        }
        //hall type - hall type 
        private void TxtHallType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }
        //event type - event type
        private void TxtEventType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't use numerical values here!", "error!", MessageBoxButtons.OK);
            }
        }

        private void TxtPrice2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvHallType_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvHallType.CurrentRow.Index != -1)
            {
                txtHallType.Text = dgvHallType.CurrentRow.Cells[0].Value.ToString();
                txtPrice.Text = dgvHallType.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvHallType.CurrentRow.Cells[2].Value.ToString();

                btnAddHT.Text = "UPDATE";
                btnDelHT.Enabled = true;
                btnResetHT.Enabled = true;

            }
        }

        private void DgvEventType_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvEventType.CurrentRow.Index != -1)
            {
                txtEventType.Text = dgvEventType.CurrentRow.Cells[0].Value.ToString();
                txtPrice2.Text = dgvEventType.CurrentRow.Cells[1].Value.ToString();
                txtDescription2.Text = dgvEventType.CurrentRow.Cells[2].Value.ToString();


                btnDelET.Enabled = true;
                btnResetET.Enabled = true;
                btnAddET.Enabled = false;
            }
        }

        private void MetroLink2_Click(object sender, EventArgs e)
        {
            new HRS_MAIN().Show();
            this.Hide();
        }

        private void BtndemoHT_Click(object sender, EventArgs e)
        {

            txtHallType.Text = "Gold";
            txtPrice.Text = "450000";
            txtDescription.Text = "350 seats available for this hall";
        }

        private void BtndemoET_Click(object sender, EventArgs e)
        {
            txtEventType.Text = "Meetings";
            txtPrice2.Text = "75000";
            txtDescription2.Text = "75000/= will be added to the hall price";
        }
    }
}
