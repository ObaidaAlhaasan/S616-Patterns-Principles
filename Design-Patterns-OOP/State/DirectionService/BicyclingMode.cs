using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class BicyclingMode : TravelMode
    {
        public override object GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }

        public override object GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }
    }
}