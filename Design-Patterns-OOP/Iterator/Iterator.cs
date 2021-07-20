using System.Linq;

namespace Design_Patterns_OOP.Iterator
{
    public abstract class Iterator<T>
    {
        public abstract bool HasNext();
        public abstract void Next();
        public abstract string Current();
    }

    public class ArrayIterator : Iterator<BrowseHistory>
    {
        public override bool HasNext()
        {
            return false;
        }

        public override void Next()
        {
            throw new System.NotImplementedException();
        }

        public override string Current()
        {
            return null;
        }
    }


    public class ListIterator : Iterator<BrowseHistory>
    {
        public BrowseHistory History { get; }
        private int index { get; set; }

        public ListIterator(BrowseHistory history)
        {
            History = history;
        }

        public override bool HasNext()
        {
            return index < History.Urls.Length;
        }

        public override void Next()
        {
            index++;
        }

        public override string Current()
        {
            return History.Urls.ElementAt(index);
        }
    }
}