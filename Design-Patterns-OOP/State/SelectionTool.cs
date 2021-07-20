using System;

namespace Design_Patterns_OOP.State
{
    public class SelectionTool : CanvasTool

    {
        public override void MouseDown()
        {
            Console.WriteLine("Selecting icon");
        }

        public override void MouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}