using System;
using Design_Patterns_OOP.Command.VideoEditor;

namespace Design_Patterns_OOP.Exercises.Visitor
{
    public abstract class Segment
    {
        public abstract void Apply(Filter filter);
    }
}