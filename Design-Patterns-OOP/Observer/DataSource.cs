using System.Collections.Generic;

namespace Design_Patterns_OOP.Observer
{
    public class DataSource : Subject
    {
        public int Value { get; private set; }
        private List<Observer> Observers { get; set; } = new();

        public void SetValue(int val)
        {
            Value = val;
            NotifyObservers();
        }

        public override void AddObserver(Observer observer) => Observers.Add(observer);

        public override bool RemoveObserver(Observer observer) => Observers.Remove(observer);

        public override void NotifyObservers()
        {
            foreach (var observer in Observers) observer.Update();
        }
    }
}