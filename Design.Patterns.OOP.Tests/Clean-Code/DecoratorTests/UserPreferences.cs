namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class UserPreferences
    {
        public bool LoudModem { get; private set; }

        public UserPreferences(bool loudModem)
        {
            LoudModem = loudModem;
        }
    }
}