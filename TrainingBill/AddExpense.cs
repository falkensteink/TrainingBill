using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingBill
{
    public partial class AddExpense : Form
    {
        public Horse horse;
        public Expense expense = new Expense();
        public MonthlyRollup parent;
        public AddExpense(Horse _horse, MonthlyRollup _parent)
        {
            InitializeComponent();
            horse = _horse;
            parent = _parent;
        }
        Database db = new Database();
        private void AddExpense_Load(object sender, EventArgs e)
        {
           
            Intro.Text = "Adding an expense to " + horse.Name + " owned by " + horse.Owner + ".";
            cbExpenseTypes.DataSource = db.DBGet(GenerateExpenseTypes());
            cbExpenseTypes.Text = "";
            MonthLoader();
         
        }       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            expense.Cost = Convert.ToInt32(txtExpenseAmount.Text);
            expense.Month = MonthToNum(cbMonth.Text);
            if (cbExpenseTypes.Text != null)
                {
                expense.Type = cbExpenseTypes.Text;
                if (cbExpenseTypes.Items.Contains(cbExpenseTypes.Text))
                { }
                else {
                    db.DBWrite(GeneratePutExpenseType("Expense", expense.Type));
                }
            }
            else{
                expense.Type = cbExpenseTypes.SelectedValue.ToString();
            }
            bool success = db.DBWrite(GeneratePutExpense(expense));
            if (success)
            {
                string message = "Expense of $" + expense.Cost + " for " +  expense.Type + " has been added to " + horse.Name + " for the month of " + cbMonth.SelectedItem.ToString() + ".";
                string caption = "Expense Added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
                ResetForm();
            }
            else
            {

            }
            }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.RollupRefresh();
            this.Close();
        }
        public string GeneratePutExpense(Expense expense)
        {
            string sql;
            sql = "INSERT INTO Expenses(ExpenseType, ExpenseCost, ExpenseMonth, HorseName) VALUES(\"" + expense.Type + "\"," + expense.Cost + "," + expense.Month + ",\"" + horse.Name + "\");";
            return sql;
        }
        public string GenerateExpenseTypes()
        {
            string sql;
            sql = "SELECT LookValue FROM Lookup Where LookType = \"Expense\";";
            return sql;
        }
        public string GeneratePutExpenseType(string LookType, string LookValue)
        {
            string sql;
            sql = "INSERT INTO Lookup(LookType, LookValue) VALUES(\"" + LookType + "\",\"" + LookValue + "\");";
            return sql;
        }
        public int MonthToNum(string Month)
        {
            
            if (Month == "January")
            {
               return 1;
            }
           else if (Month == "Febuary")
            {
                return 2;
            }

            else if(Month == "March")
            {
                return 9;
            }
            else if(Month == "April")
            {
                return 4;
            }

            else if(Month == "May")
            {
                return 5;
            }
            else if(Month == "June")
            {
                return 6;
            }
            else if(Month == "July")
            {
                return 7;
            }
            else if(Month == "August")
            {
                return 8;
            }
            else if(Month == "September")
            {
                return 9;
            }
            else if (Month == "October")
            {
                return 10;
            }
            else if (Month == "November")
            {
                return 11;
            }
            else if (Month == "December")
            {
                return 12;
            }
            else
            {
                return 1;
            }


        }
        public void MonthLoader()
        {
            cbMonth.Items.Add("January");
            cbMonth.Items.Add("Febuary");
            cbMonth.Items.Add("March");
            cbMonth.Items.Add("April");
            cbMonth.Items.Add("May");
            cbMonth.Items.Add("June");
            cbMonth.Items.Add("July");
            cbMonth.Items.Add("August");
            cbMonth.Items.Add("September");
            cbMonth.Items.Add("October");
            cbMonth.Items.Add("November");
            cbMonth.Items.Add("December");
        }
        public void ResetForm()
        {
            txtExpenseAmount.Text = "";
           

        }

       
    }
}
