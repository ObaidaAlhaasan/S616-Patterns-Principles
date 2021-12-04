using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Creational.Factory
{
    public interface IViewEngine
    {
        object Render(string viewName, Dictionary<string, object> context);
    }

    public class MatchaViewEngine : IViewEngine
    {
        public object Render(string viewName, Dictionary<string, object> context)
        {
            return $"Rendering {viewName} In Matcha View Engine";
        }
    }

    public class SharpViewEngine : IViewEngine
    {
        public object Render(string viewName, Dictionary<string, object> context)
        {
            return $"Render view Sharp engine {viewName}";
        }
    }
}