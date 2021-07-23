namespace Design_Patterns_OOP.Mediator.EX
{
    public class Checkbox : UiControl
    {
        public bool IsChecked { get; private set; }

        public void SetIsChecked(bool isChecked)
        {
            IsChecked = isChecked;
            NotifyEventHandlers();
        }

        public void SetChecked(bool b)
        {
            IsChecked = b;
        }
    }
}