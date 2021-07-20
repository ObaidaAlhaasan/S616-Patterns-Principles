namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public abstract class DataReader
    {
        private DataReader Next;

        public void SetNext(DataReader reader) => Next = reader;

        public void Read(string fileName)
        {
            if (fileName.EndsWith(GetExtenstion()))
            {
                DoRead(fileName);
                return;
            }

            Next?.DoRead(fileName);
        }

        protected abstract void DoRead(string fileName);
        protected abstract string GetExtenstion();
    }
}