using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.FlyWeight.EX
{
    public class CellContextFactory
    {
        public Dictionary<int, CellContext> Fonts = new();

        public CellContext GetContext(string fontFamily, int fontSize, bool isBold)
        {
            var hash = fontFamily.GetHashCode() + fontSize.GetHashCode() + isBold.GetHashCode();

            Console.WriteLine("Hash" + hash);

            if (Fonts.TryGetValue(hash, out var c))
                return c;

            var ctx = new CellContext(fontFamily, fontSize, isBold);
            Fonts.TryAdd(hash, ctx);
            return ctx;
        }

      
    }
}