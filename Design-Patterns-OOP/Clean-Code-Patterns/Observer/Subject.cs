using System.Collections.Generic;

namespace Design_Patterns_OOP.Clean_Code_Patterns.Observer
{
    public class Subject<T>
    {
        private List<IObserver<T>> Observers { get; set; }

        public void Register(IObserver<T> o) => Observers.Add(o);

        public void NotifyObservers(T pushedData)
        {
            foreach (var observer in Observers)
                observer.Update(pushedData);
        }

        public void Remove(IObserver<T> o) => Observers.Remove(o);

        public void Clear() => Observers.Clear();
    }
}