namespace Design_Patterns_OOP.Creational.AbstractFactory
{
    public interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}