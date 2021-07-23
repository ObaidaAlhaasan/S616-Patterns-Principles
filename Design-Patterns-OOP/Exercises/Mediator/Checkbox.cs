namespace Design_Patterns_OOP.Exercises.Mediator
{
    public class Checkbox
    {
        public bool IsChecked { get; private set; }

        public void SetIsChecked(bool c)
        {
            IsChecked = c;
        }
    }
}