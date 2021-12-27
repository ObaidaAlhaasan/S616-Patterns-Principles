using System.Collections.Generic;

namespace Design_Patterns_OOP.ActiveObject;

public class ActiveObjectEngine
{
    List<ICommand> itsCommands = new();

    public void AddCommand(ICommand c)
    {
        itsCommands.Add(c);
    }

    public void Run()
    {
        while (itsCommands.Count > 0)
        {
            var c = itsCommands[0];
            itsCommands.RemoveAt(0);
            c.Execute();
        }
    }
}