using System;

namespace Design_Patterns_OOP.Creational.AbstractFactory.MterialDesign
{
    public class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Button in Material Design");
        }
    }
}