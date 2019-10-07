using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerManagementITP;
using Kitchen_Management_System;
using Stock_Management_System;

namespace Kitchen_Management_System
{
    public partial class KMS : MetroFramework.Forms.MetroForm
    {

        Food food = new Food();
        Drink drink = new Drink();
        Kitchen kitchen = new Kitchen();
        Food foodType = new Food();
        Drink drinkType = new Drink();

        public KMS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayfoodtDataGridView();
            drinkgrid.DataSource = drinkType.viewDrinkItems();
            MealOrderGrid.DataSource = foodType.getAllMealOrder();
            
        }

        private void LblKMS_Click(object sender, EventArgs e)
        {

        }

        private void MetroContextMenu1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AddFoodClick(object sender, EventArgs e)
        {
            String foodName = txtfooditemName.Text.ToString();
            String foodId = txtFoodId.Text.ToString();
            float foodPrice = float.Parse(txtfoodItemPrice.Text.ToString());

            foodType.insertFoodItems(foodId, foodName, foodPrice);
            Dvgfood.DataSource = foodType.viewSearchfood();


        }

        private void btnfoodupdate(object sender, EventArgs e)
        {
            String foodName = txtfooditemName.Text.ToString();
            String foodId = txtFoodId.Text.ToString();
            float foodPrice = float.Parse(txtfoodItemPrice.Text.ToString());
            foodType.updateFoodItem(foodName, foodId, foodPrice);
            Dvgfood.DataSource = foodType.viewSearchfood();
        }

        public void displayfoodtDataGridView()
        {
            Dvgfood.DataSource = foodType.viewSearchfood();


        }

        private void MetroGrid6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgfoodclick(object sender, EventArgs e)
        {
            if (Dvgfood.CurrentRow.Index != -1)
            {
                txtFoodId.Text = Dvgfood.CurrentRow.Cells[0].Value.ToString();
                txtfooditemName.Text = Dvgfood.CurrentRow.Cells[1].Value.ToString();
                txtfoodItemPrice.Text = Dvgfood.CurrentRow.Cells[3].Value.ToString();

                btnFoodremove.Enabled = true;//default false so now it's inaible
            }

        }

        private void btnfoodSearchClick(object sender, EventArgs e)
        {
            try
            {

                //call the this method for show the data
                String foodName = txtfoodSearch.Text.ToString();
                Dvgfood.DataSource = foodType.viewSearchfood(foodName);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnfoodRemove(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this Equipment?", "Remove Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String foodId = txtFoodId.Text.ToString();
                foodType.deleteFoodItem(foodId);
                Dvgfood.DataSource = foodType.viewSearchfood();

            }

            displayfoodtDataGridView();
            Resetfood();
        }

        void Resetfood()
        {
            displayfoodtDataGridView();
            txtFoodId.Text = txtfooditemName.Text = " ";
            txtfoodItemPrice.Text = "";

        }

        private void btnResetfood(object sender, EventArgs e)
        {
            try
            {

                Resetfood();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void MaskedTextBox15_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lblordertype_Click(object sender, EventArgs e)
        {

        }

        private void Btndrinkadd_Click(object sender, EventArgs e)
        {
            String drinkId = txtDrinkId.Text.ToString();
            String DrinkName = txtdrinkName.Text.ToString();
            float DrinkPrice = float.Parse(txtdrinkPrice.Text.ToString());
            drinkType.insertDrinkDetails(drinkId, DrinkName, DrinkPrice);
            drinkgrid.DataSource = drinkType.viewDrinkItems();

        }

        private void MealOrderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtcheckincustomerid.Text = customerdataGridView.CurrentRow.Cells[0].Value.ToString();
            txtcustomerId.Text = MealOrderGrid.CurrentRow.Cells[0].Value.ToString();
            txtmealId.Text = MealOrderGrid.CurrentRow.Cells[1].Value.ToString();
            txtmealName.Text = MealOrderGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(txtcustomerId.Text.ToString());
            String mealID = txtmealId.Text.ToString();
            String mealName = txtmealName.ToString();
            foodType.confirmMealOrder(customerID, mealID, float.Parse(MealOrderGrid.CurrentRow.Cells[6].Value.ToString()));
            MealOrderGrid.DataSource = foodType.getAllMealOrder();
        }

        private void BtnDrinkSearch_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(txtSearch.Text.ToString());
            
            MealOrderGrid.DataSource = foodType.searchMealOrder(customerID);

        }

        private void BtbUpdatedrink_Click(object sender, EventArgs e)
        {
            String drinkId = txtDrinkId.Text.ToString();
            String DrinkName = txtdrinkName.Text.ToString();
            float DrinkPrice = float.Parse(txtdrinkPrice.Text.ToString());
            drinkType.updateDrinkDetails(drinkId, DrinkName, DrinkPrice);
            drinkgrid.DataSource = drinkType.viewDrinkItems();
        }

        private void BtndrinkReset_Click(object sender, EventArgs e)
        {
            txtDrinkId.Text = "";
            txtdrinkName.Text = "";
            txtdrinkPrice.Text = "";
        }

        private void Drinkgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDrinkId.Text = drinkgrid.CurrentRow.Cells[0].Value.ToString();
            txtdrinkName.Text = drinkgrid.CurrentRow.Cells[1].Value.ToString();
            txtdrinkPrice.Text = drinkgrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnRemoveDrink_Click(object sender, EventArgs e)
        {
            String drinkId = txtDrinkId.Text.ToString();
            drinkType.deleteDrinkItem(drinkId);
            drinkgrid.DataSource = drinkType.viewDrinkItems();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MealOrderReportForm mealOrderReportForm = new MealOrderReportForm();
            mealOrderReportForm.Show();
        }
    }
   }
    
