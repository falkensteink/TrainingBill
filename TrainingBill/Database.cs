using System.Collections;
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
    }
}
