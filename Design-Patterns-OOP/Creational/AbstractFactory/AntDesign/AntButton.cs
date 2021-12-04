using System;

namespace Design_Patterns_OOP.Creational.AbstractFactory.AntDesign
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Button in Ant Design");
        }
    }
}