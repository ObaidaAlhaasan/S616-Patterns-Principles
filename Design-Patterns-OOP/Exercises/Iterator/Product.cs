using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_OOP.Exercises.Iterator
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }

        public Product(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return "Product{" +
                   "id=" + Id +
                   ", name='" + Name + '\'' +
                   '}';
        }
    }

    public class ProductCollection : IIterator<Product>
    {
        private List<Product> _products = new();
        private int Index { get; set; }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public bool HasNext() => Index < _products.Count;

        public Product Current() => _products.ElementAtOrDefault(Index);

        public void Next() => Index++;
    }

    public interface IIterator<out T>
    {
        public bool HasNext();
        public T Current();
        public void Next();
    }
}