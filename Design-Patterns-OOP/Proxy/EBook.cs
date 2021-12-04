using System;

namespace Design_Patterns_OOP.Proxy
{
    public abstract class EBook
    {
        public string FileName { get; protected init; }

        public abstract void Show();
    }
}