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
    public partial class Food_Menu : MetroFramework.Forms.MetroForm
    {
        public Double menuVal;

        private SqlConnection sqlCon = DBConnection.getConnection();
        public Food_Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton91_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton253_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton356_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox71.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void RadioButton171_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox152_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox156_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox186_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox224_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox231_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GroupBox125_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox227_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void CheckBox243_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox356_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox356.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox362_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox362.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox370_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox370.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckedListBox27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox565_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox565.Checked == true)
            {
                groupBox18.Visible = true;
                txtTot.Text = (30 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                groupBox18.Visible = false;
                txtTot.Text = (Double.Parse(txtTot.Text) - 30).ToString();
            }
        }

        private void CheckBox564_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox564.Checked == true)
            {
                groupBox11.Visible = true;
                txtTot.Text = (40 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                groupBox11.Visible = false;
                txtTot.Text = (Double.Parse(txtTot.Text) - 40).ToString();
            }
        }

        private void CheckBox563_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox563.Checked == true)
            {
                
                groupBox10.Visible = true;

                
                txtTot.Text = (50 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                groupBox10.Visible = false;
                txtTot.Text = (Double.Parse(txtTot.Text) - 50).ToString();
                
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                txtTot.Text = (5 + Double.Parse(txtTot.Text)).ToString();
            }
            else
            {
                txtTot.Text = (Double.Parse(txtTot.Text) - 5).ToString();
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Chck_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                // The indexChecked variable contains the index of the item.
                MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                                checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            }

            // Next show the object title and check state for each item selected.
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                // Use the IndexOf method to get the index of an item.
                MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
                                "\", is checked. Checked state is: " +
                                checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
            }
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (checkedListBox1.SelectedIndex == 0)
            {
                
                if (e.NewValue == CheckState.Checked)
                {
                    
                    MessageBox.Show("Select color");
                    clrRice.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    clrRice.Visible = false;
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }


            }



            if (checkedListBox1.SelectedIndex == 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select a bread type");
                    brdType.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                   brdType.Visible = false;
                   txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }
            if (checkedListBox1.SelectedIndex == 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type of stringhopper");
                    clrStrnghpr.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    clrStrnghpr.Visible = false;
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }

            if (checkedListBox1.SelectedIndex == 3)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type of rice");
                    typeRice.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    typeRice.Visible = false;
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }

            if (checkedListBox1.SelectedIndex == 4)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }
            if (checkedListBox1.SelectedIndex == 5)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }
            if (checkedListBox1.SelectedIndex == 6)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type of roti");
                    typeRoti.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    typeRoti.Visible = false;
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }
            }

            if (checkedListBox1.SelectedIndex == 7)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type of hoppers");
                    typeHpprs.Visible = true;
                    txtSub.Text = (30 + Double.Parse(txtSub.Text)).ToString();
                }
                else
                {
                    typeHpprs.Visible = false;
                    txtSub.Text = (Double.Parse(txtSub.Text) - 30).ToString();
                }

            }
        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void TypeRice_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void CheckBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                txtSub.Text = (5 + Double.Parse(txtSub.Text)).ToString();
            }
            else
            {
                txtSub.Text = (Double.Parse(txtSub.Text) - 5).ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtBTot.Text = (Double.Parse(txtBTot.Text) + Double.Parse(txtTot.Text)).ToString();
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
          
                string message = "Confirm to submit";
                string title = "Confirmattion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtBTot.Text = (Double.Parse(txtBTot.Text) + Double.Parse(txtSub.Text)).ToString();
            }

            
        }

        private void CheckedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ClrRice_Enter(object sender, EventArgs e)
        {

        }

        private void TxtSub_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0) {
                for (int i = checkedListBox1.CheckedItems.Count; i > 0; i--) {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[i - 1]);
                }
            }
            else {
                MessageBox.Show("Select items");
            }
        }

        private void CheckBox576_CheckedChanged(object sender, EventArgs e)
        {
            if (spicyChicken.Checked == true)
            {

                
                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {
                
                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void ChickenDo_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenDo.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void Kolhapuri_CheckedChanged(object sender, EventArgs e)
        {
            if (kolhapuri.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox570_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox570.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox573_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox573.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox571_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox571.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox574_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox574.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox572_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox572.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox575_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox575.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox566_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox566.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox567_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox567.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void GroupBox28_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox568_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox568.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox569_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox569.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox567.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox568.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox75.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox76.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox83.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox84_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox84.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox85.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox86.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox69.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox70.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox72.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox73.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox74.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox77.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox78.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox79.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox80.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox81_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox81.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void CheckBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox82.Checked == true)
            {


                txtbpc.Text = (30 + Double.Parse(txtbpc.Text)).ToString();
            }
            else
            {

                txtbpc.Text = (Double.Parse(txtbpc.Text) - 30).ToString();
            }
        }

        private void BtnbpcSubmit_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtBTot.Text = (Double.Parse(txtBTot.Text) + Double.Parse(txtbpc.Text)).ToString();
            }
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (txtSub.Text.Trim().Length != 0)
            {
                checkedListBox1.Items.Add(txtSub.Text);
                txtSub.Text = "0";
            }
            else
            {
                MessageBox.Show("Enter a value");
            }
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    lblMeals.Text += item + ",";
                }

                if (checkBox32.Checked == true)
                {
                    lblMeals.Text += ", Color of rice =" + checkBox32.Text + ",";
                }

                if (checkBox33.Checked == true)
                {
                    lblMeals.Text += ", Color of rice =" + checkBox33.Text + ",";
                }

                if (checkBox34.Checked == true)
                {
                    lblMeals.Text += ", Color of string hoppers =" + checkBox34.Text + ",";
                }

                if (checkBox35.Checked == true)
                {
                    lblMeals.Text += ", Color of string hoppers =" + checkBox35.Text + ",";
                }

                if (checkBox36.Checked == true)
                {
                    lblMeals.Text += ", Type of rice =" + checkBox36.Text + ",";
                }

                if (checkBox37.Checked == true)
                {
                    lblMeals.Text += ", Type of rice =" + checkBox37.Text + ",";
                }

                if (checkBox39.Checked == true)
                {
                    lblMeals.Text += ", Type of bread =" + checkBox39.Text + ",";
                }

                if (checkBox42.Checked == true)
                {
                    lblMeals.Text += ", Type of bread =" + checkBox42.Text + ",";
                }

                if (checkBox38.Checked == true)
                {
                    lblMeals.Text += ", Type of hoppers =" + checkBox38.Text + ",";
                }

                if (checkBox40.Checked == true)
                {
                    lblMeals.Text += ", Type of hoppers =" + checkBox40.Text + ",";
                }

                if (checkBox41.Checked == true)
                {
                    lblMeals.Text += ", Type of hoppers =" + checkBox41.Text + ",";
                }

                if (checkBox43.Checked == true)
                {
                    lblMeals.Text += ", Type of roti =" + checkBox43.Text + ",";
                }

                if (checkBox44.Checked == true)
                {
                    lblMeals.Text += ", Type of roti =" + checkBox44.Text + ",";
                }

                if (checkBox45.Checked == true)
                {
                    lblMeals.Text += ", Type of roti =" + checkBox45.Text + ",";
                }

                if (checkBox46.Checked == true)
                {
                    lblMeals.Text += ", Type of roti =" + checkBox46.Text + ",";
                }

                if (checkBox47.Checked == true)
                {
                    lblMeals.Text += ", Type of roti =" + checkBox47.Text + ",";
                }

                if (checkBox565.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox1.Text + ",";
                    }
                    if (checkBox2.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox2.Text + ",";
                    }
                    if (checkBox3.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox3.Text + ",";
                    }
                    if (checkBox4.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox4.Text + ",";
                    }
                    if (checkBox5.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox5.Text + ",";
                    }
                    if (checkBox6.Checked == true)
                    {
                        lblBPtea.Text += "., Type of nescafe =" + checkBox7.Text + ",";
                    }
                }

                if (checkBox564.Checked == true)
                {
                    if (checkBox8.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox8.Text + ",";
                    }
                    if (checkBox9.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox9.Text + ",";
                    }
                    if (checkBox10.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox10.Text + ",";
                    }
                    if (checkBox11.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox11.Text + ",";
                    }
                }

                if (checkBox563.Checked == true)
                {
                    if (checkBox12.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox12.Text + ",";
                    }
                    if (checkBox13.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox13.Text + ",";
                    }
                    if (checkBox14.Checked == true)
                    {
                        lblBPtea.Text += "., Type of tea =" + checkBox14.Text + ",";
                    }

                }

                if (spicyChicken.Checked == true)
                {
                    lblBCurries.Text += "., Type of chicken curry =" + spicyChicken.Text + ",";
                }

                if (chickenDo.Checked == true)
                {
                    lblBCurries.Text += "., Type of chicken curry =" + chickenDo.Text + ",";
                }

                if (kolhapuri.Checked == true)
                {
                    lblBCurries.Text += "., Type of chicken curry =" + kolhapuri.Text + ",";
                }

                if (checkBox570.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox570.Text + ",";
                }

                if (checkBox571.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox571.Text + ",";
                }

                if (checkBox572.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox572.Text + ",";
                }

                if (checkBox573.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox573.Text + ",";
                }

                if (checkBox574.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox574.Text + ",";
                }

                if (checkBox575.Checked == true)
                {
                    lblBCurries.Text += "., Type of egg curry =" + checkBox575.Text + ",";
                }

                if (checkBox566.Checked == true)
                {
                    lblBCurries.Text += "., Type of fish curry =" + checkBox566.Text + ",";
                }

                if (checkBox567.Checked == true)
                {
                    lblBCurries.Text += "., Type of fish curry =" + checkBox567.Text + ",";
                }

                if (checkBox568.Checked == true)
                {
                    lblBCurries.Text += "., Type of fish curry =" + checkBox568.Text + ",";
                }

                if (checkBox569.Checked == true)
                {
                    lblBCurries.Text += "., Type of fish curry =" + checkBox569.Text + ",";
                }

                if (checkBox67.Checked == true)
                {
                    lblBCurries.Text += "., Type of dhal curry =" + checkBox67.Text + ",";
                }

                if (checkBox68.Checked == true)
                {
                    lblBCurries.Text += "., Type of dhal curry =" + checkBox68.Text + ",";
                }

                if (checkBox75.Checked == true)
                {
                    lblBCurries.Text += "., Type of jam =" + checkBox75.Text + ",";
                }

                if (checkBox76.Checked == true)
                {
                    lblBCurries.Text += "., Type of jam =" + checkBox76.Text + ",";
                }

                if (checkBox83.Checked == true)
                {
                    lblBCurries.Text += "., Type of potatoe curry =" + checkBox83.Text + ",";
                }

                if (checkBox84.Checked == true)
                {
                    lblBCurries.Text += "., Type of potatoe curry =" + checkBox84.Text + ",";
                }

                if (checkBox85.Checked == true)
                {
                    lblBCurries.Text += "., Type of potatoe curry =" + checkBox85.Text + ",";
                }

                if (checkBox86.Checked == true)
                {
                    lblBCurries.Text += "., Type of potatoe curry =" + checkBox86.Text + ",";
                }

                if (checkBox69.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox69.Text + ",";
                }

                if (checkBox70.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox70.Text + ",";
                }

                if (checkBox71.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox71.Text + ",";
                }

                if (checkBox72.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox72.Text + ",";
                }

                if (checkBox73.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox73.Text + ",";
                }

                if (checkBox74.Checked == true)
                {
                    lblBCurries.Text += "., Type of sambol =" + checkBox74.Text + ",";
                }

                if (checkBox77.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox77.Text + ",";
                }

                if (checkBox78.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox78.Text + ",";
                }

                if (checkBox79.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox79.Text + ",";
                }

                if (checkBox80.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox80.Text + ",";
                }

                if (checkBox81.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox81.Text + ",";
                }

                if (checkBox82.Checked == true)
                {
                    lblBCurries.Text += "., Type of soup =" + checkBox82.Text + ",";
                }



                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("breakfast", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", "Platinum");
                    sqlCmd.Parameters.AddWithValue("@tea", lblBPtea.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", lblBCurries.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@price", txtBTot.Text.Trim());


                    sqlCmd.Parameters.AddWithValue("@meal", lblMeals.Text);




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
            
            
            //loop for displaying checked box

            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    // The indexChecked variable contains the index of the item.
            //    MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
            //                    checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            //}

            //// Next show the object title and check state for each item selected.
            //foreach (object itemChecked in checkedListBox1.CheckedItems)
            //{

            //    // Use the IndexOf method to get the index of an item.
            //    MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
            //                    "\", is checked. Checked state is: " +
            //                    checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
            //}

        

        private void BtnGrndSbmt_Click(object sender, EventArgs e)
        {
            menuVal = double.Parse(txtBTot.Text);
            
        }

        private void TxtBTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox19_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox19.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu items");
                    groupBox114.Visible = true;
                    txtlsmeal.Text = (30 + Double.Parse(txtlsmeal.Text)).ToString();
                }
                else
                {
                    groupBox114.Visible = false;
                    txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 30).ToString();
                }


            }



            if (checkedListBox19.SelectedIndex == 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu items");
                    groupBox137.Visible = true;
                    txtlsmeal.Text = (30 + Double.Parse(txtlsmeal.Text)).ToString();
                }
                else
                {
                    groupBox137.Visible = false;
                    txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 30).ToString();
                }
            }
            if (checkedListBox19.SelectedIndex == 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu items");
                    groupBox94.Visible = true;
                    txtlsmeal.Text = (30 + Double.Parse(txtlsmeal.Text)).ToString();
                }
                else
                {
                    groupBox94.Visible = false;
                    txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 30).ToString();
                }
            }
        }

        private void CheckBox212_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox212.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox211_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox211.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox207_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox207.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox208_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox208.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox209_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox209.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox210_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox210.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox201_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox201.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

  

        private void CheckBox206_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox206.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox204_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox204.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox199_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox109.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox205_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox205.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox202_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox202.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox200_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox200.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox221_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox221.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox219_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox219.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox222_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox222.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox220_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox220.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox214_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox214.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox216_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox216.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox213_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox213.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox215_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox215.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox218_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox218.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox217_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox217.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckBox203_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox203.Checked == true)
            {
                txtlsmeal.Text = (5 + Double.Parse(txtlsmeal.Text)).ToString();
            }
            else
            {
                txtlsmeal.Text = (Double.Parse(txtlsmeal.Text) - 5).ToString();
            }
        }

        private void CheckedListBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox22_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox22.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select types");
                    groupBox131.Visible = true;
                    txtlstea.Text = (30 + Double.Parse(txtlstea.Text)).ToString();
                }
                else
                {
                    groupBox131.Visible = false;
                    txtlstea.Text = (Double.Parse(txtlstea.Text) - 30).ToString();
                }


            }



            if (checkedListBox22.SelectedIndex == 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu items");
                    groupBox133.Visible = true;
                    txtlstea.Text = (30 + Double.Parse(txtlstea.Text)).ToString();
                }
                else
                {
                    groupBox133.Visible = false;
                    txtlstea.Text = (Double.Parse(txtlstea.Text) - 30).ToString();
                }
            }
            if (checkedListBox22.SelectedIndex == 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu items");
                    groupBox132.Visible = true;
                    txtlstea.Text = (30 + Double.Parse(txtlstea.Text)).ToString();
                }
                else
                {
                    groupBox132.Visible = false;
                    txtlstea.Text = (Double.Parse(txtlstea.Text) - 30).ToString();
                }
            }
        }

        private void CheckBox323_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox323.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox321_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox321.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox322_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox322.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox336_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox336.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox335_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox335.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox334_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox334.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox324_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox324.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckBox333_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox333.Checked == true)
            {
                txtlstea.Text = (5 + Double.Parse(txtlstea.Text)).ToString();
            }
            else
            {
                txtlstea.Text = (Double.Parse(txtlstea.Text) - 5).ToString();
            }
        }

        private void CheckedListBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox20_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox20.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select types");
                    groupBox125.Visible = true;
                    txtlsbev.Text = (30 + Double.Parse(txtlsbev.Text)).ToString();
                }
                else
                {
                    groupBox125.Visible = false;
                    txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 30).ToString();
                }


            }



            if (checkedListBox20.SelectedIndex == 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu items");
                    groupBox124.Visible = true;
                    txtlsbev.Text = (30 + Double.Parse(txtlsbev.Text)).ToString();
                }
                else
                {
                    groupBox124.Visible = false;
                    txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 30).ToString();
                }
            }
        }

        private void CheckBox303_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox303.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox307_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox307.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox305_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox305.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox304_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox304.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox306_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox306.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox302_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox302.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox308_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox308.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox297_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox297.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox300_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox300.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox299_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox299.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox298_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox298.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox281_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox281.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox296_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox296.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox301_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox301.Checked == true)
            {
                txtlsbev.Text = (5 + Double.Parse(txtlsbev.Text)).ToString();
            }
            else
            {
                txtlsbev.Text = (Double.Parse(txtlsbev.Text) - 5).ToString();
            }
        }

        private void CheckBox229_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox229.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckBox238_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox238.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckBox236_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox236.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckBox235_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox235.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckBox239_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox239.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckBox237_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox237.Checked == true)
            {
                txtlsadd.Text = (5 + Double.Parse(txtlsadd.Text)).ToString();
            }
            else
            {
                txtlsadd.Text = (Double.Parse(txtlsadd.Text) - 5).ToString();
            }
        }

        private void CheckedListBox21_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox21.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    
                    txtlsdess.Text = (30 + Double.Parse(txtlsdess.Text)).ToString();
                }
                else
                {                    
                    txtlsdess.Text = (Double.Parse(txtlsdess.Text) - 30).ToString();
                }


            }

            if (checkedListBox21.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    
                    txtlsdess.Text = (30 + Double.Parse(txtlsdess.Text)).ToString();
                }
                else
                {
                    txtlsdess.Text = (Double.Parse(txtlsdess.Text) - 30).ToString();
                }


            }

            if (checkedListBox21.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    
                    txtlsdess.Text = (30 + Double.Parse(txtlsdess.Text)).ToString();
                }
                else
                {
                    txtlsdess.Text = (Double.Parse(txtlsdess.Text) - 30).ToString();
                }


            }

            if (checkedListBox21.SelectedIndex == 3)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select types");
                    groupBox127.Visible = true;
                    txtlsdess.Text = (30 + Double.Parse(txtlsdess.Text)).ToString();
                }
                else
                {
                    groupBox127.Visible = false;
                    txtlsdess.Text = (Double.Parse(txtlsdess.Text) - 30).ToString();
                }


            }




        }

        private void Btnlsmeal_Click(object sender, EventArgs e)
        {

            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtlsTot.Text = (Double.Parse(txtlsmeal.Text) + Double.Parse(txtlstea.Text) + Double.Parse(txtlsbev.Text) + Double.Parse(txtlsadd.Text) + Double.Parse(txtlsdess.Text)).ToString();
            }
        }

        private void Btnlstea_Click(object sender, EventArgs e)
        {

            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtlsTot.Text = (Double.Parse(txtlsmeal.Text) + Double.Parse(txtlstea.Text) + Double.Parse(txtlsbev.Text) + Double.Parse(txtlsadd.Text) + Double.Parse(txtlsdess.Text)).ToString();
            }
        }

        private void Btnlsbev_Click(object sender, EventArgs e)
        {

            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtlsTot.Text = (Double.Parse(txtlsmeal.Text) + Double.Parse(txtlstea.Text) + Double.Parse(txtlsbev.Text) + Double.Parse(txtlsadd.Text) + Double.Parse(txtlsdess.Text)).ToString();
            }
        }

        private void Btnlsadd_Click(object sender, EventArgs e)
        {

            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtlsTot.Text = (Double.Parse(txtlsmeal.Text) + Double.Parse(txtlstea.Text) + Double.Parse(txtlsbev.Text) + Double.Parse(txtlsadd.Text) + Double.Parse(txtlsdess.Text)).ToString();
            }
        }

        private void Btnlsdess_Click(object sender, EventArgs e)
        {

            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtlsTot.Text = (Double.Parse(txtlsmeal.Text) + Double.Parse(txtlstea.Text) + Double.Parse(txtlsbev.Text) + Double.Parse(txtlsadd.Text) + Double.Parse(txtlsdess.Text)).ToString();
            }
        }

        private void Button2_Click_3(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (string item in checkedListBox19.CheckedItems)
                {
                    lbllsMeal.Text += item + ",";
                }

                foreach (string item in checkedListBox22.CheckedItems)
                {
                    lbllsTea.Text += item + ",";
                }

                foreach (string item in checkedListBox22.CheckedItems)
                {
                    lbllsBev.Text += item + ",";
                }

                foreach (string item in checkedListBox21.CheckedItems)
                {
                    lbllsDess.Text += item + ",";
                }

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("lunchMod", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", "Silver");
                    sqlCmd.Parameters.AddWithValue("@tea", lbllsTea.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", "chicken,fish");
                    sqlCmd.Parameters.AddWithValue("@dessert", lbllsDess.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@price", txtlsTot.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", lbllsBev.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@meal", lbllsMeal.Text);




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

        private void CheckedListBox11_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox11.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu");
                    groupBox98.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox98.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }
            if (checkedListBox11.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type of bread");
                    groupBox90.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox90.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }

            if (checkedListBox11.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type");
                    groupBox91.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox91.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }

            if (checkedListBox11.SelectedIndex == 3)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type");
                    groupBox89.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox89.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }

            if (checkedListBox11.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type");
                    groupBox86.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox86.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }

            if (checkedListBox11.SelectedIndex == 5)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type");
                    groupBox85.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox85.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }

            if (checkedListBox11.SelectedIndex == 6)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select type");
                    groupBox87.Visible = true;
                    textBox29.Text = (30 + Double.Parse(textBox29.Text)).ToString();
                }
                else
                {
                    groupBox87.Visible = false;
                    textBox29.Text = (Double.Parse(textBox29.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /**----------------------------------- newly added 9.23.19 -------------------------**/

        private void CheckedListBox13_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox13.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox179.Visible = true;
                    textBox32.Text = (30 + Double.Parse(textBox32.Text)).ToString();
                }
                else
                {
                    groupBox179.Visible = false;
                    textBox32.Text = (Double.Parse(textBox32.Text) - 30).ToString();
                }


            }

            if (checkedListBox13.SelectedIndex == 6)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox104.Visible = true;
                    textBox32.Text = (30 + Double.Parse(textBox32.Text)).ToString();
                }
                else
                {
                    groupBox104.Visible = false;
                    textBox32.Text = (Double.Parse(textBox32.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox14_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox14.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox109.Visible = true;
                    textBox33.Text = (30 + Double.Parse(textBox33.Text)).ToString();
                }
                else
                {
                    groupBox109.Visible = false;
                    textBox33.Text = (Double.Parse(textBox33.Text) - 30).ToString();
                }


            }

            if (checkedListBox14.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox151.Visible = true;
                    textBox33.Text = (30 + Double.Parse(textBox33.Text)).ToString();
                }
                else
                {
                    groupBox151.Visible = false;
                    textBox33.Text = (Double.Parse(textBox33.Text) - 30).ToString();
                }


            }

            if (checkedListBox14.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox111.Visible = true;
                    textBox33.Text = (30 + Double.Parse(textBox33.Text)).ToString();
                }
                else
                {
                    groupBox111.Visible = false;
                    textBox33.Text = (Double.Parse(textBox33.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox12_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox12.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox103.Visible = true;
                    textBox30.Text = (30 + Double.Parse(textBox30.Text)).ToString();
                }
                else
                {
                    groupBox103.Visible = false;
                    textBox30.Text = (Double.Parse(textBox30.Text) - 30).ToString();
                }


            }

            if (checkedListBox12.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select flavor");
                    groupBox102.Visible = true;
                    textBox30.Text = (30 + Double.Parse(textBox30.Text)).ToString();
                }
                else
                {
                    groupBox102.Visible = false;
                    textBox30.Text = (Double.Parse(textBox30.Text) - 30).ToString();
                }


            }
        }

        private void CheckBox354_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox354.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox355_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox355.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox367_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox367.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox368_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox368.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox341_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox341.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox342_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox342.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox343_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox343.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox344_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox344.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox345_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox345.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox346_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox346.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox347_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox347.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox348_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox348.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox349_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox349.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox350_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox350.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox352_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox352.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox351_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox351.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox353_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox353.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox337_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox337.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox338_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox338.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox364_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox364.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox363_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox363.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox366_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox366.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox361_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox361.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox365_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox365.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox359_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox359.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox357_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox357.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox358_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox358.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox360_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox360.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox339_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox339.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox340_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox340.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox369_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox369.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox371_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox371.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox373_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox373.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox372_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox372.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox374_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox374.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox375_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox375.Checked == true)
            {
                textBox29.Text = (5 + Double.Parse(textBox29.Text)).ToString();
            }
            else
            {
                textBox29.Text = (Double.Parse(textBox29.Text) - 5).ToString();
            }
        }

        private void CheckBox535_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox355.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox536_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox356.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox537_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox537.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox538_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox538.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox533_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox533.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox534_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox534.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox530_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox530.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox531_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox531.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox532_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox532.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox528_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox528.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox529_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox529.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox527_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox527.Checked == true)
            {
                textBox32.Text = (5 + Double.Parse(textBox32.Text)).ToString();
            }
            else
            {
                textBox32.Text = (Double.Parse(textBox32.Text) - 5).ToString();
            }
        }

        private void CheckBox429_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox429.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox431_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox431.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox430_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox430.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox432_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox432.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox433_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox433.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox434_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox434.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox435_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox435.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox436_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox436.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox437_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox437.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox438_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox438.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox439_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox439.Checked == true)
            {
                textBox33.Text = (5 + Double.Parse(textBox33.Text)).ToString();
            }
            else
            {
                textBox33.Text = (Double.Parse(textBox33.Text) - 5).ToString();
            }
        }

        private void CheckBox442_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox442.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox453_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox453.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox456_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox456.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox458_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox458.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox459_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox459.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox460_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox460.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox461_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox461.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox463_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox463.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox465_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox465.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox467_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox467.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox468_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox468.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox462_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox462.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox464_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox464.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox466_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox466.Checked == true)
            {
                textBox30.Text = (5 + Double.Parse(textBox30.Text)).ToString();
            }
            else
            {
                textBox30.Text = (Double.Parse(textBox30.Text) - 5).ToString();
            }
        }

        private void CheckBox518_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox518.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox523_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox523.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox519_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox519.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox526_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox526.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox517_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox517.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox525_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox525.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox521_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox521.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox520_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox520.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox524_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox524.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckBox522_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox522.Checked == true)
            {
                textBox31.Text = (5 + Double.Parse(textBox31.Text)).ToString();
            }
            else
            {
                textBox31.Text = (Double.Parse(textBox31.Text) - 5).ToString();
            }
        }

        private void CheckedListBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox23_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox23.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu");
                    groupBox136.Visible = true;
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    groupBox136.Visible = false;
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }

            if (checkedListBox23.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }

            if (checkedListBox23.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }

            if (checkedListBox23.SelectedIndex == 3)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu");
                    groupBox141.Visible = true;
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    groupBox141.Visible = false;
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }

            if (checkedListBox23.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu");
                    groupBox135.Visible = true;
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    groupBox135.Visible = false;
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }

            if (checkedListBox23.SelectedIndex == 5)
            {

                if (e.NewValue == CheckState.Checked)
                {

                    MessageBox.Show("Select menu");
                    groupBox147.Visible = true;
                    textBox24.Text = (30 + Double.Parse(textBox24.Text)).ToString();
                }
                else
                {
                    groupBox147.Visible = false;
                    textBox24.Text = (Double.Parse(textBox24.Text) - 30).ToString();
                }


            }


        }

        private void CheckedListBox24_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox24.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu");
                    groupBox173.Visible = true;
                    textBox28.Text = (30 + Double.Parse(textBox28.Text)).ToString();
                }
                else
                {
                    groupBox173.Visible = false;
                    textBox28.Text = (Double.Parse(textBox28.Text) - 30).ToString();
                }


            }

            if (checkedListBox24.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select menu");
                    groupBox172.Visible = true;
                    textBox28.Text = (30 + Double.Parse(textBox28.Text)).ToString();
                }
                else
                {
                    groupBox172.Visible = false;
                    textBox28.Text = (Double.Parse(textBox28.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox25_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox25.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    
                    
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }
            if (checkedListBox25.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {


                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {

                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }
            if (checkedListBox25.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {


                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {

                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }

            if (checkedListBox25.SelectedIndex == 3)
            {

                if (e.NewValue == CheckState.Checked)
                {


                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {

                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }

            if (checkedListBox25.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox106.Visible = true;
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    groupBox106.Visible = false;
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }

            if (checkedListBox25.SelectedIndex == 5)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox105.Visible = true;
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    groupBox105.Visible = false;
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox26_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox26.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox171.Visible = true;
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    groupBox171.Visible = false;
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }

            if (checkedListBox26.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox170.Visible = true;
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    groupBox170.Visible = false;
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }

            if (checkedListBox26.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox110.Visible = true;
                    textBox26.Text = (30 + Double.Parse(textBox26.Text)).ToString();
                }
                else
                {
                    groupBox110.Visible = false;
                    textBox26.Text = (Double.Parse(textBox26.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox27_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox27.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox154.Visible = true;
                    textBox19.Text = (30 + Double.Parse(textBox19.Text)).ToString();
                }
                else
                {
                    groupBox154.Visible = false;
                    textBox19.Text = (Double.Parse(textBox19.Text) - 30).ToString();
                }


            }

            if (checkedListBox27.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                   
                    textBox19.Text = (30 + Double.Parse(textBox19.Text)).ToString();
                }
                else
                {
                    
                    textBox19.Text = (Double.Parse(textBox19.Text) - 30).ToString();
                }


            }

            if (checkedListBox27.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    
                    textBox19.Text = (30 + Double.Parse(textBox19.Text)).ToString();
                }
                else
                {
                    
                    textBox19.Text = (Double.Parse(textBox19.Text) - 30).ToString();
                }


            }
            if (checkedListBox27.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select flavor");
                    groupBox153.Visible = true;
                    textBox19.Text = (30 + Double.Parse(textBox19.Text)).ToString();
                }
                else
                {
                    groupBox153.Visible = false;
                    textBox19.Text = (Double.Parse(textBox19.Text) - 30).ToString();
                }


            }
            if (checkedListBox27.SelectedIndex == 5)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox169.Visible = true;
                    textBox19.Text = (30 + Double.Parse(textBox19.Text)).ToString();
                }
                else
                {
                    groupBox169.Visible = false;
                    textBox19.Text = (Double.Parse(textBox19.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox29_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox29.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {

                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }

            if (checkedListBox29.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {

                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }

            if (checkedListBox29.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {

                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }

            if (checkedListBox29.SelectedIndex == 3)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {
                  
                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }

            if (checkedListBox29.SelectedIndex == 4)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox162.Visible = true;
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {
                    groupBox162.Visible = false;
                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }

            if (checkedListBox29.SelectedIndex == 5)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox161.Visible = true;
                    textBox20.Text = (30 + Double.Parse(textBox20.Text)).ToString();
                }
                else
                {
                    groupBox161.Visible = false;
                    textBox20.Text = (Double.Parse(textBox20.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox30_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox30.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox167.Visible = true;
                    textBox21.Text = (30 + Double.Parse(textBox21.Text)).ToString();
                }
                else
                {
                    groupBox167.Visible = false;
                    textBox21.Text = (Double.Parse(textBox21.Text) - 30).ToString();
                }


            }
            if (checkedListBox30.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox166.Visible = true;
                    textBox21.Text = (30 + Double.Parse(textBox21.Text)).ToString();
                }
                else
                {
                    groupBox166.Visible = false;
                    textBox21.Text = (Double.Parse(textBox21.Text) - 30).ToString();
                }


            }

            if (checkedListBox30.SelectedIndex == 2)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox165.Visible = true;
                    textBox21.Text = (30 + Double.Parse(textBox21.Text)).ToString();
                }
                else
                {
                    groupBox165.Visible = false;
                    textBox21.Text = (Double.Parse(textBox21.Text) - 30).ToString();
                }


            }
        }

        private void CheckedListBox28_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox28.SelectedIndex == 0)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox159.Visible = true;
                    textBox21.Text = (30 + Double.Parse(textBox21.Text)).ToString();
                }
                else
                {
                    groupBox159.Visible = false;
                    textBox21.Text = (Double.Parse(textBox21.Text) - 30).ToString();
                }


            }
            if (checkedListBox28.SelectedIndex == 1)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    MessageBox.Show("Select type");
                    groupBox158.Visible = true;
                    textBox21.Text = (30 + Double.Parse(textBox21.Text)).ToString();
                }
                else
                {
                    groupBox158.Visible = false;
                    textBox21.Text = (Double.Parse(textBox21.Text) - 30).ToString();
                }


            }
        }

        private void CheckBox404_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox404.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox450_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox450.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox516_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox516.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox399_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox399.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox377_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox377.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox378_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox378.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox376_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox376.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox398_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox398.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox401_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox401.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox402_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox402.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox403_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox403.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox392_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox392.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox395_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox395.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox396_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox396.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox391_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox391.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox394_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox394.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox393_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox393.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox397_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox397.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox388_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox388.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox390_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox390.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox389_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox389.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox384_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox384.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox385_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox385.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox386_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox386.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox387_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox387.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox383_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox383.Checked == true)
            {
                textBox24.Text = (5 + Double.Parse(textBox24.Text)).ToString();
            }
            else
            {
                textBox24.Text = (Double.Parse(textBox24.Text) - 5).ToString();
            }
        }

        private void CheckBox479_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox479.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox482_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox482.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox477_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox477.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox481_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox481.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox480_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox480.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox478_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox478.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox476_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox476.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox475_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox475.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox471_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox471.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox474_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox474.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox472_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox472.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox470_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox470.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox469_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox469.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox473_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox473.Checked == true)
            {
                textBox28.Text = (5 + Double.Parse(textBox28.Text)).ToString();
            }
            else
            {
                textBox28.Text = (Double.Parse(textBox28.Text) - 5).ToString();
            }
        }

        private void CheckBox547_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox547.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox550_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox550.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox548_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox548.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox545_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox545.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox546_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox546.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox542_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox542.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox540_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox540.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox543_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox543.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox541_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox541.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox544_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox544.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox539_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox539.Checked == true)
            {
                textBox26.Text = (5 + Double.Parse(textBox26.Text)).ToString();
            }
            else
            {
                textBox26.Text = (Double.Parse(textBox26.Text) - 5).ToString();
            }
        }

        private void CheckBox508_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox508.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox513_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox513.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox509_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox509.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox507_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox507.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox515_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox515.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox511_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox511.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox510_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox510.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox514_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox514.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox512_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox512.Checked == true)
            {
                textBox25.Text = (5 + Double.Parse(textBox25.Text)).ToString();
            }
            else
            {
                textBox25.Text = (Double.Parse(textBox25.Text) - 5).ToString();
            }
        }

        private void CheckBox448_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox448.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox449_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox449.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox445_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox445.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox446_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox446.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox447_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox447.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox440_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox440.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox444_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox444.Checked == true)
            {
                textBox27.Text = (5 + Double.Parse(textBox27.Text)).ToString();
            }
            else
            {
                textBox27.Text = (Double.Parse(textBox27.Text) - 5).ToString();
            }
        }

        private void CheckBox443_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox443.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox405_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox405.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox400_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox400.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox417_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox417.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox416_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox416.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox418_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox418.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox419_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox419.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox420_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox420.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox410_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox410.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox413_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox413.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox414_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox414.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox409_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox409.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox412_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox412.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox411_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox411.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox415_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox415.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox406_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox406.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox408_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox408.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox407_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox407.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox421_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox421.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox423_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox423.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox422_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox422.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox425_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox425.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox426_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox426.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox427_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox427.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox424_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox424.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox428_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox428.Checked == true)
            {
                textBox19.Text = (5 + Double.Parse(textBox19.Text)).ToString();
            }
            else
            {
                textBox19.Text = (Double.Parse(textBox19.Text) - 5).ToString();
            }
        }

        private void CheckBox559_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox559.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox562_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox562.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox560_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox560.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox557_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox557.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox561_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox561.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox558_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox558.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox554_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox554.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox552_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox552.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox555_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox555.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox553_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox553.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox556_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox556.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox551_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox551.Checked == true)
            {
                textBox20.Text = (5 + Double.Parse(textBox20.Text)).ToString();
            }
            else
            {
                textBox20.Text = (Double.Parse(textBox20.Text) - 5).ToString();
            }
        }

        private void CheckBox457_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox457.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox455_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox455.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox452_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox452.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox454_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox454.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox441_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox441.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox451_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox451.Checked == true)
            {
                textBox21.Text = (5 + Double.Parse(textBox21.Text)).ToString();
            }
            else
            {
                textBox21.Text = (Double.Parse(textBox21.Text) - 5).ToString();
            }
        }

        private void CheckBox493_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox493.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox496_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox496.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox491_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox491.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox495_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox495.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox494_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox494.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox492_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox492.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox490_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox490.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox489_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox489.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox488_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox488.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox486_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox486.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox484_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox484.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox485_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox485.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox483_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox483.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox487_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox487.Checked == true)
            {
                textBox22.Text = (5 + Double.Parse(textBox22.Text)).ToString();
            }
            else
            {
                textBox22.Text = (Double.Parse(textBox22.Text) - 5).ToString();
            }
        }

        private void CheckBox498_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox498.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox503_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox503.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox499_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox499.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox506_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox506.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox497_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox497.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox505_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox505.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox501_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox501.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox500_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox500.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox504_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox504.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void CheckBox502_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox502.Checked == true)
            {
                textBox23.Text = (5 + Double.Parse(textBox23.Text)).ToString();
            }
            else
            {
                textBox23.Text = (Double.Parse(textBox23.Text) - 5).ToString();
            }
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDPTot.Text = (Double.Parse(txtDPTot.Text) + Double.Parse(textBox29.Text)).ToString();
            }
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDPTot.Text = (Double.Parse(txtDPTot.Text) + Double.Parse(textBox32.Text)).ToString();
            }
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDPTot.Text = (Double.Parse(txtDPTot.Text) + Double.Parse(textBox33.Text)).ToString();
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDPTot.Text = (Double.Parse(txtDPTot.Text) + Double.Parse(textBox30.Text)).ToString();
            }
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDPTot.Text = (Double.Parse(txtDPTot.Text) + Double.Parse(textBox31.Text)).ToString();
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDGTot.Text = (Double.Parse(txtDGTot.Text) + Double.Parse(textBox27.Text)).ToString();
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDGTot.Text = (Double.Parse(txtDGTot.Text) + Double.Parse(textBox25.Text)).ToString();
            }
        }

        private void TextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button29_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDGTot.Text = (Double.Parse(txtDGTot.Text) + Double.Parse(textBox26.Text)).ToString();
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDGTot.Text = (Double.Parse(txtDGTot.Text) + Double.Parse(textBox28.Text)).ToString();
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDGTot.Text = (Double.Parse(txtDGTot.Text) + Double.Parse(textBox24.Text)).ToString();
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDSTot.Text = (Double.Parse(txtDSTot.Text) + Double.Parse(textBox23.Text)).ToString();
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDSTot.Text = (Double.Parse(txtDSTot.Text) + Double.Parse(textBox22.Text)).ToString();
            }
        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDSTot.Text = (Double.Parse(txtDSTot.Text) + Double.Parse(textBox21.Text)).ToString();
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDSTot.Text = (Double.Parse(txtDSTot.Text) + Double.Parse(textBox20.Text)).ToString();
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                txtDSTot.Text = (Double.Parse(txtDSTot.Text) + Double.Parse(textBox19.Text)).ToString();
            }
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (string item in checkedListBox11.CheckedItems)
                {
                    lblDPMeal.Text += item + ",";
                }

                foreach (string item in checkedListBox13.CheckedItems)
                {
                    lblDPD.Text += item + ",";
                }

                foreach (string item in checkedListBox14.CheckedItems)
                {
                    lblDPT.Text += item + ",";
                }

                foreach (string item in checkedListBox12.CheckedItems)
                {
                    lblDPB.Text += item + ",";
                }

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("dinner", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", "Platinum");
                    sqlCmd.Parameters.AddWithValue("@meal", lblDPMeal.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", "chicken,fish,prawn");
                    sqlCmd.Parameters.AddWithValue("@dessert", lblDPD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", lblDPB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", lblDPT.Text);
                    sqlCmd.Parameters.AddWithValue("@price", txtDPTot.Text.Trim());




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

        private void Label52_Click(object sender, EventArgs e)
        {

        }

        private void Button38_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (string item in checkedListBox23.CheckedItems)
                {
                    lblDGMeal.Text += item + ",";
                }

                foreach (string item in checkedListBox25.CheckedItems)
                {
                    lblDGD.Text += item + ",";
                }

                foreach (string item in checkedListBox26.CheckedItems)
                {
                    lblDGT.Text += item + ",";
                }

                foreach (string item in checkedListBox24.CheckedItems)
                {
                    lblDGB.Text += item + ",";
                }

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("dinner", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", "Gold");
                    sqlCmd.Parameters.AddWithValue("@meal", lblDGMeal.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", "chicken,fish,prawn");
                    sqlCmd.Parameters.AddWithValue("@dessert", lblDGD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", lblDGB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", lblDGT.Text);
                    sqlCmd.Parameters.AddWithValue("@price", txtDGTot.Text.Trim());




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

        private void CheckedListBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button37_Click(object sender, EventArgs e)
        {
            string message = "Confirm to submit";
            string title = "Confirmattion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (string item in checkedListBox27.CheckedItems)
                {
                    lblDSMeal.Text += item + ",";
                }

                foreach (string item in checkedListBox29.CheckedItems)
                {
                    lblDSD.Text += item + ",";
                }

                foreach (string item in checkedListBox30.CheckedItems)
                {
                    lblDST.Text += item + ",";
                }

                foreach (string item in checkedListBox28.CheckedItems)
                {
                    lblDSB.Text += item + ",";
                }

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("dinner", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Pack", "Silver");
                    sqlCmd.Parameters.AddWithValue("@meal", lblDSMeal.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@curry", "chicken,fish,prawn");
                    sqlCmd.Parameters.AddWithValue("@dessert", lblDSD.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@beverage", lblDSB.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@tea", lblDST.Text);
                    sqlCmd.Parameters.AddWithValue("@price", txtDSTot.Text.Trim());




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
    

        
    
