namespace Design_Patterns_OOP.Proxy
{
    public class EbookProxy : EBook
    {
        private RealEbook _realEbook;

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }

        private void Load()
        {
            if (_realEbook == null)
                _realEbook = new RealEbook(FileName);
        }

        public override void Show()
        {
            Load();
            _realEbook?.Show();
        }
    }
}