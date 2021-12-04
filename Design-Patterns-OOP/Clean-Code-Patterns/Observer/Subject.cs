using System.Collections.Generic;

namespace Design_Patterns_OOP.Clean_Code_Patterns.Observer
{
    public class Subject
    {
        public List<Observer> Observers { get; set; }

        public void Register(Observer o) => Observers.Add(o);

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
                observer.Update();
        }

        public void Remove(Observer o) => Observers.Remove(o);

        public void Clear() => Observers.Clear();
    }

    public class Observer
    {
        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}