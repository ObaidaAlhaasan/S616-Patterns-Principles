using System;

namespace Design_Patterns_OOP.Visitor.EX
{
    public class NormalizeFilter : IFilter
    {
        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Normalize on format segment");
        }

        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Normalize on Fact segment");
        }
    }
}