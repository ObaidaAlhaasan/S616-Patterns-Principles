using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Exercises.Observer
{
    public class StatusBar : Observer
    {
        private List<Stock> _stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
        }

        public void Show()
        {
            foreach (var stock in _stocks)
                Console.WriteLine(stock);
        }

        public override void PriceChanged()
        {
            Show();
        }
    }
}