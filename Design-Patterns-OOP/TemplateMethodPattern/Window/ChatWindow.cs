using System;

namespace Design_Patterns_OOP.TemplateMethodPattern.Window
{
    public class ChatWindow : WindowBase
    {
        protected override void OnClosing()
        {
            Console.WriteLine("Disconnecting from the server...");
        }
    }
}