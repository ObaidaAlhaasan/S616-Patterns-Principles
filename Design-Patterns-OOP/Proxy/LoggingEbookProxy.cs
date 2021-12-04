using System;

namespace Design_Patterns_OOP.Proxy
{
    public class LoggingEbookProxy : EBook
    {
        private RealEbook _ebook;

        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public override void Show()
        {
            Load();
            Console.WriteLine($"Logging {FileName}");
            _ebook?.Show();
        }

        private void Load()
        {
            if (_ebook == null)
                _ebook = new RealEbook(FileName);
        }
    }
}