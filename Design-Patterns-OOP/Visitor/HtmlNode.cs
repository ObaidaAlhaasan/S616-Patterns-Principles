namespace Design_Patterns_OOP.Visitor
{
    public abstract class HtmlNode
    {
        public abstract void Execute(IOperation operation);
    }
}