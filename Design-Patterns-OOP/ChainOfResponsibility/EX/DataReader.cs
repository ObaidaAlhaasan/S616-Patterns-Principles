namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public abstract class DataReader
    {
        private DataReader _next;

        public void SetNext(DataReader reader) => _next = reader;

        public void Read(string fileName)
        {
            if (fileName.EndsWith(GetExtenstion()))
            {
                DoRead(fileName);
                return;
            }

            _next?.DoRead(fileName);
        }

        protected abstract void DoRead(string fileName);
        protected abstract string GetExtenstion();
    }
}