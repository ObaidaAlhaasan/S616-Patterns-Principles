namespace Design_Patterns_OOP.Command.Framework
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