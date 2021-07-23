namespace Design_Patterns_OOP.Decorator.EX
{
    public class MainDecorator : IArtifact
    {
        private IArtifact _artifact;

        public MainDecorator(IArtifact artifact)
        {
            _artifact = artifact;
        }

        public static string Icon => "[Main]";

        public string Render()
        {
            return _artifact?.Render() + Icon;
        }
    }
}