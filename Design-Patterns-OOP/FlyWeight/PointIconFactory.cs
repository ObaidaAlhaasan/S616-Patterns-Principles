using System.Collections.Generic;

namespace Design_Patterns_OOP.FlyWeight
{
    public static class PointIconFactory
    {
        public static Dictionary<PointIconType, PointIcon> icons = new();

        public static PointIcon Get(PointIconType type)
        {
            if (icons.TryGetValue(type, out var val))
                return val;

            var icon = new PointIcon(type, new byte[100]);
            icons.TryAdd(type, icon);
            return icon;
        }
    }
}