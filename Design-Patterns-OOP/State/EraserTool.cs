using System;

namespace Design_Patterns_OOP.State
{
    public class EraserTool : CanvasTool

    {
        public override void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public override void MouseUp()
        {
            Console.WriteLine("Eraser something");
        }
    }
}