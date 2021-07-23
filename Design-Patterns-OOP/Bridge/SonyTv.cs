using System;

namespace Design_Patterns_OOP.Bridge
{
    public class SonyTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony Turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony Turn off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Sony SetChanel {number}");
        }
    }
}