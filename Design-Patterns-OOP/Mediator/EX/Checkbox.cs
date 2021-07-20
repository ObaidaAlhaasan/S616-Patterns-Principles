namespace Design_Patterns_OOP.Mediator.EX
{
    public class Checkbox : UIControl
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