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
        public string QuantityType { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
        public int Month { get; set; }
        public string Horse { get; set; }

        Database db = new Database();
        public void getExpenses(string Owner, int Month)
        {
        

        }
        //public ArrayList GenerateMonthlyBill(string Owner, int Month)
        
        //{
        //    //string [] Horses  = getHorsesByOwner(Owner);
        //    //ArrayList MonthlyExpenses = new ArrayList();

        //    //for (int x = 0; x< Horses.Length; x++)
        //    //{
        //    //   MonthlyExpenses.Add(getMonthlyBill(Horses[x], Month));
        //    //}
        //    //return MonthlyExpenses;
        //    // todo make expense list not Arraylist

        //}







    }
}



