using Design_Patterns_OOP.Command.Editor;

namespace Design_Patterns_OOP.Command.VideoEditor
{
    public class SetTextCommand : AbstractUndoableCommand

    {
        public string Text;

        public SetTextCommand(string text, History history, VideoEditor videoEditor) : base(history, videoEditor)
        {
            Text = text;
        }

        public override void DoExecute()
        {
            VideoEditor.SetText(Text);
        }

        public override void UnExecute()
        {
            VideoEditor.RemoveText();
        }
    }
}