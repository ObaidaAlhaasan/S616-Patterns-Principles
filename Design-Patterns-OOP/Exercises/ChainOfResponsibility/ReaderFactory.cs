namespace Design_Patterns_OOP.Exercises.ChainOfResponsibility
{
    public static class ReaderFactory
    {
        public static Reader GetReaderChain()
        {
            var ex = new ExcelReader();
            var num = new NumberReader();
            var qa = new QuickBookReader();

            qa.SetNext(num);
            num.SetNext(ex);
            return qa;
        }
    }
}