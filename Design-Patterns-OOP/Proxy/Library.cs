using System.Collections.Generic;
using System.Xml;

namespace Design_Patterns_OOP.Proxy
{
    public class Library
    {
        private Dictionary<string, EBook> _books = new();

        public void Add(EBook book)
        {
            _books.TryAdd(book.FileName, book);
        }

        public void OpenEbook(string fileName)
        {
            _books.TryGetValue(fileName, out var book);
            book?.Show();
        }
    }
}