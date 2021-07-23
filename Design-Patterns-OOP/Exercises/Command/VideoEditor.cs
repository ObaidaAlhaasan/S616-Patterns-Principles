namespace Design_Patterns_OOP.Exercises.Command
{
    public class VideoEditor
    {
        private float _contrast = 0.5f;
        private string _text;

        public void SetText(string text)
        {
            this._text = text;
        }

        public void RemoveText()
        {
            this._text = "";
        }

        public float GetContrast()
        {
            return _contrast;
        }

        public void SetContrast(float contrast)
        {
            this._contrast = contrast;
        }

        public override string ToString()
        {
            return "VideoEditor{" +
                   "contrast=" + _contrast +
                   ", text='" + _text + '\'' +
                   '}';
        }
    }
}