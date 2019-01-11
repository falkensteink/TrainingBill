using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingBill
{
    public class Expense
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }

        Database db = new Database();
        public void getExpenses(string Owner, int Month)
        {
           // ArrayList Expenses = db.DBGet(GenerateMonthlyBill(Owner, Month));

        }
        public ArrayList GenerateMonthlyBill(string Owner, int Month)
        
        {
            string [] Horses  = getHorsesByOwner(Owner);
            ArrayList MonthlyExpenses = new ArrayList();

            for (int x = 0; x< Horses.Length; x++)
            {
               MonthlyExpenses.Add(getMonthlyBill(Horses[x], Month));
            }
            return MonthlyExpenses;
            // todo make expense list not Arraylist

        }

        public ArrayList getMonthlyBill(string HorseName, int Month)
        {
            string sql = "SELECT Expenses.ExpenseCost, Expenses.ExpenseType, Expenses.ExpenseQuantity, Expenses.ExpenseQuantityType FROM Expenses Inner Join Horses on Horses.HorseName = Expenses.HorseName WHERE(((Horses.OwnerName) =[Name]) AND((Expenses.ExpenseMonth) =[Month]));";







            Expense HorseExpenses  = new Expense();
                db.DBGet(sql);
            
            return HorseExpenses;
        }
        public string [] getHorsesByOwner (string Owner)
        {
            string sql = "SELECT HorseName from Horses where Horses.OwnerName = "+Owner+"";
            string [] Horses = db.DBGet(sql).ToArray(typeof(string)) as string [];
            return Horses;
        }





    }
}



