namespace Design_Patterns_OOP.Memento.Editor
{
    public class Editor
    {
        public string Content { get; private set; }
        public EditorHistory EditorHistory { get; set; }

        public Editor() => EditorHistory = new EditorHistory();

        public void SetContent(string s) => Content += s;

        public EditorState CreateState() => new(Content);

        public void Restore(EditorState state) => Content = state.Content;
    }
}