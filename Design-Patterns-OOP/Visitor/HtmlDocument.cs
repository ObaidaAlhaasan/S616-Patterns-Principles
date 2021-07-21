using System.Collections.Generic;

namespace Design_Patterns_OOP.Visitor
{
    public class HtmlDocument
    {
        public List<HtmlNode> HtmlNodes { get; set; } = new();
        public void Add(HtmlNode node) => HtmlNodes.Add(node);

        public void Execute(IOperation operation)
        {
            foreach (var node in HtmlNodes)
                node.Execute(operation);
        }
    }
}