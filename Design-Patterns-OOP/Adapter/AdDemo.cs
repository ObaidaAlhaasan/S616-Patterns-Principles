using System;
using System.IO;
using Design_Patterns_OOP.Adapter.AvaFilter;
using Design_Patterns_OOP.Adapter.EX;

namespace Design_Patterns_OOP.Adapter
{
    public class AdDemo
    {
        public static void Show()
        {
            var image = new Image();
            var view = new ImageView(image);
            view.Apply(new CaramelFilter(new Caramel()));
            view.Apply(new VividFilter());
            view.Apply(new RoseFilter());
        }

        public static void EXDemo()
        {
            var client = new EmailClient();
            client.AddProvider(new GmailClientAdapter(new GmailClient()));
            
            client.DownloadEmails();
        }
    }

    public class GmailClientAdapter : IEmailProvider
    {
        private readonly GmailClient _client;

        public GmailClientAdapter(GmailClient client)
        {
            _client = client;
        }

        public void DownloadEmails()
        {
            _client.connect();
            _client.getEmails();
            _client.disconnect();
        }
    }
}