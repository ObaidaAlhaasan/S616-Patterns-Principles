using System.IO;

namespace Design_Patterns_OOP.Exercises.Command
{
    public class UndoCommand : ICommand
    {
        public EditorHistory EditorHistory { get; set; }

        public UndoCommand(EditorHistory editorHistory)
        {
            EditorHistory = editorHistory;
        }


        public void Execute()
        {
            if (EditorHistory.Size > 0)
            {
                EditorHistory.Pop()?.UnExecute();
            }
        }
    }
}