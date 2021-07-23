using System;

namespace Design_Patterns_OOP.Bridge
{
    public class SamsungTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung Turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung Turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Samsung Set Channel {number}");
        }
    }
}