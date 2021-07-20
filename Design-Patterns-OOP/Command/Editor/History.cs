using System.Collections.Generic;
using System.Linq;
using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command.Editor
{
    public class History
    {
        private List<IUndoableCommand> Commands { get; set; } = new();
        public void Push(IUndoableCommand command) => Commands.Add(command);
        public int Size => Commands.Count;

        public IUndoableCommand Pop()
        {
            var l = Commands.ElementAt(Commands.Count - 1);
            Commands.Remove(l);
            return l;
        }
    }
}