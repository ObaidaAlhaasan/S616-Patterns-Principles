using Design_Patterns_OOP.Command.Editor;
using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command.VideoEditor
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        public VideoEditor VideoEditor;
        public History History;

        public AbstractUndoableCommand(History history, VideoEditor videoEditor)
        {
            History = history;
            VideoEditor = videoEditor;
        }

        public void Execute()
        {
            DoExecute();
            History.Push(this);
        }

        public virtual void UnExecute()
        {
        }

        public abstract void DoExecute();
    }
}