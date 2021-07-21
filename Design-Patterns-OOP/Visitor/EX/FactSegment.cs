namespace Design_Patterns_OOP.Visitor.EX
{
    public class FactSegment : Segment
    {
        public override void ApplyFilter(IFilter filter)
        {
            filter.Apply(this);
        }
    }
}