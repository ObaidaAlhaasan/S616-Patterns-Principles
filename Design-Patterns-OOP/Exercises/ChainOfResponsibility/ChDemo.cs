namespace Design_Patterns_OOP.Exercises.ChainOfResponsibility
{
    public class ChDemo
    {
        public static void Show()
        {
            var da =  ReaderFactory.GetReaderChain();
            da.Read("number.xls");
            da.Read("number.numbers");
            da.Read("number.qbw");
            da.Read("number.jpg");
        }
    }
}