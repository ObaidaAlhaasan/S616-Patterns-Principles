namespace Design_Patterns_OOP.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Next;

        public Handler(Handler next)
        {
            Next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            Next?.Handle(request);
        }

        protected abstract bool DoHandle(HttpRequest request);
    }
}