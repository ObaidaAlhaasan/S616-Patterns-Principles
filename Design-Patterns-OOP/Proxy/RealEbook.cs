using System;

namespace Design_Patterns_OOP.Proxy
{
    public class RealEbook : EBook
    {
        public RealEbook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Load From DB");
        }

        public override void Show()
        {
            Console.WriteLine("Open from DB");
        }
    }
}