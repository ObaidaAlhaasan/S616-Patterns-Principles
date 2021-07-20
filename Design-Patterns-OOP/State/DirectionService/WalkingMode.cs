using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class WalkingMode : TravelMode
    {
        public override object GetETA()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }

        public override object GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }
    }
}