using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class DirectionService
    {
        public TravelMode Mode { get; private set; }

        public DirectionService(TravelMode mode) => Mode = mode;

        public object GetEta() => Mode.GetEta();

        public object GetDirection() => Mode.GetDirection();

        public void SetTravelMode(TravelMode travelMode) => Mode = travelMode;
    }
}