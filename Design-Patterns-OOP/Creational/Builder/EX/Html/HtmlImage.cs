namespace Design_Patterns_OOP.Creational.Builder.EX.Html
{
    public class HtmlImage : HtmlElement
    {
        private string source;

        public HtmlImage(string source)
        {
            this.source = source;
        }

        public override string ToString()

        {
            return string.Format("<img src=\"%s\" />", source);
        }
    }
}