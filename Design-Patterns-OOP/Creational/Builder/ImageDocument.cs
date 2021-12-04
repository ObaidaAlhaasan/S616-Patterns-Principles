using System;

namespace Design_Patterns_OOP.Creational.Builder
{
    public class ImageDocument : IPresentationDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine("Adding Page to ImageDocument");
        }
    }
}