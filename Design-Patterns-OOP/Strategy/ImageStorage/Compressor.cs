using System;

namespace Design_Patterns_OOP.Strategy.ImageStorage
{
    public abstract class Compressor
    {
        public abstract void Compress(string fileName);
    }
    
    public class JpgCompressor : Compressor
    {
        public override void Compress(string fileName)
        {
            Console.WriteLine("Compressing Jpg");
        }
    }

    public class PngCompressor : Compressor
    {
        public override void Compress(string fileName)
        {
            Console.WriteLine("Compressing Png");
        }
    }
}