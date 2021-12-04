using System;

namespace Design_Patterns_OOP.Creational.Builder
{
    public class PdfDocument : IPresentationDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine("Adding Page to PdfDocument");
        }
    }
}