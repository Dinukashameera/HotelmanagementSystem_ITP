using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class damagehall : MetroFramework.Forms.MetroForm
    {

        Damage dmg = new Damage();
        public damagehall()
        {
            InitializeComponent();
        }

        private void Damagehall_Load(object sender, EventArgs e)
        {
            displayDamageDataGridView();
        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void damagehallprevious(object sender, EventArgs e)
        {
            new StockManagement().Show();
            this.Hide();
        }

        //damage data grid
        private void DamageDaraGrid(object sender, EventArgs e)
        {


            if (dvgDamage.CurrentRow.Index != -1)
            {
                //txtRoomEID.Text = dvgDamage.CurrentRow.Cells[1].Value.ToString();
                //cmbRoomECategorie.Text = dvgDamage.CurrentRow.Cells[2].Value.ToString();
                //txtRoomEBrand.Text = dvgDamage.CurrentRow.Cells[3].Value.ToString();
                //txtRoomEquipmentModel.Text = dvgDamage.CurrentRow.Cells[4].Value.ToString();
             
                //btnRoomAdd.Text = "Update";//safe convert to update after clicking datagrid row view
                //btnRoomRemoveE.Enabled = true;//default false so now it's inaible
            }




             void displaydamageEquipmentDataGridView()
            {

               // dmg.Item_name1 = txtRoomSearch.Text.Trim().ToString();
                //roomE.EquipmentID1 = txtRoomEID.Text.Trim().ToString();
                //roomE.EquipmentCategorie1 = cmbRoomECategorie.Text.Trim().ToString();

                DataTable dt = dmg.viewSearchDamage();
               // dvgDamage.DataSource = dtd;//to show the records in datagrid
                                          //DgvStocks.Columns[0].Visible = false;

            }







        }

        private void Btnhalldamagesearch_Click(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                displayDamageDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        public void displayDamageDataGridView()
        {

            dmg.SearchDmageContent = txtdamageSearch.Text.Trim().ToString();

            DataTable dts = dmg.viewSearchDamage();
            dvgDamage.DataSource = dts;//to show the records in datagrid
            //DgvStocks.Columns[0].Visible = false;

        }

        private void DvgDamage_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
