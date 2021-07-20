using System.Collections.Generic;

namespace Design_Patterns_OOP.Observer.Stock
{
    public class Stock : Subject
    {
        private string _symbol;
        private float _price;
        private IList<Observer> Observers = new List<Observer>();

        public Stock(string symbol, float price)
        {
            _symbol = symbol;
            _price = price;
        }

        public float GetPrice() => _price;

        public void SetPrice(float price)
        {
            _price = price;
            NotifyObservers();
        }


        public override string ToString()
        {
            return "Stock{" +
                   "symbol='" + _symbol + '\'' +
                   ", price=" + _price +
                   '}';
        }

        public override void AddObserver(Observer observer) => Observers.Add(observer);

        public override bool RemoveObserver(Observer observer) => Observers.Remove(observer);

        public override void NotifyObservers()
        {
            foreach (var observer in Observers) observer.Update();
        }
    }
}