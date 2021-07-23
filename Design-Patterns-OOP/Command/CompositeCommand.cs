using System.Collections.Generic;

namespace Design_Patterns_OOP.Command
{
    public class CompositeCommand : ICommand
    {
        private IList<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command) => _commands.Add(command);


        public void Execute()
        {
            foreach (var command in _commands) command.Execute();
        }
    }
}