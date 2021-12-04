namespace Design_Patterns_OOP.Clean_Code_Patterns.Observer
{
    public interface IObserver<T>
    {
        public void Update(T pushedData);
    }
}