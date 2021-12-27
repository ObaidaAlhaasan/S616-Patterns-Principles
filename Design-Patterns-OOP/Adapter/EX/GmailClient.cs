namespace Design_Patterns_OOP.Adapter.EX
{
    public class GmailClient
    {
        public void connect()
        {
            Out.println("Connecting to Gmail");
        }

        public void getEmails()
        {
            Out.println("Downloading emails from Gmail");
        }

        public void disconnect()
        {
            Out.println("Disconnecting from Gmail");
        }
    }
}