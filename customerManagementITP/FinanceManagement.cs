using customerManagementITP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FinanceManagement_Blue_Lotus
{
    public partial class FinanceForm : MetroFramework.Forms.MetroForm
    {
        Expenditures expenditures_obj = new Expenditures();
        Incomes income = new Incomes();
        Expences expences = new Expences();
        ProfitCalculations profit = new ProfitCalculations();
        Targets targets = new Targets();
        OlderRecords olderRecords = new OlderRecords();

        public FinanceForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
/*            Regex regX = new Regex(@"^[0-9]{1,9}.[1-9]{2}$");
            bool result = regX.IsMatch(txtAmmout.Text);*/

            if (txtInvoiceNum.Text == "" || CmbboxPaymentType.Text == null || TymPkrPaymentDate.Value.ToString() == "" || txtAmmout.Text == "")
            {
                MessageBox.Show("Fields Can't Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
               
                 
/*                if(result != true)
                {
                    MessageBox.Show("Invalid Ammount", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
                else
                {*/

                    expenditures_obj.Invoice_no = txtInvoiceNum.Text.Trim().ToString();
                    expenditures_obj.Payment_Type = CmbboxPaymentType.Text.Trim().ToString();
                    //expenditures_obj.Paymnt_date = TymPkrPaymentDate.Text.Trim().ToString();
                    expenditures_obj.Paymnt_date = TymPkrPaymentDate.Value.Date.ToString();
                    expenditures_obj.Ammount = Convert.ToSingle(txtAmmout.Text.Trim().ToString());

                    expenditures_obj.Store();

               // }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {

        }

        private void MetroGrid5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            ComboBox cmb_box_1 = new ComboBox();
            cmb_box_1.Items.Add("Electrisity Bill");
            cmb_box_1.Items.Add("warter Bill");
            cmb_box_1.Items.Add("Communication Bill");
            cmb_box_1.Items.Add("Loan Payments");
            cmb_box_1.Items.Add("Other Payments");*/

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (cmb_boxincomeDept.Text == null || txtbox_ammount_incomes.Text == "" || datetympkr_incomes.Value.ToString() == "" || txtbox_ammount_incomes.Text == "0")
            {
                MessageBox.Show("Fields Can't Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                income.Department = cmb_boxincomeDept.Text.Trim().ToString();
                income.Date = datetympkr_incomes.Value.Date.ToString();
                income.Income_ammount = Convert.ToSingle(txtbox_ammount_incomes.Text.Trim().ToString());

                income.insertTotIncomes();
            }
        }

        private void Targets_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage12_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void MetroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (cmbbox_dept_create_target.SelectedItem == null || datetympkr_create_target_fromDate.Value.ToString() == "")
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtbox_earned_profit_create_targets.Text = targets.retrieveProfit(cmbbox_dept_create_target.SelectedItem.ToString().Trim(), datetympkr_create_target_fromDate.Value.ToString().Trim()).ToString();

            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button15_Click_1(object sender, EventArgs e)
        {

            if (datetympkr_create_target_fromDate.Value.ToString() == "" || cmbbox_dept_create_target.SelectedItem == null || txtbox_earned_profit_create_targets.Text.Trim().ToString() == null || datetympkr_create_target_toDate.Value.ToString() == "" || txtbox_percentage_create_targets.Text.Trim().ToString() == null)
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                /*            targets.Department = cmbbox_dept_create_target.Text.Trim().ToString();
                            targets.Earned_profit = Convert.ToSingle(txtbox_earned_profit_create_targets.Text.Trim().ToString());
                            targets.Date= datetympkr_create_target_fromDate.Text.Trim().ToString();
                            targets.Percentage = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());

                            targets.Update_Epected_Percentage();*/
                /*
                    sql_command.Parameters.AddWithValue("@ToDate", Todate);
                    sql_command.Parameters.AddWithValue("@Department", Department);
                    sql_command.Parameters.AddWithValue("@ExpectedPercentage", Percentage);*/

                targets.Todate = datetympkr_create_target_toDate.Text.Trim().ToString();
                targets.Department = cmbbox_dept_create_target.Text.Trim().ToString();
                targets.Percentage = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());
                float percentageAmount = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());
                float previousAmount = Convert.ToSingle(txtbox_earned_profit_create_targets.Text.Trim().ToString());
                targets.Amount = (percentageAmount * previousAmount) / 100;

                targets.Update_Epected_Percentage();
            }


        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

            if (txtbox_income_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                //   MessageBox.Show("error", txtbox_income_sarch.Text.Trim().ToString());
                income.Date = txtbox_income_search.Text.Trim().ToString();
                //MessageBox.Show(income.Date, "ERROR");
                gridV_income.DataSource = income.FillGrid(income.Date);
            }


            
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(datetympkr_incomes.Value.ToString().Trim(), "Error 1");
            //MessageBox.Show(cmb_boxincomeDept.SelectedItem.ToString(), "Error 2");

            /* float ammount = income.retrieveTotIncomes(cmb_boxincomeDept.SelectedItem.ToString().Trim() , datetympkr_incomes.Value.ToString().Trim());
             txtbox_ammount_incomes.Text = ammount.ToString();*/

            if (cmb_boxincomeDept.SelectedItem == null ||  datetympkr_incomes.Value.ToString() == "")
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else //methana aulak awa poddak balanna
            {
                txtbox_ammount_incomes.Text = income.retrieveTotIncomes(cmb_boxincomeDept.SelectedItem.ToString().Trim(), datetympkr_incomes.Value.ToString().Trim()).ToString();
            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (cmbBox_Expence_Dept.SelectedItem == null || datetympkr_expense.Value.ToString() == "")
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show("Fields Can't Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                txtbox_expenseAmmount.Text = expences.retrieveTotExpences(cmbBox_Expence_Dept.SelectedItem.ToString().Trim(), datetympkr_expense.Value.ToString().Trim()).ToString();
            }
            }

        private void MetroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {/*
            income.Department = cmb_boxincomeDept.Text.Trim().ToString();
            income.Date = datetympkr_incomes.Value.Date.ToString();
            income.Income_ammount = Convert.ToSingle(txtbox_ammount_incomes.Text.Trim().ToString());

            income.insertTotIncomes();*/

            if (cmbBox_Expence_Dept.Text == null || txtbox_expenseAmmount.Text == "" || datetympkr_expense.Value.ToString() == "" || txtbox_expenseAmmount.Text == "0")
            {
                MessageBox.Show("Fields Can't Be Empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                expences.Department = cmbBox_Expence_Dept.Text.Trim().ToString();
                expences.Date = datetympkr_expense.Value.Date.ToString();
                expences.Expense_ammount = Convert.ToSingle(txtbox_expenseAmmount.Text.Trim().ToString());
                expences.insertTotExpenses();
            }
        }

        private void MetroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            if (txtbox_expense_sarch.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            { 

            expences.Date = txtbox_expense_sarch.Text.Trim().ToString();
            gridV_expenses.DataSource = expences.FillGrid(expences.Date);

            }

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (txtbox_expenditure_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //txtbox_profit_search
            else
            {
                expenditures_obj.Paymnt_date = txtbox_expenditure_search.Text.Trim().ToString();
                gridV_expenditures.DataSource = expenditures_obj.FillGrid(expenditures_obj.Paymnt_date);
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (cmbbox_dept_profit.SelectedItem == null || datetympkr_profit.Value.ToString() == "")
            {
                MessageBox.Show("Enter valid details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {

                try
                {
                    if (cmbbox_dept_profit.SelectedItem.ToString().Trim() == "All Departments")
                    {


                        txtbox_profit_income.Text = profit.Tot_Incomes_To_Calculate_profit(datetympkr_profit.Value.ToString().Trim()).ToString();
                        txtbox_profit_expense.Text = profit.Tot_Expenses_To_Calculate_profit(datetympkr_profit.Value.ToString().Trim()).ToString();
                        txtbox_profit_expenditures.Text = expenditures_obj.retrieveTotExpenditures(datetympkr_profit.Value.ToString().Trim()).ToString();

                        txtbox_total_profit.Text = profit.calculate_Total_Profit(datetympkr_profit.Value.ToString().Trim()).ToString();
                    }

                    else
                    {

                        txtbox_profit_income.Text = income.retrieveTotIncomes(cmbbox_dept_profit.SelectedItem.ToString().Trim(), datetympkr_profit.Value.ToString().Trim()).ToString();

                        txtbox_profit_expense.Text = expences.retrieveTotExpences(cmbbox_dept_profit.SelectedItem.ToString().Trim(), datetympkr_profit.Value.ToString().Trim()).ToString();

                        txtbox_total_profit.Text = profit.calculate_Total_Department_Profit(cmbbox_dept_profit.SelectedItem.ToString().Trim(), datetympkr_profit.Value.ToString().Trim()).ToString();

                    }





                    if (float.Parse(txtbox_total_profit.Text.ToString()) < 0)
                    {

                        txtbox_status.Text = " LOST ";
                    }
                    else if (float.Parse(txtbox_total_profit.Text.ToString()) == 0)
                    {

                        txtbox_status.Text = " NO PEO PROFIT ";
                    }
                    else
                    {

                        txtbox_status.Text = " PROFIT ";
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show("System Error  " + ex.Message);
                }
          
            }   
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {/*
            income.Department = cmb_boxincomeDept.Text.Trim().ToString();
            income.Date = datetympkr_incomes.Value.Date.ToString();
            income.Income_ammount = Convert.ToSingle(txtbox_ammount_incomes.Text.Trim().ToString());

            income.insertTotIncomes();*/


            if (txtbox_profit_income.Text == "" || txtbox_profit_expense.Text == "" || txtbox_profit_expenditures.Text == "" || txtbox_total_profit.Text == "" || txtbox_status.Text == "")
            {
                MessageBox.Show("Fields Can't Be Empty!","Error!" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                profit.Department = cmbbox_dept_profit.Text.Trim().ToString();
                profit.Date = datetympkr_profit.Value.Date.ToString();
                profit.Amount = Convert.ToSingle(txtbox_total_profit.Text.Trim().ToString());
                profit.Status = txtbox_status.Text.Trim().ToString();

                profit.Insert_Profit();

            }
        }

        private void GridV_income_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button23_Click(object sender, EventArgs e)
        {

            if (txtbox_profit_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                profit.Date = txtbox_profit_search.Text.Trim().ToString();
                gridV_profit.DataSource = profit.FillGrid(profit.Date);
            }
        }

        private void Bttn_create_targets_generate_charts_Click(object sender, EventArgs e)
        {
            /*            targets.Department = cmbbox_dept_create_target.Text.Trim().ToString();
                        targets.Date = datetympkr_create_target.Text.Trim().ToString();
                        targets.Earned_profit = Convert.ToSingle(txtbox_earned_profit_create_targets.Text.Trim().ToString());
                        targets.Percentage = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());

                        targets.Create_target_Insertion();*/
            //if (cmb_boxincomeDept.SelectedItem == null ||  datetympkr_incomes.Value.ToString() == "")
            if (datetympkr_create_target_fromDate.Value.ToString() == "" || cmbbox_dept_create_target.SelectedItem == null || txtbox_earned_profit_create_targets.Text.Trim().ToString() == null || datetympkr_create_target_toDate.Value.ToString() == "" || txtbox_percentage_create_targets.Text.Trim().ToString() == null)
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                targets.Department = cmbbox_dept_create_target.Text.Trim().ToString();
                targets.Todate = datetympkr_create_target_toDate.Text.Trim().ToString();
                targets.Fdate = datetympkr_create_target_fromDate.Text.Trim().ToString();
                targets.Percentage = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());

                float percentageVar = Convert.ToSingle(txtbox_percentage_create_targets.Text.Trim().ToString());
                float previousAmount = Convert.ToSingle(txtbox_earned_profit_create_targets.Text.Trim().ToString());

                targets.Amount = (percentageVar * previousAmount) / 100;
                //MessageBox.Show("amount is" + percentageVar * previousAmount);
                targets.Create_target_Insertion();
                /*
                            //1 parameter ekata one fromdate time pkr value eka
                           //2 ta enne earned txtxbox value eka
                            this.chart_create_target_chart.Series["Profit/Lost"].Points.AddXY(datetympkr_create_target_fromDate.Text.Trim().ToString(), txtbox_earned_profit_create_targets.Text.Trim().ToString());
                            //1 parameter ekata one todate time pkr value eka
                            //2 ta enne task table eke amount eke agaya - select query ekakin
                            this.chart_create_target_chart.Series["Profit/Lost"].Points.AddXY("2019-11-17", -6600.4);
                */
            }
        }

        private void Txtbox_percentage_create_targets_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bttn_create_target_search_Click(object sender, EventArgs e)
        {
            if (txtbox_create_targets_search.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*            else
                        {
                            targets.Date = txtbox_create_targets_search.Text.Trim().ToString();
                            gridV_create_targets.DataSource = targets.FillGrid(targets.Date);
                        }*/
            else
            {
                targets.Todate = txtbox_create_targets_search.Text.Trim().ToString();
                gridV_create_targets.DataSource = targets.FillGrid(targets.Todate);
            }

        }

        private void GridV_create_targets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            if (gridV_create_targets.CurrentRow.Index != -1)
                        {

                            cmbbox_dept_create_target.Text = gridV_create_targets.CurrentRow.Cells[0].Value.ToString();
                            datetympkr_create_target_fromDate.Text = gridV_create_targets.CurrentRow.Cells[1].Value.ToString();
                            txtbox_earned_profit_create_targets.Text = gridV_create_targets.CurrentRow.Cells[2].Value.ToString();
                            txtbox_percentage_create_targets.Text = gridV_create_targets.CurrentRow.Cells[3].Value.ToString();

                        }*/

            if (gridV_create_targets.CurrentRow.Index != -1)
            {
                cmbbox_dept_create_target.Text = gridV_create_targets.CurrentRow.Cells[0].Value.ToString();
                datetympkr_create_target_fromDate.Text = gridV_create_targets.CurrentRow.Cells[1].Value.ToString();
                datetympkr_create_target_toDate.Text = gridV_create_targets.CurrentRow.Cells[2].Value.ToString();
                txtbox_percentage_create_targets.Text = gridV_create_targets.CurrentRow.Cells[3].Value.ToString();
            }


        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button15_Click_2(object sender, EventArgs e)
        {

            if (txtbox_search_delete.Text == "")
            {
                MessageBox.Show("Search Field Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                olderRecords.Date = txtbox_search_delete.Text.Trim().ToString();
                gridV_delete_records.DataSource = olderRecords.FillGrid(olderRecords.Date);
            }

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {

            olderRecords.Date = txtbox_date_delete.Text.Trim().ToString();
            olderRecords.Department = txtbox_dept_delete.Text.Trim().ToString();

            if (txtbox_dept_delete.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Fields Cannot Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (txtbox_income_delete.Text == "")
                {
                    olderRecords.Income = 0;
                    olderRecords.Expense = Convert.ToSingle(txtbox_expense_delete.Text.Trim().ToString());
                    olderRecords.Delete_olderExpenseRecords_fromPayments(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());

                }
                else if (txtbox_expense_delete.Text == "")
                {
                    olderRecords.Expense = 0;
                    olderRecords.Income = float.Parse(txtbox_income_delete.Text.Trim().ToString());
                    olderRecords.Delete_olderIncomeRecords_fromPayments(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());

                }

                //olderRecords.Date = datetympkr_delete.Text.Trim().ToString();
                //olderRecords.Delete_olderRecords(olderRecords.Date);

                /*            if (txtbox_income_delete.Text.Trim().ToString() != "Income")
                            {
                                olderRecords.Delete_olderIncome_Records(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());
                                olderRecords.Delete_olderIncomeRecords_fromPayments(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());
                            }
                            else if (txtbox_expense_delete.Text.Trim().ToString() == "Expense")
                            {
                                olderRecords.Delete_older_Expense_Records(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());
                                olderRecords.Delete_olderExpenseRecords_fromPayments(txtbox_date_delete.Text.Trim().ToString(), txtbox_dept_delete.Text.Trim().ToString());
                            }*/



                // olderRecords.Save_Older_Records();

                if (txtbox_income_delete.Text == "")
                {
                    float amount = float.Parse(txtbox_expense_delete.Text.Trim().ToString());
                    //Convert.ToSingle(txtbox_ammount_incomes.Text.Trim().ToString());
                    olderRecords.Save_Older_Records();
                }
                else if (txtbox_expense_delete.Text == "")
                {
                    float amount = Convert.ToSingle(txtbox_income_delete.Text.Trim().ToString());
                    //Convert.ToSingle(txtbox_ammount_incomes.Text.Trim().ToString());
                    olderRecords.Save_Older_Records();
                }
                //olderRecords.Save_Older_Records();


            }

        }

        private void GridV_delete_records_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void GridV_delete_records_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridV_delete_records_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridV_delete_records_DoubleClick(object sender, EventArgs e)
        {
            if (gridV_delete_records.CurrentRow.Index != -1)
            {
                
                txtbox_dept_delete.Text = gridV_delete_records.CurrentRow.Cells[1].Value.ToString();
                txtbox_date_delete.Text = gridV_delete_records.CurrentRow.Cells[2].Value.ToString();
                txtbox_income_delete.Text = gridV_delete_records.CurrentRow.Cells[3].Value.ToString();
                txtbox_expense_delete.Text = gridV_delete_records.CurrentRow.Cells[4].Value.ToString();
               // MessageBox.Show(txtbox_income_delete.Text, "error");
            }
        }

        private void MetroTabPage11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txtbox_ammount_incomes_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_ammount_incomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox_expenseAmmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox_expenseAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void TxtAmmout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtInvoiceNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtbox_percentage_create_targets_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_income_search_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_expense_sarch_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_expenditure_search_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_profit_search_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Txtbox_create_targets_search_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Button22_Click(object sender, EventArgs e)
        {

        }

        private void Txtbox_search_delete_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void Btn_income_cancle_Click(object sender, EventArgs e)
        {
            cmb_boxincomeDept.Text = null;
            //datetympkr_incomes.Value = default;
            txtbox_ammount_incomes.Text = "";

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label34_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label38_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            cmbBox_Expence_Dept.Text = null;
            //datetympkr_expense.Value = default;
            txtbox_expenseAmmount.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CmbboxPaymentType.Text = null;
            //TymPkrPaymentDate.Value = default;
            txtInvoiceNum.Text = "";
            txtAmmout.Text = "";
        }

        private void Btn_profit_cancel_Click(object sender, EventArgs e)
        {
                       //datetympkr_profit.Value = default;
                       cmbbox_dept_profit.Text = null;
                        
                        txtbox_profit_income.Text = "";
                        txtbox_profit_expense.Text = "";
                        txtbox_profit_expenditures.Text = "";
                        txtbox_total_profit.Text = "";
                        txtbox_status.Text = "";
        }

        private void Btn_compare_trget_reset_Click(object sender, EventArgs e)
        {
                        //datetympkr_compare_trget.Text = null;
                        cmbbo_compare_trget_dept.Text = null;
                        txtbox_compare_trget_expected_amont.Text = "";
                        txtbox_compare_trget_earned_amount.Text = "";
        }

        private void Bttn_reset_create_targets_Click(object sender, EventArgs e)
        {
            //datetympkr_create_target.Text = null;
            /*                        cmbbox_dept_create_target.Text = null;
                                    txtbox_earned_profit_create_targets.Text = "";
                                    txtbox_percentage_create_targets.Text = "";*/

            datetympkr_create_target_fromDate.Text = null;
            cmbbox_dept_create_target.Text = null;
            txtbox_earned_profit_create_targets.Text = null;
            datetympkr_create_target_toDate.Text = null;
            txtbox_percentage_create_targets.Text = null;

        }

        private void Txtbox_amount_delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_delete_record_cancel_Click(object sender, EventArgs e)
        {

            txtbox_date_delete.Text = "";
            txtbox_dept_delete.Text = "";
            txtbox_income_delete.Text = "";
            txtbox_expense_delete.Text = "";


        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtbox_search_delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_compare_trget_calculate_Click(object sender, EventArgs e)
        {
            if (cmbbo_compare_trget_dept.SelectedItem == null || datetympkr_compare_trget.Value.ToString() == "")
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtbox_compare_trget_expected_amont.Text = targets.Retreive_Expected_Amounts(cmbbo_compare_trget_dept.SelectedItem.ToString().Trim() , datetympkr_compare_trget.Value.ToString().Trim()).ToString();
                //retrieveProfit(cmbbo_compare_trget_dept.SelectedItem.ToString().Trim(), datetympkr_compare_trget.Value.ToString().Trim()).ToString();
            }
        }

        private void Btn_compare_trget_compare_Click(object sender, EventArgs e)
        {
            if (datetympkr_compare_trget.Value.ToString() == "" || cmbbo_compare_trget_dept.SelectedItem == null)
            {
                

                MessageBox.Show("Enter valid inpiuts!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //1 parameter ekata one fromdate time pkr value eka
                //2 ta enne earned txtxbox value eka
                this.compare_chart.Series["Profit/Lost"].Points.AddXY("Expected Amount", txtbox_compare_trget_expected_amont.Text.Trim().ToString());
                //1 parameter ekata one todate time pkr value eka
                //2 ta enne task table eke amount eke agaya - select query ekakin
                this.compare_chart.Series["Profit/Lost"].Points.AddXY("Earned Amount", txtbox_compare_trget_earned_amount.Text.Trim().ToString());

            }


        }

        private void Btn_compare_trget_find_Click(object sender, EventArgs e)
        {
            if (cmbbo_compare_trget_dept.SelectedItem == null || datetympkr_compare_trget.Value.ToString() == "")
            {
                MessageBox.Show("Fields Can't Be Empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtbox_compare_trget_earned_amount.Text = targets.retrieveProfit(cmbbo_compare_trget_dept.SelectedItem.ToString().Trim(), datetympkr_compare_trget.Value.ToString().Trim()).ToString();

            }


            /* txtbox_compare_trget_earned_amount.Text = targets.Retreive_Earned_Amounts(cmbbo_compare_trget_dept.SelectedItem.ToString().Trim(), datetympkr_compare_trget.Value.ToString().Trim()).ToString();*/
        }

        private void MetroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Txtbox_earned_profit_create_targets_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.chart_create_target_chart.Series["Profit"].Points.AddXY("2019-10-17", 800.4);
            this.chart_create_target_chart.Series["Profit"].Points.AddXY("2019-11-17", -6600.4);
        }

        private void CreateTargetchartButton_Click(object sender, EventArgs e)
        {
            if (txtbox_earned_profit_create_targets.Text.Trim().ToString() == "")
            {

                MessageBox.Show("Enter valid inpiuts in to date fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    //1 parameter ekata one fromdate time pkr value eka
                    //2 ta enne earned txtxbox value eka
                    this.chart_create_target_chart.Series["Profit/Lost"].Points.AddXY(datetympkr_create_target_fromDate.Text.Trim().ToString(), txtbox_earned_profit_create_targets.Text.Trim().ToString());
                    //1 parameter ekata one todate time pkr value eka
                    //2 ta enne task table eke amount eke agaya - select query ekakin
                    this.chart_create_target_chart.Series["Profit/Lost"].Points.AddXY(datetympkr_create_target_toDate.Text.Trim().ToString(), targets.retriewTargetAmountToMakeChart(datetympkr_create_target_toDate.Text.Trim().ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter valid inpiuts in to date fields!"+ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void BttnResetChart_Click(object sender, EventArgs e)
        {
            if (txtbox_earned_profit_create_targets.Text.Trim().ToString() == "")
            {

                MessageBox.Show("Enter valid inpiuts in to date fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                datetympkr_create_target_fromDate.Text = null;
                cmbbox_dept_create_target.Text = null;
                txtbox_earned_profit_create_targets.Text = null;
                datetympkr_create_target_toDate.Text = null;
                txtbox_percentage_create_targets.Text = null;

                //this.chart_create_target_chart.Series.Clear();
                this.chart_create_target_chart.Update();
                //this.chart_create_target_chart.Series.Clear();
                //this.chartControl1.Series[k].ResetSeriesModel()
                //this.chart_create_target_chart.ChartAreas.Clear();
            }

        }

        private void Bttnclear_Click(object sender, EventArgs e)
        {
            if (txtbox_earned_profit_create_targets.Text.Trim().ToString() == "")
            {

                MessageBox.Show("There is no values to clrear!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.chart_create_target_chart.Series.Clear();
            }
        }

        private void Btn_generate_report_cancle_Click(object sender, EventArgs e)
        {
            datetympkr_generate_report.Text = "";
            cmbbox_generate_report_dept.Text = null;
            cmbbox_generate_report_reportType.Text = null;
            
        }

        private void Btn_generate_report_genreport_Click(object sender, EventArgs e)
        {
            String date = datetympkr_generate_report.Text;
            String dept = cmbbox_generate_report_dept.Text;
            //Income Report
            if (cmbbox_generate_report_reportType.Text == "Income Report")
            {
                IncomeReportForm incomeReportForm = new IncomeReportForm(date, dept);
                incomeReportForm.Show();
            }
            else if (cmbbox_generate_report_reportType.Text == "Expense Report")
            {
                ExpenseReportForm expenseReportForm = new ExpenseReportForm(date, dept);
                expenseReportForm.Show();
            }
            else if (cmbbox_generate_report_reportType.Text == "Expenditure Report")
            {
                ExpenditureReportForm expenditureReportForm = new ExpenditureReportForm(date);
                expenditureReportForm.Show();
            }
            else if (cmbbox_generate_report_reportType.Text == "Profit/Lost Report")
            {
                ProfitLostReportForm profitLostReportForm = new ProfitLostReportForm(date,dept);
                profitLostReportForm.Show();
            }
            else if (cmbbox_generate_report_reportType.Text == "General Ledger")
            {
                GeneralLegerReportForm generalLegerReportForm = new GeneralLegerReportForm(date, dept);
                generalLegerReportForm.Show();
            }


        }
    }
    
}
