namespace Design_Patterns_OOP.Command.Editor
{
    public class HtmlDocument
    {
        public string Content { private set; get; }


        public void SetContent(string content)
        {
            Content = content;
        }

        public void MakeBold() => Content = $"<b> {Content} </b>";
    }
}