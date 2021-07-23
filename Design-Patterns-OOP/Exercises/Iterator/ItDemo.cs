using System;

namespace Design_Patterns_OOP.Exercises.Iterator
{
    public class ItDemo
    {
        public static void Show()
        {
            var pc = new ProductCollection();

            pc.Add(new Product(1, "1"));
            pc.Add(new Product(2, "2"));
            pc.Add(new Product(3, "3"));
            while (pc.HasNext())
            {
                Console.WriteLine(pc.Current().Id + "  " + pc.Current().Name);
                pc.Next();
            }
        }
    }
}