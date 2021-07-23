using System;


namespace Design_Patterns_OOP.Exercises.ChainOfResponsibility
{
    public abstract class Reader
    {
        private Reader _next;

        public void Read(string fileName)
        {
            if (fileName.EndsWith(Extensions()))
                DoRead(fileName);


            _next?.Read(fileName);
        }

        public void SetNext(Reader next)
        {
            _next = next;
        }


        public abstract string Extensions();
        protected abstract void DoRead(string fileName);
    }

    public class ExcelReader : Reader
    {
        public override string Extensions() => ".xls";

        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
            Console.WriteLine($"Reading Excel {fileName}");
        }
    }

    public class NumberReader : Reader
    {
        public override string Extensions() => ".number";

        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet.");
            Console.WriteLine($"Reading Number {fileName}");
        }
    }

    public class QuickBookReader : Reader
    {
        public override string Extensions() => ".qbw";

        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
            Console.WriteLine($"Reading QuickBook {fileName}");
        }
    }
}