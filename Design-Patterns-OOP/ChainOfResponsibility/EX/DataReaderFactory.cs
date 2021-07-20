namespace Design_Patterns_OOP.ChainOfResponsibility.EX
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var excelReader = new ExcelReader();
            var numbersReader = new NumberReader();
            var quickBooksReader = new QuickBookReader();

            quickBooksReader.SetNext(numbersReader);
            numbersReader.SetNext(excelReader);

            return quickBooksReader;
        }
    }
}