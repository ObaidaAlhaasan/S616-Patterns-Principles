namespace Design_Patterns_OOP.Exercises.Command
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        public VideoEditor VideoEditor { get; set; }
        public EditorHistory EditorHistory { get; set; }

        protected AbstractUndoableCommand(VideoEditor videoEditor, EditorHistory editorHistory)
        {
            VideoEditor = videoEditor;
            EditorHistory = editorHistory;
        }


        public void Execute()
        {
            DoExecute();

            EditorHistory.Push(this);
        }

        public abstract void UnExecute();

        protected abstract void DoExecute();
    }
}