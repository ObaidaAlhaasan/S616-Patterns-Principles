namespace Design_Patterns_OOP.FlyWeight
{
    public class PointIcon
    {
        public PointIconType Type { get; }
        private byte[] icon; // 20 KB -> 20 MB

        public PointIcon(PointIconType type, byte[] icon)
        {
            this.icon = icon;
            Type = type;
        }
    }
}