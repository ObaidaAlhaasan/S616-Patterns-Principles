using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        public string PrevContent { get; set; }
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            PrevContent = _document.Content;
            _document.MakeBold();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _document.SetContent(PrevContent);
        }
    }
}