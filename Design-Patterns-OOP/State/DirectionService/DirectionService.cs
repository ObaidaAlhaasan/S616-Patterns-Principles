using System;

namespace Design_Patterns_OOP.State.DirectionService
{
    public class DirectionService
    {
        public TravelMode Mode { get; private set; }

        public DirectionService(TravelMode mode) => Mode = mode;

        public object getEta() => Mode.GetETA();

        public object getDirection() => Mode.GetDirection();

        public void SetTravelMode(TravelMode travelMode) => Mode = travelMode;
    }
}