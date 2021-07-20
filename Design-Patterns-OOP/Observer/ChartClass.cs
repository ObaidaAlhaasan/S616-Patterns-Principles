using System;

namespace Design_Patterns_OOP.Observer
{
    public class ChartClass : Observer
    {
        private DataSource DataSource { get; }

        public ChartClass(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public override void Update()
        {
            Console.WriteLine("Chart Updates...." + DataSource.Value);
        }
    }
}