namespace Design_Patterns_OOP.State
{
    public class Canvas
    {
        public CanvasTool CurrentToole { get; private set; }

        public void MouseDown() => CurrentToole.MouseDown();

        public void MouseUp() => CurrentToole.MouseUp();

        public void SetCurrentTool(CanvasTool tool) => CurrentToole = tool;
    }
}