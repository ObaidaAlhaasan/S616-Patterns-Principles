using System;

namespace Design_Patterns_OOP.Creational.Prototype
{
    public class PrototypeDemo
    {
        public static void Show()
        {
            var component = new Circle(2);

            var contextM = new ContextMenu();
            contextM.Duplicate(component);
        }
    }

    class TimeLine
    {
        public void Add(Component component)
        {
            Console.WriteLine("Adding new component");
        }
    }

    public class Text : Component
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

        protected override void Render()
        {
            Console.WriteLine("render text");
        }

        public override Component Clone()
        {
            return new Text(content);
        }
    }

    public abstract class Component
    {
        protected abstract void Render();

        public abstract Component Clone();
    }

    class Circle : Component
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        protected override void Render()
        {
            Console.WriteLine("Render a circle");
        }

        public override Circle Clone()
        {
            return new Circle(Radius);
        }
    }


    class ContextMenu
    {
        private TimeLine _timeLine = new TimeLine();

        public void Duplicate(Component component)
        {
            var dup = component.Clone();
            // logic to add our target to document viewer
            _timeLine.Add(dup);
        }
    }
}