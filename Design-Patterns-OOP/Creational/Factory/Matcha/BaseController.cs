using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Creational.Factory.Matcha
{
    public class BaseController
    {
        protected virtual void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}