namespace Design_Patterns_OOP.Decorator.EX
{
    public class ErrorDecorator : IArtifact
    {
        private IArtifact _artifact;

        public ErrorDecorator(IArtifact artifact)
        {
            _artifact = artifact;
        }

        public string Icon => "[Error]";

        public string Render()
        {
            var mainIcon = _artifact?.Render();
            return mainIcon + Icon;
        }
    }
}