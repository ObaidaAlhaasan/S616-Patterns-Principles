using System.Threading;

namespace Design_Patterns_OOP.ActiveObject;

public class ActiveObjectDemo
{
    public static void Show()
    {
        DelayedTyper.Show();
    }

    public static void Show2()
    {
        var ac = new ActiveObject2();
        var t1 = new Thread(() => { ac.Do("Task1", 1); });
        var t2 = new Thread(() => { ac.Do("Task2", 2); });
        var t3 = new Thread(() => { ac.Do("Task3", 3); });
        var t5 = new Thread(() => { ac.Do("Task5", 5); });
        var t4 = new Thread(() => { ac.Do("Task4", 4); });

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();
    }
}