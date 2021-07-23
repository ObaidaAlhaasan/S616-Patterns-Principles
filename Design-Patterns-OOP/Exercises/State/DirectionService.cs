using System;
using Design_Patterns_OOP.Command.VideoEditor;
using Design_Patterns_OOP.Exercises.State;

namespace Design_Patterns_OOP.Exercises.State
{
    public class DirectionService
    {
        private TravelMode _travelMode;

        public DirectionService(TravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public object GetEta() => _travelMode.GetEta();
        public object GetDirection() => _travelMode.GetDirection();

        public TravelMode GetTravelMode() => _travelMode;

        public void SetTravelMode(TravelMode travelMode) => this._travelMode = travelMode;
    }

    public abstract class TravelMode
    {
        public abstract object GetEta();
        public abstract object GetDirection();
    }

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

    public class WalkingMode : TravelMode
    {
        public override object GetEta()
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