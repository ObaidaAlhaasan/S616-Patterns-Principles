using System;
using Design_Patterns_OOP.ActiveObject;
using Xunit;

namespace Design.Patterns.OOP.Tests.ActiveObjectTests;

public class ActiveObjectTests
{
    public class TestSleepCommand
    {
        [Fact]
        public void TestSleep()
        {
            WakeUpCommand wakeup = new WakeUpCommand();
            ActiveObjectEngine e = new ActiveObjectEngine();
            SleepCommand c = new SleepCommand(1000, e, wakeup);
            e.AddCommand(c);
            DateTime start = DateTime.Now;
            e.Run();
            DateTime stop = DateTime.Now;
            double sleepTime = (stop - start).TotalMilliseconds;
            Assert.True(sleepTime >= 1000,
                "SleepTime " + sleepTime + " expected > 1000");
            Assert.True(sleepTime <= 1100,
                "SleepTime " + sleepTime + " expected < 1100");
            Assert.True(wakeup.executed, "Command Executed");
        }
    }
}