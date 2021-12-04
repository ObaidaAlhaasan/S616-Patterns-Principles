namespace Design_Patterns_OOP.Creational.Builder
{
    public interface IPresentationDocument
    {
        public virtual void AddPage(string text)
        {
        }

        public virtual void AddFrame(string text, int duration)
        {
        }
    }
}