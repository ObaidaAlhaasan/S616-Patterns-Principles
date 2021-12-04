using System.Threading.Tasks;
using Xunit;

namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class DecoratorTests
    {
        [Fact]
        public async Task Nothing()
        {
            var user = new User(new HayesModem(), new UserPreferences(true));
            user.procoureModem();

            Assert.True(user.Modem is LoudDialModem);
        }
    }

    public class User
    {
        public IModem Modem { get; private set; }
        private UserPreferences _myPreferences;

        public User(IModem modem, UserPreferences preferences)
        {
            Modem = modem;
            _myPreferences = preferences;
        }

        public void procoureModem()
        {
            if (_myPreferences.LoudModem)
                // decorate modem from factory with user preference
                Modem = new LoudDialModem(Modem);
            else
                // decorate modem from factory with user preference
                Modem = new QuiteDialModem(Modem);
        }
    }

    public class ModemFactory
    {
        public static ModemFactory Instance = new();

        public IModem MakeModem()
        {
            return new Modem();
        }
    }
}