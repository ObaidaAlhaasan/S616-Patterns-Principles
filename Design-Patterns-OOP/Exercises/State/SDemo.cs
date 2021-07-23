namespace Design_Patterns_OOP.Exercises.State
{
    public class SDemo
    {
        public static void Show()
        {
            var service = new DirectionService(new WalkingMode());
            service.GetEta();
            service.GetDirection();
        }
    }
}