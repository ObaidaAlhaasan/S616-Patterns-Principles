using System;

namespace Design_Patterns_OOP.State
{
    public class BrushTool : CanvasTool

    {
        public override void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public override void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}