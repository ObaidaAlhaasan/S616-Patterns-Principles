namespace Design_Patterns_OOP.Memento.Document
{
    public class Document
    {
        public string Content { get; private set; }
        public string FontName { get; private set; }
        public int FontSize { get; private set; }
        public void SetContent(string content) => Content = content;
        public void SetFontName(string fontName) => FontName = fontName;

        public void SetFontSize(int fontSize) => FontSize = fontSize;

        public DocumentMemento CreateMemento() => new(Content, FontName, FontSize);

        public void Restore(DocumentMemento memento)
        {
            SetContent(memento.Content);
            SetFontName(memento.FontName);
            SetFontSize(memento.FontSize);
        }

        public override string ToString()
        {
            return "Document{" +
                   "content='" + Content + '\'' +
                   ", fontName='" + FontName + '\'' +
                   ", fontSize=" + FontSize +
                   '}';
        }
    }
}