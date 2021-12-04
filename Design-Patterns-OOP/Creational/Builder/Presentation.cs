using System;
using System.Collections;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Creational.Builder
{
    public class Presentation
    {
        private IList<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide) => slides.Add(slide);

        public void Export(IPresentationBuilder presentationBuilder)
        {
            presentationBuilder.AddSlide(new Slide("Copy Right"));
            foreach (var slide in slides)
            {
                presentationBuilder.AddSlide(slide);
            }
        }
    }

    public interface IPresentationBuilder
    {
        void AddSlide(Slide slide);
    }

    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private readonly PdfDocument _document = new();

        public void AddSlide(Slide slide)
        {
            _document.AddPage(slide.Text);
        }

        public PdfDocument GetPdfDocs()
        {
            return _document;
        }
    }

    public class MovieBuilder : IPresentationBuilder
    {
        private readonly MovieDocument _document = new();

        public void AddSlide(Slide slide)
        {
            _document.AddFrame(slide.Text, 30);
        }

        public MovieDocument GetMovieDocument()
        {
            return _document;
        }
    }
}