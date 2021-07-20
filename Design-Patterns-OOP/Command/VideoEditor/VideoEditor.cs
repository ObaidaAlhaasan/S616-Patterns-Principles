namespace Design_Patterns_OOP.Command.VideoEditor
{
    public class VideoEditor
    {
        public float Contrast { get; private set; } = 0.5f;
        public string Text { get; private set; }

        public void SetText(string text) => Text = text;

        public void RemoveText() => Text = "";

        public void SetContrast(float contrast) => Contrast = contrast;

        public override string ToString()
        {
            return "VideoEditor{" +
                   "contrast=" + Contrast +
                   ", text='" + Text + '\'' +
                   '}';
        }
    }
}