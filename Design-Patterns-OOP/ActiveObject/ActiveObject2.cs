using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Design_Patterns_OOP.ActiveObject;

public class ActiveObject2
{
    private readonly ConcurrentQueue<MyTask> dispatchQueue = new();

    public void Do(string name, int priority)
    {
        dispatchQueue.Enqueue(new MyTask(name, priority));

        new Thread(() =>
        {
            dispatchQueue.TryDequeue(out var task);
            Console.WriteLine(task?.Name);
        }).Start();
    }

    class MyTask
    {
        public int Priority { get; set; }
        public string Name { get; set; }

        public MyTask(string name, int priority)
        {
            Priority = priority;
            Name = name;
        }
    }
}