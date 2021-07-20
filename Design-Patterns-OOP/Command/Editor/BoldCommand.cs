using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        public string PrevContent { get; set; }
        private HtmlDocument Document;
        private History History;

        public BoldCommand(HtmlDocument document, History history)
        {
            Document = document;
            History = history;
        }

        public void Execute()
        {
            PrevContent = Document.Content;
            Document.MakeBold();
            History.Push(this);
        }

        public void UnExecute()
        {
            Document.SetContent(PrevContent);
        }
    }
}