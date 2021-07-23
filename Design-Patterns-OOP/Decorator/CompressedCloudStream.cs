using System;

namespace Design_Patterns_OOP.Decorator
{
    public class CompressedCloudStream : IStream
    {
        public IStream Stream { get; }

        public CompressedCloudStream()
        {
        }

        public CompressedCloudStream(IStream stream)
        {
            Stream = stream;
        }

        public void write(string data)
        {
            var compressed = compress(data);
            Out.println($"Compressing {compressed}");
            Stream?.write(compressed);
        }

        private string compress(string data)
        {
            return data[..5];
        }
    }
}