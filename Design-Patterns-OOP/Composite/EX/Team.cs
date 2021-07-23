using System.Collections.Generic;

namespace Design_Patterns_OOP.Composite.EX
{
    public class Team : Resource
    {
        private List<Resource> _resources = new();

        public void Add(Resource resource)
        {
            _resources.Add(resource);
        }

        public override void Deploy()
        {
            foreach (var resource in _resources)
                resource.Deploy();
        }
    }

    public abstract class Resource
    {
        public abstract void Deploy();
    }
}