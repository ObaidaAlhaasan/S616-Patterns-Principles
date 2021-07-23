namespace Design_Patterns_OOP.Facade
{
    public class Message
    {
        public string Content { get; private set; }

        public void SetContent(string content) => Content = content;
    }
}