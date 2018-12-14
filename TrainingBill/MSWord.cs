using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;


namespace TrainingBill
{
    class MSWord
    {
        public static void Main()
        {
            string fileName = "C:\invoice.docx";

            Application ap = new Application();
            Document document = ap.Documents.Open(fileName);

            // Loop through all words in the document.
            int count = document.Words.Count;
            for (int i = 1; i <= count; i++)
            {
                // Write the word.
                string text = document.Words[i].Text;
                Console.WriteLine("Word {0} = {1}", i, text);
            }
            // Close word.
            application.Quit();  // Loop through all words in the document.
            int count = document.Words.Count;
            for (int i = 1; i <= count; i++)
            {
                // Write the word.
                string text = document.Words[i].Text;
                Console.WriteLine("Word {0} = {1}", i, text);
            }
            // Close word.
            application.Quit();
        }
}
