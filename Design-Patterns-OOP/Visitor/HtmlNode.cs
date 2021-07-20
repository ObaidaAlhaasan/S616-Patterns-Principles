using System.Collections.Generic;

namespace Design_Patterns_OOP.Visitor
{
    public abstract class HtmlNode
    {
    }

    public class HtmlDocument
    {
        public List<HtmlNode> HtmlNodes { get; set; } = new();
        public void Add(HtmlNode node) => HtmlNodes.Add(node);
    }

    public class HeadingNode : HtmlNode
    {
    }

    public class AnchorNode : HtmlNode
    {
    }
}