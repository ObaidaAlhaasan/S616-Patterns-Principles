using System;

namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress....");
            return false;
        }
    }
}