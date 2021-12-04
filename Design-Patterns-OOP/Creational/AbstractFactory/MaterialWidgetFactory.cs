using Design_Patterns_OOP.Creational.AbstractFactory.MterialDesign;

namespace Design_Patterns_OOP.Creational.AbstractFactory
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MaterialTextBox();
        }
    }
}