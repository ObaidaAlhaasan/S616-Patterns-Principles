using System;

namespace Design_Patterns_OOP.Visitor.EX
{
    public class ReverbFilter : IFilter
    {
        public void Apply(FormatSegment segment)
        {
            Console.WriteLine("Reverb filter on format segment");
        }

        public void Apply(FactSegment segment)
        {
            Console.WriteLine("Reverb filter on fact segment");
        }
    }
}