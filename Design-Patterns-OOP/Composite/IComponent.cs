namespace Design_Patterns_OOP.Composite
{
    public interface IComponent
    {
        public void Render();
        public void Resize();

        public void Move(int x, int y);
    }
}