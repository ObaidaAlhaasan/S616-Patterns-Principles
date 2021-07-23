namespace Design_Patterns_OOP.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        public IStream Stream { get; }

        public EncryptedCloudStream()
        {
        }

        public EncryptedCloudStream(IStream stream)
        {
            Stream = stream;
        }

        public void write(string data)
        {
            var encrypted = encrypt(data);
            Stream?.write(encrypted);
        }

        private string encrypt(string data)
        {
            return "!@#$(!@#*()*)(*!@#";
        }
    }
}