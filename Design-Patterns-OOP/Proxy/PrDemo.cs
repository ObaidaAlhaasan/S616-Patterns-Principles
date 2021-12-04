using Design_Patterns_OOP.Proxy.EX;

namespace Design_Patterns_OOP.Proxy
{
    public class PrDemo
    {
        public static void Show()
        {
            var lib = new Library();
            foreach (var name in new string[] {"a", "b", "c", "d"})
                lib.Add(new LoggingEbookProxy(name));

            lib.OpenEbook("a");
            lib.OpenEbook("b");
        }

        public static void ExShow()
        {
            var dbContext = new DbContext();

            // We read an object (eg a product) from a database.
            var product = dbContext.getProduct(1);

            // We modify the properties of the object in memory.
            product.setName("Updated Name");

            // DbContext should keep track of changed objects in memory.
            // When we call saveChanges(), it'll automatically generate
            // the right SQL statements to update our database.
            dbContext.saveChanges();

            // After saving the changes to the database, we can
            // change our in-memory object again and save the changes.
            product.setName("Another name");
            dbContext.saveChanges();
        }
    }
}