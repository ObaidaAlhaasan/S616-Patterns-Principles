namespace Design_Patterns_OOP.Exercises.Observer
{
    public class ODemo
    {
        public static void Show()
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("stock1", 10);
            var stock2 = new Stock("stock2", 20);
            var stock3 = new Stock("stock3", 30);

            // The status bar shows the popular stocks
            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);

            // The stock view list shows all stocks
            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);

            // Causes both statusBar and stockListView to get refreshed
            stock2.SetPrice(21);

            // Causes only the stockListView to get refreshed. (statusBar
            // is not watching this stock.)
            stock3.SetPrice(9);
        }
    }
}