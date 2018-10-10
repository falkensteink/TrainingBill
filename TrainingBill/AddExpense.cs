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
        public string month;
        private string horseName;
        private string ownerName;
        private string monthlyExpense;
        public string HorseName
        {
            get
            {
                return horseName;
            }

            set
            {
                horseName = value;
            }
        }
        public string OwnerName
        {
            get
            {
                return ownerName;
            }

            set
            {
                ownerName = value;
            }
        }
        public string MonthlyExpense
        {
            get
            {
                return monthlyExpense;
            }

            set
            {
                monthlyExpense = value;
            }
        }
        public AddExpense()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void AddExpense_Load(object sender, EventArgs e)
        {
           
            Intro.Text = "Adding an expense to " + this.HorseName + " owned by " + this.OwnerName + ".";
            cbExpenseTypes.DataSource = db.DBGet(GenerateExpenseTypes());
            cbExpenseTypes.Text = "";
            MonthLoader();
         
        }       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string ExpenseType;
            if (cbExpenseTypes.Text != null)
                {ExpenseType = cbExpenseTypes.Text;
                if (cbExpenseTypes.Items.Contains(cbExpenseTypes.Text)) { }
                else { db.DBWrite(GeneratePutExpenseType("Expense", ExpenseType)); }  }
            else{ExpenseType = cbExpenseTypes.SelectedValue.ToString();
            }
            bool success = db.DBWrite(GeneratePutExpense(ExpenseType, txtExpenseAmount.Text, MonthToNum(cbMonth.SelectedItem.ToString()), HorseName));
            if (success)
            {
                string message = "Expense of $" + txtExpenseAmount.Text + " for " + ExpenseType + " has been added to " + HorseName + " for the month of " + cbMonth.SelectedItem.ToString() + ".";
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
            MonthlyRollup MR = new MonthlyRollup();
            MR.Show();
            MR.RollupRefresh();
            this.Close();
        }
        public string GeneratePutExpense(string ExpenseType, string ExpenseCost, int Month, string HorseName)
        {
            string sql;
            sql = "INSERT INTO Expenses(ExpenseType, ExpenseCost, ExpenseMonth, HorseName) VALUES(\"" + ExpenseType + "\"," + ExpenseCost + "," + Month + ",\"" + HorseName + "\");";
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
