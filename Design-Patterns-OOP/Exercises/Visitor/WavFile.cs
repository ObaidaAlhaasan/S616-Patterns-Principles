using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Exercises.Visitor
{
    public class WavFile
    {
        private List<Segment> _segments = new();

        public static WavFile Read(string fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile._segments.Add(new FormatSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());

            return wavFile;
        }

        public void ApplyFilter(Filter filter)
        {
            foreach (var segment in _segments)
            {
                segment.Apply(filter);
            }
        }

    
    }

    public abstract class Filter
    {
        public abstract void Apply(FormatSegment formatSegment);

        public abstract void Apply(FactSegment seg);
    }

    public class NoiseFilter : Filter
    {
        public override void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Noise reduction on format segment");
        }

        public override void Apply(FactSegment seg)
        {
            Console.WriteLine("Noise reduction on fact segment");
        }
    }

    public class ReverbFilter : Filter
    {
        public override void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb filter on format segment");
        }

        public override void Apply(FactSegment seg)
        {
            Console.WriteLine("Reverb filter on fact segment");
        }
    }

    public class NormalizeFilter : Filter
    {
        public override void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalize on format segment");
        }

        public override void Apply(FactSegment seg)
        {
            Console.WriteLine("Normalize on fact segment");
        }
    }
}