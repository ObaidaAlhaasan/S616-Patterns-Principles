namespace Design.Patterns.OOP.Tests.ClockTests;

public interface ClockObserver
{
    void Update(int hours, int minutes, int secs);
}