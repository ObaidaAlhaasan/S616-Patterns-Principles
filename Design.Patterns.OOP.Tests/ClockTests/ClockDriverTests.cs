using Xunit;

namespace Design.Patterns.OOP.Tests.ClockTests;

public class ClockDriverTest
{
    private MockTimeSubject _subject;
    private MockTimeSink sink;

    public ClockDriverTest()
    {
        _subject = new MockTimeSubject();
        sink = new MockTimeSink();
        _subject.RegisterObserver(sink);
    }

    private void AssertSinkEquals(
        MockTimeSink sink, int hours, int mins, int secs)
    {
        Assert.Equal(hours, sink.GetHours());
        Assert.Equal(mins, sink.GetMinutes());
        Assert.Equal(secs, sink.GetSeconds());
    }

    [Fact]
    public void TestTimeChange()
    {
        _subject.SetTime(3, 4, 5);
        AssertSinkEquals(sink, 3, 4, 5);

        _subject.SetTime(7, 8, 9);
        AssertSinkEquals(sink, 7, 8, 9);
    }

    [Fact]
    public void TestMultipleSinks()
    {
        MockTimeSink sink2 = new MockTimeSink();
        _subject.RegisterObserver(sink2);

        _subject.SetTime(12, 13, 14);
        AssertSinkEquals(sink, 12, 13, 14);
        AssertSinkEquals(sink2, 12, 13, 14);
    }
}