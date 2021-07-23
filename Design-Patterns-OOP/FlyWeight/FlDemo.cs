using System;
using Design_Patterns_OOP.FlyWeight.EX;

namespace Design_Patterns_OOP.FlyWeight
{
    public class FlDemo
    {
        public static void Show()
        {
            var s = new PointsService();
            s.GetPoints();
        }

        public static void ExShow()
        {
            var contextFactory = new CellContextFactory();
            var sheet = new SpreadSheet(contextFactory);
            sheet.setContent(0, 0, "Hello");
            sheet.setContent(1, 0, "World");
            sheet.setFontFamily(0, 0, "Arial");
            sheet.render();
        }
    }
}