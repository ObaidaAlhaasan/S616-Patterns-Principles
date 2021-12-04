using System;

namespace Design_Patterns_OOP.Creational.Builder.EX.Html
{
    public class HtmlParagraph : HtmlElement
    {
        private String text;

        public HtmlParagraph(String text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return String.Format("<p>%s</p>", text);
        }
    }
}