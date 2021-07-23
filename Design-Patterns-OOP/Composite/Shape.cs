using System;

namespace Design_Patterns_OOP.Composite
{
    public class Shape : IComponent
    {
        public void Render() => Console.WriteLine("Render Shape");

        public void Resize() => Console.WriteLine("Resize Shape");

        public void Move(int x, int y) => Console.WriteLine($"Move Shape to x {x}  ey{ y}");
    }
}