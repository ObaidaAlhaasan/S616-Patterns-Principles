using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Composite
{
    public class Group : IComponent
    {
        private readonly IList<IComponent> _components = new List<IComponent>();

        public void Add(IComponent component) => _components.Add(component);

        public void Render()
        {
            foreach (var component in _components)
                component.Render();
        }

        public void Resize()
        {
            foreach (var component in _components)
                component.Resize();
        }

        public void Move(int x, int y)
        {
            foreach (var component in _components)
                component.Move(x, y);
        }
    }
}