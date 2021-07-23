using Design_Patterns_OOP.Command.Editor;

namespace Design_Patterns_OOP.Command.VideoEditor
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private float _prevContrast;
        private float _contrast;

        public SetContrastCommand(float contrast, VideoEditor videoEditor, History history) : base(history, videoEditor)
        {
            _prevContrast = videoEditor.Contrast;
            this._contrast = contrast;
        }

        public override void DoExecute()
        {
            VideoEditor.SetContrast(_contrast);
        }

        public override void UnExecute()
        {
            VideoEditor.SetContrast(_prevContrast);
        }
    }
}