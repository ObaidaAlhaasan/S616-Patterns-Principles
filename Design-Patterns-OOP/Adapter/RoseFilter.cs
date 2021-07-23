using Design_Patterns_OOP.Adapter.AvaFilter;

namespace Design_Patterns_OOP.Adapter
{
    public class RoseFilter : Rose, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}