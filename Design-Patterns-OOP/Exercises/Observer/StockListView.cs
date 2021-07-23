using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Exercises.Observer
{
    public class StockListView : Observer
    {
        private List<Stock> _stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Stock List View");
            foreach (var stock in _stocks)
                Console.WriteLine(stock);
        }


        public override void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StockListView");
            Show();
        }
    }
}