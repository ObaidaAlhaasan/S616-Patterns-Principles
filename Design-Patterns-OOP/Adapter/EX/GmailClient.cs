namespace Design_Patterns_OOP.Adapter.EX
{
    public class GmailClient
    {
        public void connect()
        {
            System.Out.println("Connecting to Gmail");
        }

        public void getEmails()
        {
            System.Out.println("Downloading emails from Gmail");
        }

        public void disconnect()
        {
            System.Out.println("Disconnecting from Gmail");
        }
    }
}