using System;
using System.Reflection.Metadata;
using Design_Patterns_OOP.Command;
using Design_Patterns_OOP.Command.Editor;
using Design_Patterns_OOP.Command.VideoEditor;
using Design_Patterns_OOP.Iterator;
using Design_Patterns_OOP.Memento;
using Design_Patterns_OOP.Memento.Editor;
using Design_Patterns_OOP.Memento.Document;
using Design_Patterns_OOP.State;
using Design_Patterns_OOP.State.DirectionService;
using Design_Patterns_OOP.Strategy.ChatClient;
using Design_Patterns_OOP.Strategy.ImageStorage;
using Design_Patterns_OOP.TemplateMethodPattern;
using Design_Patterns_OOP.TemplateMethodPattern.Window;
using Document = Design_Patterns_OOP.Memento.Document.Document;

namespace Design_Patterns_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // MementoCalls();
            // StateCalls();
            // IteratorCalls();
            // StrategyCalls();
            // TemplateMethodCalls();
            // CommandCalls();
        }

        private static void CommandCalls()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            command.Execute();

            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();


            var history = new History();
            var doc = new HtmlDocument();
            doc.SetContent("Hello world!");

            var cmd = new BoldCommand(doc, history);
            cmd.Execute();
            Console.WriteLine(doc.Content);

            var undCmd = new UndoCommand(history);
            undCmd.Execute();
            Console.WriteLine(doc.Content);

            // Ex

            var videoEditor = new VideoEditor();
            var videoHistory = new History();

            var setTextCommand = new SetTextCommand("Video Title", history, videoEditor);
            setTextCommand.Execute();
            Console.WriteLine("TEXT: " + videoEditor);

            var setContrast = new SetContrastCommand(1, videoEditor, history);
            setContrast.Execute();
            Console.WriteLine("TEXT: " + videoEditor);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);

            undoCommand.Execute();
            Console.WriteLine("UNDO: " + videoEditor);
        }

        private static void TemplateMethodCalls()
        {
            TaskBase task = new GenerateReportTask(new AuditTrail());
            task.Execute();

            WindowBase window = new ChatWindow();
            window.Close();
        }

        private static void StrategyCalls()
        {
            var imgStorage = new ImageStorage();
            imgStorage.Store("img.png", new PngCompressor(), new BlackAndWhiteFilter());

            var chatClient = new ChatClient();
            chatClient.Send("Hello world", new AES());
        }

        private static void IteratorCalls()
        {
            var browser = new BrowseHistory();

            browser.Push("A");
            browser.Push("B");
            browser.Push("C");

            var iterator = browser.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }


            var product = new ProductCollection();
            product.Add(new Product(1, "X"));
            product.Add(new Product(2, "Y"));
            product.Add(new Product(3, "Z"));

            var productIterator = product.CreateIterator();

            while (productIterator.HasNext())
            {
                Console.WriteLine(productIterator.Current());
                productIterator.Next();
            }
        }

        private static void StateCalls()
        {
            var canv = new Canvas();

            canv.SetCurrentTool(new SelectionTool());
            canv.MouseDown();
            canv.MouseUp();

            canv.SetCurrentTool(new EraserTool());
            canv.MouseDown();
            canv.MouseUp();


            var dirService = new DirectionService(new WalkingMode());

            dirService.getEta();
            dirService.getDirection();

            dirService.SetTravelMode(new BicyclingMode());
            dirService.getEta();
            dirService.getDirection();
        }

        private static void MementoCalls()
        {
            var ed = new Editor();
            var history = new EditorHistory();
            ed.SetContent("<h1>");
            ed.SetContent("hello");
            history.Push(ed.CreateState());
            ed.SetContent(" ");
            ed.SetContent("world!");
            ed.SetContent("</h1>");
            history.Push(ed.CreateState());
            ed.SetContent("</h1>");
            ed.SetContent("</h1>");

            ed.Restore(history.Pop());
            Console.WriteLine(ed.Content);


            var doc = new Document();
            var docHistory = new DocumentHistory();
            doc.SetFontName("Arial");
            doc.SetContent("Hello world");
            doc.SetFontSize(16);
            docHistory.Push(doc.CreateMemento());

            doc.SetFontName("Console");
            doc.SetContent("Welcome");
            doc.SetFontSize(18);
            docHistory.Push(doc.CreateMemento());

            doc.SetFontName("monospace");
            doc.SetContent("Hello");
            doc.SetFontSize(20);

            doc.Restore(docHistory.Pop());
            Console.WriteLine(doc);
        }
    }
}