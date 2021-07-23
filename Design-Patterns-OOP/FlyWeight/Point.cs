using System.IO;

namespace Design_Patterns_OOP.FlyWeight
{
    public class Point
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        private PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            System.Out.println($"{icon.Type} at ({x.ToString()}, {y.ToString()})");
        }
    }
}