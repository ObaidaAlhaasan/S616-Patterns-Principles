using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Design.Patterns.OOP.Tests.Clean_Code.MonoStateTests
{
    public class MonoStateTests
    {
        [Fact]
        public async Task AddedStateServiceRegistryTest()
        {
            var s = new Service();
            var r1 = new MonoStateServiceRegistry();
            var r2 = new MonoStateServiceRegistry();

            r1.Register("ServiceName", s);
            Assert.Equal(s, r2.GetService("ServiceName"));
        }
    }

    public class Service
    {
    }

    public class MonoStateServiceRegistry
    {
        private static Dictionary<string, Service> _services = new Dictionary<string, Service>();
        private static bool Initilized = false;

        public MonoStateServiceRegistry()
        {
            if (Initilized is false)
            {
                _services = new Dictionary<string, Service>();
                Initilized = true;
            }
        }

        public void Register(string serviceName, Service service)
        {
            _services.Add(serviceName, service);
        }

        public Service GetService(string serviceName) => _services.GetValueOrDefault(serviceName);
    }
}