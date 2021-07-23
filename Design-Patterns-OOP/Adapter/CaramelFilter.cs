using System.IO;
using Design_Patterns_OOP.Adapter.AvaFilter;

namespace Design_Patterns_OOP.Adapter
{
    public class CaramelFilter : IFilter
    {
        private readonly Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}