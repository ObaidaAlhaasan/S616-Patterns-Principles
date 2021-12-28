namespace Design.Patterns.OOP.Tests.ClockTests;

public class MockTimeSubject : TimeSubject
{
    public void SetTime(int hours, int minutes, int seconds)
    {
        Notify(hours, minutes, seconds);
    }
}