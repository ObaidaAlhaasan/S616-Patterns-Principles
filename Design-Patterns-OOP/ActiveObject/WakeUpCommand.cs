namespace Design_Patterns_OOP.ActiveObject;

public class WakeUpCommand : ICommand
{
    public bool executed = false;

    public void Execute()
    {
        executed = true;
    }
}