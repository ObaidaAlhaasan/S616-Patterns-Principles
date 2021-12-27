using Design_Patterns_OOP.Creational.AbstractFactory.App;
using Design_Patterns_OOP.Creational.AbstractFactory.EX;

namespace Design_Patterns_OOP.Creational.AbstractFactory
{
    public class AbstractFactoryDemo
    {
        public static void Show()
        {
            var form = new ContactForm();
            form.Render(new MaterialWidgetFactory());

            form.Render(new AntWidgetFactory());
        }

        public static void ExShow()
        {
            var homePage = new HomePage();
            homePage.setGoal(new BuildMuscleFactory());
        }
    }
}