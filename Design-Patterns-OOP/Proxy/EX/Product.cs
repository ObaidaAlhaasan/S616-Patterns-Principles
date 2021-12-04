using System;

namespace Design_Patterns_OOP.Proxy.EX
{
    public class Product
    {
        private int id;
        private String name;

        public Product(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public virtual void setName(String name)
        {
            this.name = name;
        }
    }
}