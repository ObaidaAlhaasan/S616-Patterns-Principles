using System;

namespace Design_Patterns_OOP.Exercises.Command
{
    public class CDemo
    {
        public static void Show()
        {
            var videoEditor = new VideoEditor();
            var history = new EditorHistory();

            var setTextCommand = new SetTextCommand("Video Title", videoEditor, history);
            setTextCommand.Execute();
            Console.WriteLine("TEXT: " + videoEditor);

            var setContrast = new SetContrastCommand(videoEditor, history, 1);
            setContrast.Execute();
            Console.WriteLine("CONTRAST: " + videoEditor);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);
        }
    }
}