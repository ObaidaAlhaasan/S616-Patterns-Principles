using System;

namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticate");
            return !(request.UserName == "admin" && request.Password == "admin");
        }
    }
}