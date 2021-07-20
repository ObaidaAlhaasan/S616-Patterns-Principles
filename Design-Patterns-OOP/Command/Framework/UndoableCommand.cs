namespace Design_Patterns_OOP.Command.Framework
{
    public interface IUndoableCommand : ICommand
    {
        public void UnExecute();
    }
}