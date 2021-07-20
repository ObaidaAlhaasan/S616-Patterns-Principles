using System;

namespace Design_Patterns_OOP.TemplateMethodPattern.Window
{
    public abstract class WindowBase
    {
        public void Close()
        {
            OnClosing();
            Console.WriteLine("Removing the window from the screen");
            OnClosed();
        }

        protected virtual void OnClosing()
        {
            Console.WriteLine("Default onClosing");
        }

        protected virtual void OnClosed()
        {
            Console.WriteLine("Default onClosed");
        }
    }
}