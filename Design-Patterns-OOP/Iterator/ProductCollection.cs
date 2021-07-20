using System.Collections.Generic;

namespace Design_Patterns_OOP.Iterator
{
    public class ProductCollection
    {
        private IList<Product> Products { get; } = new List<Product>();

        public void Add(Product product) => Products.Add(product);

        public Iterator<ProductCollection> CreateIterator()
        {
            return new ProductIterator(this);
        }

        public class ProductIterator : Iterator<ProductCollection>
        {
            private readonly ProductCollection _collection;
            private int Index { get; set; }

            public ProductIterator(ProductCollection collection)
            {
                _collection = collection;
            }

            public override bool HasNext()
            {
                return Index < _collection.Products.Count;
            }

            public override void Next()
            {
                Index++;
            }

            public override string Current()
            {
                return _collection.Products[Index].Name;
            }
        }
    }
}