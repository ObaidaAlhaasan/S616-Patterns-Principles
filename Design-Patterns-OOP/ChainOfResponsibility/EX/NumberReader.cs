using System;

namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public class NumberReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet: ");
        }

        protected override string GetExtenstion()
        {
            return ".numbers";
        }
    }
}