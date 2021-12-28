namespace Design.Patterns.OOP.Tests.ClockTests;

public class MockTimeSink : ClockObserver
{
    private int itsHours;
    private int itsMinutes;
    private int itsSeconds;

    public int GetHours()
    {
        return itsHours;
    }

    public int GetMinutes()
    {
        return itsMinutes;
    }

    public int GetSeconds()
    {
        return itsSeconds;
    }

    public void Update(int hours, int minutes, int secs)
    {
        itsHours = hours;
        itsMinutes = minutes;
        itsSeconds = secs;
    }
}