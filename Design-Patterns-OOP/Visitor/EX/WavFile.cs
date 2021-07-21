using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Visitor.EX
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

        public void ApplyFilter(IFilter filter)
        {
            foreach (var segment in _segments)
            {
                segment.ApplyFilter(filter);
            }
        }
    }
}