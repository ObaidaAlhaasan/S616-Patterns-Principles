namespace Design_Patterns_OOP.Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            System.Out.Println("Applying Vivid Filter");
        }
    }
}