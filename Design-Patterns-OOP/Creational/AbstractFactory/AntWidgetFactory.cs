using Design_Patterns_OOP.Creational.AbstractFactory.AntDesign;

namespace Design_Patterns_OOP.Creational.AbstractFactory
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AntTextBox();
        }
    }
}