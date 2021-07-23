using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_OOP.Exercises.Memento
{
    public class DocumentsHistory
    {
        public IList<DocumentMemento> DocumentStates { get; set; } = new List<DocumentMemento>();

        public void Push(DocumentMemento memento) => DocumentStates.Add(memento);

        public DocumentMemento Pop()
        {
            var l = DocumentStates.ElementAtOrDefault(DocumentStates.Count - 1);
            DocumentStates.Remove(l);
            return l;
        }
    }
}