using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_OOP.Creational.Builder.EX.Html
{
    public class HtmlDocument
    {
        private List<HtmlElement> elements = new ArrayList<HtmlElement>();

        public void add(HtmlElement element)
        {
            elements.Add(element);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("<html>");
            foreach (var element in elements)
                builder.Append(element);
            builder.Append("</html>");
            return builder.ToString();
        }
    }
}