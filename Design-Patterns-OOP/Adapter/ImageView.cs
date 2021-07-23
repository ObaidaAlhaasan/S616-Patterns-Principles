namespace Design_Patterns_OOP.Adapter
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            this._image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}