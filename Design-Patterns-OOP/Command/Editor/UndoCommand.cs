using System.IO;

namespace Design_Patterns_OOP.Command.Editor
{
    public class UndoCommand : ICommand
    {
        private History History;

        public UndoCommand(History history)
        {
            History = history;
        }

        public void Execute()
        {
            if (History.Size > 0) History.Pop().UnExecute();
        }
    }
}