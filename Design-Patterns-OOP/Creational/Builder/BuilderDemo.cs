using System;
using System.Text;
using Design_Patterns_OOP.Creational.Builder.EX;
using Design_Patterns_OOP.Creational.Builder.EX.Html;

namespace Design_Patterns_OOP.Creational.Builder
{
    public class BuilderDemo
    {
        public static void Show()
        {
            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide1"));
            presentation.AddSlide(new Slide("Slide2"));
            presentation.AddSlide(new Slide("Slide3"));

            var builder = new PdfDocumentBuilder();
            presentation.Export(builder);

            var pdf = builder.GetPdfDocs();


            var builder2 = new MovieBuilder();

            presentation.Export(builder2);
            var movie = builder2.GetMovieDocument();
        }

        public static void ExShow()
        {
            var document = new Document();
            document.add(new Text("Hello World"));
            document.add(new Image("pic1.jpg"));

            document.export(new HtmlDocumentBuilder(), "export.html");

            // Only writes the text elements to the file
            document.export(new TextDocumentBuilder(), "export.txt");
        }
    }

    public interface IDocumentBuilder
    {
        void addText(Text text);
        void addImage(Image image);
        string getResult();
    }

    public class HtmlDocumentBuilder : IDocumentBuilder
    {
        private HtmlDocument document = new HtmlDocument();

        public void addText(Text text)
        {
            document.add(new HtmlParagraph(text.getContent()));
        }

        public void addImage(Image image)
        {
            document.add(new HtmlImage(image.getSource()));
        }

        public String getResult()
        {
            return document.ToString();
        }
    }

    public class TextDocumentBuilder : IDocumentBuilder
    {
        private StringBuilder builder = new();

        public void addText(Text text)
        {
            builder.Append(text.getContent());
        }

        public void addImage(Image image)
        {
            // Note that this method has no implementation because
            // images cannot be added to a plain text file.
        }

        public String getResult()
        {
            return builder.ToString();
        }
    }
}