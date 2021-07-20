using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Observer.Stock
{
    public class StockListView : Observer
    {
        private List<Stock> stocks = new();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public void Show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }

        public override void Update()
        {
            Console.WriteLine("Price Changed - Refreshing StatusBar");
            Show();
        }
    }
}