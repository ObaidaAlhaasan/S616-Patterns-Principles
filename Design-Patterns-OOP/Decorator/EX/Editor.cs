using System;

namespace Design_Patterns_OOP.Decorator.EX
{
    public class Editor
    {
        public void openProject(string path)
        {
            IArtifact[] artefacts =
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            artefacts[0] = new ErrorDecorator(new MainDecorator(artefacts[0]));
            artefacts[2] = new ErrorDecorator(artefacts[2]);

            foreach (var artefact in artefacts)
                Out.println(artefact.Render());
        }
    }
}