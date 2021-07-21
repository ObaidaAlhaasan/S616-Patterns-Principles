using System;

namespace Design_Patterns_OOP.Visitor
{
    public class HeadingNode : HtmlNode
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}