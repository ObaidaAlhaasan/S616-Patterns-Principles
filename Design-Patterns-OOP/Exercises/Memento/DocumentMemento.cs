namespace Design_Patterns_OOP.Exercises.Memento
{
    public class DocumentMemento
    {
        public string Content { get; }
        public string FontName { get; }
        public int FontSize { get; }

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}