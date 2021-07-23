namespace Design_Patterns_OOP.Exercises.TemplateMethod
{
    public class Demo
    {
        public static void Show()
        {
            Window chatWindow = new ChatWindow();
            chatWindow.Close();

            Window formWindow = new FormWindow();
            formWindow.Close();
        }
    }
}