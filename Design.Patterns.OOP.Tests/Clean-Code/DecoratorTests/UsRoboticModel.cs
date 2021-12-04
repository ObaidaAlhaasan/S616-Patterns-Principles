namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class UsRoboticModel : IModem
    {
        public void Dial(PhoneNumber number)
        {
        }

        public void HangUp()
        {
        }

        public void Send(char c)
        {
        }

        public char Recv()
        {
            return ' ';
        }

        public void SetSpeakerVolume(int vol)
        {
        }
    }
}