using System;
using Design_Patterns_OOP.Command.VideoEditor;

namespace Design_Patterns_OOP.Visitor.EX
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IFilter filter);
    }
}