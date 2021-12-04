using System;

namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public interface IModem
    {
        void Dial(PhoneNumber number);
        void HangUp();
        void Send(char c);
        char Recv();
        void SetSpeakerVolume(int vol);
    }

    public class Modem : IModem
    {
        public void Dial(PhoneNumber number)
        {
            Console.WriteLine("Dial number");
        }

        public void HangUp()
        {
            Console.WriteLine("HangUp");
        }

        public void Send(char c)
        {
            Console.WriteLine("Send");
        }

        public char Recv()
        {
            Console.WriteLine("Recv");
            return ' ';
        }

        public void SetSpeakerVolume(int vol)
        {
            Console.WriteLine("SetSpeakerVolume " + vol);
        }
    }
}