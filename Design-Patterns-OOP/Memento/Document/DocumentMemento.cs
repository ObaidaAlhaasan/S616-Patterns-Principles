namespace Design_Patterns_OOP.Memento.Document
{
    public class DocumentMemento
    {
        public string Content { get; private set; }
        public string FontName { get; private set; }
        public int FontSize { get; private set; }

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}