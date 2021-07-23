namespace Design_Patterns_OOP.Exercises.Visitor
{
    public class FactSegment : Segment
    {
        public override void Apply(Filter filter)
        {
            filter.Apply(this);
        }
    }
}