namespace Design.Patterns.OOP.Tests.ClockTests;

public class ClockDriver : ClockObserver
{
    private readonly TimeSink sink;

    public ClockDriver(TimeSubject subject, TimeSink sink)
    {
        subject.RegisterObserver(this);
        this.sink = sink;
    }

    public void Update(int hours, int minutes, int seconds)
    {
        sink.SetTime(hours, minutes, seconds);
    }
}