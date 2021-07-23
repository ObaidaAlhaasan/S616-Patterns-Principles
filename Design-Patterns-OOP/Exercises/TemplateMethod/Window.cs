using System;

namespace Design_Patterns_OOP.Exercises.TemplateMethod
{
    public abstract class Window
    {
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Removing the window from the screen");

            OnClosed();
        }

        protected abstract void OnClosing();
        protected abstract void OnClosed();
    }

    internal class ChatWindow : Window
    {
        protected override void OnClosing()
        {
        }

        protected override void OnClosed()
        {
            Console.WriteLine("Disconnect from chat server");
        }
    }

    internal class FormWindow : Window
    {
        protected override void OnClosing()
        {
            Console.WriteLine("Alert user");
        }

        protected override void OnClosed()
        {
        }
    }
}