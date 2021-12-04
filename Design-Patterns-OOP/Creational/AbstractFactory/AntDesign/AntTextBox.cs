using System;

namespace Design_Patterns_OOP.Creational.AbstractFactory.AntDesign
{
    public class AntTextBox : ITextBox
    {
        public string content { get; set; }

        public void Render()
        {
            Console.WriteLine("Render TextBox in Ant Design");
        }
    }
}