using System;

namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public class ExcelReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }

        protected override string GetExtenstion()
        {
            return ".xls";
        }
    }
}