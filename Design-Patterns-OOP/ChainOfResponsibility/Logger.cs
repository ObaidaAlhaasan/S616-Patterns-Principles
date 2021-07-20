using System;

namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging...." + request.UserName);
            return false;
        }
    }
}