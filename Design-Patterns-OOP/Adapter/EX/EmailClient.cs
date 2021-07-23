using System.Collections.Generic;

namespace Design_Patterns_OOP.Adapter.EX
{
    public class EmailClient
    {
        private ArrayList<IEmailProvider> _providers = new();

        public void AddProvider(IEmailProvider provider)
        {
            _providers.add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in _providers)
                provider.DownloadEmails();
        }
    }
}