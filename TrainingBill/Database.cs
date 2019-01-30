using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace TrainingBill
{
    class Database
    {
        string TrainingBillconnection = ConfigurationManager.ConnectionStrings["TrainingBill.Properties.Settings.TrainingBillConnectionString"].ConnectionString;
        public DataTable ExecuteDBCommands(string sql)
        {
            DataTable Rollup = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(TrainingBillconnection))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    Rollup.Load(reader);
                }
            }
            return Rollup;
        }
        public bool DBWrite(string sql)
        {
            bool boolsuccess;
            using (OleDbConnection connection = new OleDbConnection(TrainingBillconnection))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    int success = command.ExecuteNonQuery();
                    if (success >= 1)
                    {
                        boolsuccess = true;

                    }
                    else
                    {
                        boolsuccess = false;
                    }
                    return boolsuccess;
                }
            }
        }
        public ArrayList DBGet(string sql)
        {
            ArrayList Values = new ArrayList();
            using (OleDbConnection connection = new OleDbConnection(TrainingBillconnection))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = null;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Values.Add(reader.GetString(0));
                    }

                }
            }
            return Values;
        }
        public List<Expense> DBGetExpense(string owner, int month)
        {
            string sql = "SELECT Expenses.ExpenseCost, Expenses.ExpenseType, Expenses.ExpenseQuantity, Expenses.ExpenseQuantityType FROM Expenses Inner Join Horses on Horses.HorseName = Expenses.HorseName WHERE(((Horses.OwnerName) ="+owner+ ") AND((Expenses.ExpenseMonth) =" + month + "));";
            List<Expense> expense = new List<Expense>();
            Expense temp = new Expense();
            using (OleDbConnection connection = new OleDbConnection(TrainingBillconnection))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = null;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp.Cost = Convert.ToInt32(reader.GetString(0));
                        temp.Type = reader.GetString(1);
                        temp.Quantity = Convert.ToInt32(reader.GetString(2));
                        temp.QuantityType = reader.GetString(3);
                        expense.Add(temp);
                        temp = new Expense();
                    }
                }
            }
            return expense;
        }
        public string[] getHorsesByOwner(string Owner)
        {
            string sql = "SELECT HorseName from Horses where Horses.OwnerName = " + Owner + "";
            string[] Horses =DBGet(sql).ToArray(typeof(string)) as string[];
            return Horses;
        }
        public string[] getHorses()
        {
            string sql = "SELECT HorseName from Horses";
            string[] Horses =DBGet(sql).ToArray(typeof(string)) as string[];
            return Horses;
        }
        public string[] getOwners()
        {
            string sql = "SELECT OwnerName from Owners";
            string[] Owners = DBGet(sql).ToArray(typeof(string)) as string[];
            return Owners;
        }

       }
}
