using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;



namespace TrainingBill
{
    class MSExcel
    {

        public  void Main()
        {

            Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook wb =  CreateWorkbook(App);
            Excel.Worksheet ws1;
            ws1 = wb.Worksheets.get_Item(1);

            App.Quit();

            Marshal.ReleaseComObject(ws1);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(App);
         
        }
        public Excel.Worksheet MakeHeaders( Excel.Worksheet WorkSheet )
        {
            WorkSheet.Cells[1, 1] = "Quantity";
            WorkSheet.Cells[1, 2] = "Description";
            WorkSheet.Cells[1, 3] = "Unit Price";
            WorkSheet.Cells[1, 4] = "Total";
            return WorkSheet;
        }
        public Excel.Worksheet AddExpense(Excel.Worksheet WorkSheet, Expense Expense, int Row, int Column)
        {
            WorkSheet.Cells[Row, Column] = Expense.Quantity;
            WorkSheet.Cells[Row, Column] = Expense.Description;
            WorkSheet.Cells[Row, Column] = Expense.UnitPrice;
            WorkSheet.Cells[Row, Column] = Expense.Total;

            return WorkSheet;
        }
        public Excel.Workbook CreateWorkbook(Excel.Application App)
        {
   
            Excel.Workbook xlWorkBook;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = App.Workbooks.Add(misValue);
            return xlWorkBook;
        }
        public void SaveCloseWb(Excel.Workbook WorkBook, string filePath, string FileName)
        {
            string fullPath = filePath + FileName;
            WorkBook.SaveAs(fullPath);
            WorkBook.Close(true);
        }


    }
}
