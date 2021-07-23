using System;

namespace Design_Patterns_OOP.Exercises.Memento
{
    public static class MDemo
    {
        public static void Show()
        {
            var doc = new Document();
            var history = new DocumentsHistory();

            doc.SetContent("<h1>");
            doc.SetFontName("Arial");
            doc.SetFontSize(22);
            history.Push(doc.CreateMemento());
            doc.SetContent("Hello");
            doc.SetFontName("Console");
            doc.SetFontSize(25);
            history.Push(doc.CreateMemento());

            doc.SetContent("Mono");
            doc.SetFontName("Mono");
            doc.SetFontSize(35);

            doc.Restore(history.Pop());
            Console.WriteLine(doc.GetContent());
            Console.WriteLine(doc.GetFontName());
            Console.WriteLine(doc.GetFontSize());
        }
    }
}