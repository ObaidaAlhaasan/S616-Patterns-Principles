using System.Collections.Generic;

namespace Design.Patterns.OOP.Tests.ClockTests;

public abstract class TimeSubject
{
    private List<ClockObserver> itsObservers = new();

    protected void Notify(int hours, int mins, int secs)
    {
        foreach (ClockObserver observer in itsObservers)
            observer.Update(hours, mins, secs);
    }

    public void RegisterObserver(ClockObserver observer)
    {
        itsObservers.Add(observer);
    }
}