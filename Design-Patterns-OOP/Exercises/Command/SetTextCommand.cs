using Design_Patterns_OOP.Command.Editor;

namespace Design_Patterns_OOP.Exercises.Command
{
    public class SetTextCommand : AbstractUndoableCommand
    {
        public string Text { get; }
        public VideoEditor VideoEditor { get; }
        public EditorHistory History { get; }

        public SetTextCommand(string text, VideoEditor videoEditor, EditorHistory history) : base(videoEditor, history)
        {
            Text = text;
            VideoEditor = videoEditor;
            History = history;
        }

        protected override void DoExecute()
        {
            VideoEditor.SetText(Text);
        }

        public override void UnExecute()
        {
            VideoEditor.RemoveText();
        }
    }


    public interface ICommand
    {
        public void Execute();
    }

    public interface IUndoableCommand : ICommand
    {
        public void UnExecute();
    }
}