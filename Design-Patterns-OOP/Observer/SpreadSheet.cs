using System;

namespace Design_Patterns_OOP.Observer
{
    public class SpreadSheet : Observer
    {
        private DataSource DataSource { get; }

        public SpreadSheet(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public override void Update()
        {
            Console.WriteLine("SpreadSheet Updates...." + DataSource.Value);
        }
    }
}