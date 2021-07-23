using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class TransitMode : TravelMode
    {
        public override object GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }

        public override object GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }
    }
}