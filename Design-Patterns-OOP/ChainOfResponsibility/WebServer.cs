using System;
using Design_Patterns_OOP.ChainOfResponsibility;

namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public class WebServer
    {
        public readonly Handler Handler;

        public WebServer(Handler handler)
        {
            Handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        public void Handle(HttpRequest request) => Handler.Handle(request);
    }
}