namespace Design_Patterns_OOP.Strategy.ImageStorage
{
    public class ImageStorage
    {
        public void Store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}