namespace Design_Patterns_OOP.Mediator.EX
{
    public class Button:UIControl
    {
        public bool IsEnabled { get; private set; }

        public void SetIsEnabled(bool enb)
        {
            IsEnabled = enb;
            NotifyEventHandlers();
        }
    }
}