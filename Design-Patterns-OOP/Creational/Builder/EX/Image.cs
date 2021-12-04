using System;

namespace Design_Patterns_OOP.Creational.Builder.EX
{
    public class Image : IElement
    {
        private String source;

        public Image(String source)
        {
            this.source = source;
        }

        public String getSource()
        {
            return source;
        }
    }
}