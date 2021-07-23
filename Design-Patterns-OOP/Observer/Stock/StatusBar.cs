using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_OOP.Observer.Stock
{
    public class StatusBar : Observer
    {
        private List<Stock> _stocks = new();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in _stocks)
                Console.WriteLine(stock);
        }

        public override void Update()
        {
            Console.WriteLine("Price Changed - Refreshing StatusBar");
            Show();
        }
    }
}