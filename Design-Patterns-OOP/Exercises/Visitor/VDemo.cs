namespace Design_Patterns_OOP.Exercises.Visitor
{
    public class VDemo
    {
        public static void Show()
        {
            var wvFile = WavFile.Read("file.wav");
            wvFile.ApplyFilter(new NoiseFilter());
            wvFile.ApplyFilter(new ReverbFilter());
            wvFile.ApplyFilter(new NormalizeFilter());
        }
    }
}