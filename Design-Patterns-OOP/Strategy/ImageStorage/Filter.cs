using System;

namespace Design_Patterns_OOP.Strategy.ImageStorage
{
    public abstract class Filter
    {
        public abstract void Apply(string fileName);
    }

    public class BlackAndWhiteFilter : Filter
    {
        public override void Apply(string fileName)
        {
            Console.WriteLine("Filtering black and white");
        }
    }


    public class HighContrastFilter : Filter
    {
        public override void Apply(string fileName)
        {
            Console.WriteLine("Filtering high-contrast");
        }
    }
}