using System;

namespace Design_Patterns_OOP.Creational.Builder.EX
{
    public class Text : IElement
    {
        private String content;

        public Text(String content)
        {
            this.content = content;
        }

        public String getContent()
        {
            return content;
        }
    }
}