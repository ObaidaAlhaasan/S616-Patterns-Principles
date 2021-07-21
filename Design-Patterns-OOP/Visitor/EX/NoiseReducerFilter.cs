using System;

namespace Design_Patterns_OOP.Visitor.EX
{
    public class NoiseReducerFilter : IFilter
    {
        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Noise reducer FormatSegment");
        }

        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Noise reducer FactSegment");
        }
    }
}