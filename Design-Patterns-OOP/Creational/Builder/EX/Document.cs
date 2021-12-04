using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Design_Patterns_OOP.Creational.Builder.EX.Html;

namespace Design_Patterns_OOP.Creational.Builder.EX
{
    public class Document
    {
        private List<IElement> elements = new ArrayList<IElement>();

        public void add(IElement element)
        {
            elements.Add(element);
        }

        public void export(IDocumentBuilder builder, String fileName)
        {
            // PROBLEM to solve
            // var content = "";
            //
            //
            //
            // if (format == ExportFormat.HTML)
            // {
            //     var document = new HtmlDocument();
            //
            //     foreach (IElement element in elements)
            //     {
            //         if (element is Text text1)
            //         {
            //             var text = text1.getContent();
            //             document.add(new HtmlParagraph(text));
            //         }
            //         else if (element is Image image)
            //         {
            //             var source = image.getSource();
            //             document.add(new HtmlImage(source));
            //         }
            //     }
            //
            //     content = document.ToString();
            // }
            // else if (format == ExportFormat.TEXT)
            // {
            //     var builder = new StringBuilder();
            //
            //     foreach (var element in elements)
            //     {
            //         if (element is Text text1)
            //         {
            //             var text = text1.getContent();
            //             builder.Append(text);
            //         }
            //     }
            //
            //     content = builder.ToString();
            // }
            //
            // var writer = new FileWriter(fileName);
            // writer.write(content);
            // writer.close();


            //  solution
            // Note that we've separated the construction of the target
            // document from its representation. The same construction
            // algorithm is used to generate different types of documents
            // such as HTML, text, etc.
            //
            // For text files, even though we don't have images, we still
            // use the same algorithm. Look at the implementation of
            // addImage() method in TextDocumentBuilder. It's empty. So it
            // simply ignores adding images.

            foreach (var element in elements)
            {
                if (element is Text text)
                    builder.addText(text);
                else if (element is Image image)
                    builder.addImage(image);
            }

            var writer = new FileWriter(fileName);
            writer.write(builder.getResult());
            writer.close();
        }
    }
}