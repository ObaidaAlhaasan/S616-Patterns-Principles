using System;
using System.Collections.Generic;
using Design_Patterns_OOP.Observer;

namespace Design_Patterns_OOP.Exercises.Observer
{
    public class Stock : Subject
    {
        private string _symbol;
        private float _price;
        public IList<Observer> Observers { get; set; } = new List<Observer>();

        public Stock(string symbol, float price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public float GetPrice()
        {
            return _price;
        }

        public void SetPrice(float price)
        {
            this._price = price;
            Notify();
        }

        public override string ToString()
        {
            return "Stock{" +
                   "symbol='" + _symbol + '\'' +
                   ", price=" + _price +
                   '}';
        }

        public override void AddObserver(Observer ob)
        {
            Observers.Add(ob);
        }

        public override bool RemoveObserver(Observer ob)
        {
            return Observers.Remove(ob);
        }

        public override void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.PriceChanged();
            }
        }
    }

    public abstract class Subject
    {
        public abstract void AddObserver(Observer ob);
        public abstract bool RemoveObserver(Observer ob);
        public abstract void Notify();
    }

    public abstract class Observer
    {
        public abstract void PriceChanged();
    }
}