using System;

namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public class QuickBookReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }

        protected override string GetExtenstion()
        {
            return ".qbw";
        }
    }
}