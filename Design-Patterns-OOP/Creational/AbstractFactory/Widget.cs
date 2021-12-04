namespace Design_Patterns_OOP.Creational.AbstractFactory
{
    public interface IWidget
    {
    }

    public class Widget : IWidget
    {
    }

    public interface IButton : IWidget
    {
        public void Render();
    }

    public interface ITextBox : IWidget
    {
        string content { get; set; }
        public void Render();
    }
}