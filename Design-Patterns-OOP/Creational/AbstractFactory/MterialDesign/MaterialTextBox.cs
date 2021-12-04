using System;

namespace Design_Patterns_OOP.Creational.AbstractFactory.MterialDesign
{
    public class MaterialTextBox : ITextBox
    {
        public string content { get; set; }

        public void Render()
        {
            Console.WriteLine("Render TextBox in Material Design");
        }
    }
}