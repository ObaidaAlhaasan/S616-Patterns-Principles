using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class DrivingMode : TravelMode
    {
        public override object GetEta()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }

        public override object GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }
    }
}