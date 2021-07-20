using System.Collections.Generic;

namespace Design_Patterns_OOP.Command
{
    public class CompositeCommand : ICommand
    {
        private IList<ICommand> Commands = new List<ICommand>();

        public void Add(ICommand command) => Commands.Add(command);


        public void Execute()
        {
            foreach (var command in Commands) command.Execute();
        }
    }
}