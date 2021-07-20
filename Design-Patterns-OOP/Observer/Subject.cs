namespace Design_Patterns_OOP.Observer
{
    // Observable
    public abstract class Subject
    {
        public abstract void AddObserver(Observer observer);
        public abstract bool RemoveObserver(Observer observer);
        public abstract void NotifyObservers();
    }
}