namespace Design_Patterns_OOP.Decorator
{
    public class CloudStream : IStream
    {
        public CloudStream()
        {
        }


        public void write(string data)
        {
            Out.println("Storing " + data);
        }
    }
}