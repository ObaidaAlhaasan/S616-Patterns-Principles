using System;

namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Encrypting " + request.UserName);
            return false;
        }
    }
}