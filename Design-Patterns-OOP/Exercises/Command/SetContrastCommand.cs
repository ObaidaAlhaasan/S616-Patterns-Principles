namespace Design_Patterns_OOP.Exercises.Command
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        public float PrevContrast { get; set; }
        public float Contrast { get; set; }

        public SetContrastCommand(VideoEditor videoEditor, EditorHistory editorHistory, float contrast) : base(videoEditor, editorHistory)
        {
            PrevContrast = videoEditor.GetContrast();
            this.Contrast = contrast;
        }

        public override void UnExecute()
        {
            VideoEditor.SetContrast(PrevContrast);
        }

        protected override void DoExecute()
        {
            VideoEditor.SetContrast(Contrast);
        }
    }
}