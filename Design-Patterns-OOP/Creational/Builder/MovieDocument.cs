using System;

namespace Design_Patterns_OOP.Creational.Builder
{
    public class MovieDocument : IPresentationDocument
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine("Adding Frames to MovieDocument");
        }
    }
}