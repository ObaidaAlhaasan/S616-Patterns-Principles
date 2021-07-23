namespace Design_Patterns_OOP.FlyWeight.EX
{
    public class CellContext
    {
        public string fontFamily { get; }
        public int fontSize { get; }
        public bool IsBold { get; }

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            IsBold = isBold;
        }
    }
}