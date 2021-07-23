namespace Design_Patterns_OOP.Exercises.Mediator
{
    public class Button
    {
        public bool IsEnabled { get; private set; }

        public void SetIsEnabled(bool enb)
        {
            IsEnabled = enb;
        }
    }
}