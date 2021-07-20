using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_OOP.Iterator
{
    public class BrowseHistory
    {
        public string[] Urls { get; private set; } = new string[10];
        private int Count { get; set; }
        public void Push(string url) => Urls[Count++] = url;
        public Iterator<BrowseHistory> CreateIterator() => new ListIterator(this);

        public string Pop()
        {
            var l = Urls[Count];
            Urls[Count] = "";
            return l;
        }
    }
}