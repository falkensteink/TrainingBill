using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;



namespace TrainingBill
{
    public partial class MonthlyRollup : Form
    {
        public MonthlyRollup()
        {
            InitializeComponent();
        }

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

        private void MonthlyRollup_Load(object sender, EventArgs e)
        {
           
            RollupRefresh();

        }
        public string GenerateRollup()
        {
            string sqlRollup;
            string CurrentMonth = DateTime.Now.Month.ToString();
            sqlRollup = "SELECT Horses.HorseName AS Horse, Horses.OwnerName AS Owner, Sum(Expenses.ExpenseCost) AS MonthlyExpenses FROM(Horses LEFT JOIN Expenses ON Expenses.HorseName = Horses.HorseName) WHERE ExpenseMonth = " + CurrentMonth + " GROUP BY Horses.HorseName, Horses.OwnerName;";
            return sqlRollup;
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            //Load Second form with all infomation on Selected horse
            
            
            AddExpense add = new AddExpense();
            add.HorseName = HorseName;
            add.OwnerName = OwnerName;
            this.Hide();
            add.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnMiscExpense_Click(object sender, EventArgs e)
        {
            AddExpense add = new AddExpense();
            add.HorseName = "Miscellaneous Expenses";
            add.OwnerName = "Jerry Seekman";
            this.Hide();
            add.Show();
        }
        public void dgvMonthlyRollup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HorseName = dgvMonthlyRollup.CurrentRow.Cells[0].Value.ToString();
            OwnerName = dgvMonthlyRollup.CurrentRow.Cells[1].Value.ToString();
            MonthlyExpense = dgvMonthlyRollup.CurrentRow.Cells[2].Value.ToString();


        }
        private void preloadValues()
        {
            HorseName = dgvMonthlyRollup.CurrentRow.Cells[0].Value.ToString();
            OwnerName = dgvMonthlyRollup.CurrentRow.Cells[1].Value.ToString();
            MonthlyExpense = dgvMonthlyRollup.CurrentRow.Cells[2].Value.ToString();
        }
        public void RollupRefresh()
        {
            Database db = new Database();
           dgvMonthlyRollup.DataSource = db.ExecuteDBCommands(GenerateRollup());
            preloadValues();
        }
    }
}
