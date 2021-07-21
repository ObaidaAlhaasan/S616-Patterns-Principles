using System;

namespace Design_Patterns_OOP.Visitor
{
    public interface IOperation // Visitor
    {
        void Apply(HeadingNode node);
        void Apply(AnchorNode node);
    }


    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlight HeadingNode");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlight AnchorNode");
        }
    }

    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Plain Text HeadingNode");
        }

        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Plain Text AnchorNode");
        }
    }
}