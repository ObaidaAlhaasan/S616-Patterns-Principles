using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_OOP.Exercises.Command
{
    public class EditorHistory
    {
        private IList<IUndoableCommand> UndoableCommands { get; } = new List<IUndoableCommand>();
        public int Size => UndoableCommands.Count;

        public void Push(AbstractUndoableCommand cmd) => UndoableCommands.Add(cmd);

        public IUndoableCommand? Pop()
        {
            var l = UndoableCommands.ElementAtOrDefault(UndoableCommands.Count - 1);
            UndoableCommands.Remove(l);
            return l;
        }
    }
}