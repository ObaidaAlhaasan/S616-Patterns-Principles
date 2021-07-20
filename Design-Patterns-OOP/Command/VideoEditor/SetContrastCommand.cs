using Design_Patterns_OOP.Command.Editor;

namespace Design_Patterns_OOP.Command.VideoEditor
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private float prevContrast;
        private float contrast;

        public SetContrastCommand(float contrast, VideoEditor videoEditor, History history) : base(history, videoEditor)
        {
            prevContrast = videoEditor.Contrast;
            this.contrast = contrast;
        }

        public override void DoExecute()
        {
            VideoEditor.SetContrast(contrast);
        }

        public override void UnExecute()
        {
            VideoEditor.SetContrast(prevContrast);
        }
    }
}