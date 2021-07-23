using System.Collections.Generic;

namespace Design_Patterns_OOP
{
    public class ArrayList<T> : List<T> // Adapter between ArrayList - List Java-C#
    {
        public void add(T item)
        {
            Add(item);
        }
    }
}