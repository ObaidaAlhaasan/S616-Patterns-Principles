using System;

namespace Design_Patterns_OOP.Visitor
{
    public class AnchorNode : HtmlNode
    {
        public override void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}