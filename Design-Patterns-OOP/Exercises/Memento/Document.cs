namespace Design_Patterns_OOP.Exercises.Memento
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetFontName()
        {
            return _fontName;
        }

        public void SetFontName(string fontName)
        {
            _fontName = fontName;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }

        public DocumentMemento CreateMemento() => new(_content, _fontName, _fontSize);

        public void Restore(DocumentMemento memento)
        {
            SetContent(memento.Content);
            SetFontName(memento.FontName);
            SetFontSize(memento.FontSize);
        }
    }
}