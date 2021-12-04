using Design_Patterns_OOP.Creational.AbstractFactory.AntDesign;
using Design_Patterns_OOP.Creational.AbstractFactory.MterialDesign;

namespace Design_Patterns_OOP.Creational.AbstractFactory.App
{
    public class ContactForm
    {
        // problem that we will fix in abstract factory
        // public void Render(Theme theme)
        // {
        //     if (theme == Theme.Material)
        //     {
        //         new MaterialButton().Render();
        //         new MaterialTextBox().Render();
        //     }
        //     else if (theme == Theme.Ant)
        //     {
        //         new AntButton().Render();
        //         new AntTextBox().Render();
        //     }
        // }

        public void Render(IWidgetFactory factory)
        {
            factory.CreateButton().Render();
            factory.CreateTextBox().Render();
        }
    }

    public enum Theme
    {
        Material,
        Ant
    }
}