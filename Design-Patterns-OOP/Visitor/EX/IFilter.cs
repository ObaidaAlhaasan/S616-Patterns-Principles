namespace Design_Patterns_OOP.Visitor.EX
{
    public interface IFilter
    {
        public void Apply(FormatSegment segment);
        public void Apply(FactSegment segment);
    }
}