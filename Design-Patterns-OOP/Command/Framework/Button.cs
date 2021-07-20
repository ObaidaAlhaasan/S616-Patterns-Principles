using System;

namespace Design_Patterns_OOP.Command
{
    public class Button
    {
        public string Label { get; private set; }
        public ICommand Command { get; private set; }

        public Button(string label, ICommand command)
        {
            Label = label;
            Command = command;
        }

        public void Click()
        {
            Command.Execute();
        }
    }
}