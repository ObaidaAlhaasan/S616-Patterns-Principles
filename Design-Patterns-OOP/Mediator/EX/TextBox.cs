namespace Design_Patterns_OOP.Mediator.EX
{
    public class TextBox : UiControl
    {
        public string Type { get; private set; }
        public string Content { get; private set; }
        public bool IsEmpty => string.IsNullOrWhiteSpace(Content);

        public void SetType(string type)
        {
            Type = type;
        }

        public void SetContent(string content)
        {
            Content = content;
            NotifyEventHandlers();
        }
    }
}