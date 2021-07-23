using System;
using System.Reflection.Metadata;
using Design_Patterns_OOP.Adapter;
using Design_Patterns_OOP.Bridge;
using Design_Patterns_OOP.ChainOfResponsibility;
using Design_Patterns_OOP.ChainOfResponsibility.EX;
using Design_Patterns_OOP.Command;
using Design_Patterns_OOP.Command.Editor;
using Design_Patterns_OOP.Composite;
using Design_Patterns_OOP.Composite.EX;
using Design_Patterns_OOP.Decorator;
using Design_Patterns_OOP.Exercises.ChainOfResponsibility;
using Design_Patterns_OOP.Exercises.Command;
using Design_Patterns_OOP.Exercises.Iterator;
using Design_Patterns_OOP.Exercises.Mediator;
using Design_Patterns_OOP.Exercises.Memento;
using Design_Patterns_OOP.Exercises.Observer;
using Design_Patterns_OOP.Exercises.State;
using Design_Patterns_OOP.Exercises.Strategy;
using Design_Patterns_OOP.Exercises.TemplateMethod;
using Design_Patterns_OOP.Exercises.Visitor;
using Design_Patterns_OOP.Facade;
using Design_Patterns_OOP.FlyWeight;
using Design_Patterns_OOP.Iterator;
using Design_Patterns_OOP.Mediator;
using Design_Patterns_OOP.Mediator.EX;
using Design_Patterns_OOP.Memento.Editor;
using Design_Patterns_OOP.Memento.Document;
using Design_Patterns_OOP.Observer;
using Design_Patterns_OOP.Observer.Stock;
using Design_Patterns_OOP.State;
using Design_Patterns_OOP.Strategy.ChatClient;
using Design_Patterns_OOP.Strategy.ImageStorage;
using Design_Patterns_OOP.TemplateMethodPattern;
using Design_Patterns_OOP.TemplateMethodPattern.Window;
using Design_Patterns_OOP.Visitor;
using Design_Patterns_OOP.Visitor.EX;
using BicyclingMode = Design_Patterns_OOP.State.DirectionService.BicyclingMode;
using ChatClient = Design_Patterns_OOP.Strategy.ChatClient.ChatClient;
using ChatWindow = Design_Patterns_OOP.TemplateMethodPattern.Window.ChatWindow;
using Compressor = Design_Patterns_OOP.ChainOfResponsibility.Compressor;
using DirectionService = Design_Patterns_OOP.State.DirectionService.DirectionService;
using Document = Design_Patterns_OOP.Memento.Document.Document;
using EditorHistory = Design_Patterns_OOP.Memento.EditorHistory;
using HtmlDocument = Design_Patterns_OOP.Command.Editor.HtmlDocument;
using NormalizeFilter = Design_Patterns_OOP.Visitor.EX.NormalizeFilter;
using Product = Design_Patterns_OOP.Iterator.Product;
using ProductCollection = Design_Patterns_OOP.Iterator.ProductCollection;
using ReverbFilter = Design_Patterns_OOP.Visitor.EX.ReverbFilter;
using SetContrastCommand = Design_Patterns_OOP.Command.VideoEditor.SetContrastCommand;
using SetTextCommand = Design_Patterns_OOP.Command.VideoEditor.SetTextCommand;
using StatusBar = Design_Patterns_OOP.Observer.Stock.StatusBar;
using Stock = Design_Patterns_OOP.Observer.Stock.Stock;
using StockListView = Design_Patterns_OOP.Observer.Stock.StockListView;
using UndoCommand = Design_Patterns_OOP.Command.Editor.UndoCommand;
using VideoEditor = Design_Patterns_OOP.Command.VideoEditor.VideoEditor;
using WalkingMode = Design_Patterns_OOP.State.DirectionService.WalkingMode;
using WavFile = Design_Patterns_OOP.Visitor.EX.WavFile;

namespace Design_Patterns_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Behavioural Patterns

            // MementoCalls();
            // StateCalls();
            // IteratorCalls();
            // StrategyCalls();
            // TemplateMethodCalls();
            // CommandCalls();
            // ObserverCalls();
            // MediatorCalls();
            // ChainOfResponsibilityCalls();
            // VisitorCalls();

            // Behavioural Patterns Exercises
            // MDemo.Show();
            // SDemo.Show();
            // ItDemo.Show();
            // StDemo.Show();
            // TDemo.Show();
            // CDemo.Show();
            // ODemo.Show();
            // MedDemo.Show();
            // ChDemo.Show();
            // VDemo.Show();

            #endregion


            #region Structural Patterns

            // CompositeCalls();
            // AdapterCalls();
            // DecoratorCalls();
            // FacadeCalls();
            // FlyWeightCalls();

            BridgeCalls();

            #endregion
        }

        private static void BridgeCalls()
        {
            BDemo.Show();
        }

        private static void FlyWeightCalls()
        {
            FlDemo.Show();
            FlDemo.ExShow();
        }

        private static void FacadeCalls()
        {
            FaDemo.Show();
            FaDemo.ExShow();
        }

        private static void DecoratorCalls()
        {
            DecDemo.Show();
            DecDemo.EXShow();
        }

        private static void AdapterCalls()
        {
            // AdDemo.Show();
            // AdDemo.EXDemo();
        }

        private static void CompositeCalls()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // square
            group1.Add(new Shape()); // square

            var group2 = new Group();
            group2.Add(new Shape()); // circle
            group2.Add(new Shape()); // circle

            group1.Render();
            group1.Resize();
            group2.Render();
            group1.Move(10, 20);

            Console.WriteLine();
            CompositeDemo.Show();
        }

        private static void VisitorCalls()
        {
            var htmlDoc = new Visitor.HtmlDocument();
            htmlDoc.Add(new HeadingNode());
            htmlDoc.Add(new AnchorNode());

            htmlDoc.Execute(new HighlightOperation());
            htmlDoc.Execute(new PlainTextOperation());


            var wavFile = WavFile.Read("myfile.wav");
            wavFile.ApplyFilter(new NoiseReducerFilter());
            wavFile.ApplyFilter(new ReverbFilter());
            wavFile.ApplyFilter(new NormalizeFilter());
        }

        private static void ChainOfResponsibilityCalls()
        {
            var wServer = new WebServer(new Authenticator(new Logger(new Compressor(new Encryptor(null)))));
            wServer.Handle(new HttpRequest("admin", "a"));
            wServer.Handle(new HttpRequest("admin", "admin"));

            var reader = DataReaderFactory.GetDataReaderChain();
            reader.Read("data.xls");
            reader.Read("data.numbers");
            reader.Read("data.qbw");
            reader.Read("data.jpg");
        }

        private static void MediatorCalls()
        {
            var dialog = new ArticleDialogBox();
            dialog.SimulateUserInteraction();
            var signUpDialog = new SignUpDialogBox();
            signUpDialog.SimulateUserInteraction();
        }

        private static void ObserverCalls()
        {
            var dataSource = new DataSource();
            dataSource.AddObserver(new ChartClass(dataSource));
            dataSource.AddObserver(new ChartClass(dataSource));
            dataSource.AddObserver(new SpreadSheet(dataSource));
            dataSource.SetValue(1000);

            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("1", 10);
            var stock2 = new Stock("2", 20);
            var stock3 = new Stock("3", 30);

            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);


            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);

            stock2.SetPrice(21);


            stock3.SetPrice(9);
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
            chatClient.Send("Hello world", new Aes());
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

            dirService.GetEta();
            dirService.GetDirection();

            dirService.SetTravelMode(new BicyclingMode());
            dirService.GetEta();
            dirService.GetDirection();
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