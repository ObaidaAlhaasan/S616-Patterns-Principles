using System.Collections.Generic;

namespace Design_Patterns_OOP.Memento.Document
{
    public class DocumentHistory
    {
        public Stack<DocumentMemento> DocumentStates { get; private set; }

        public DocumentHistory() => DocumentStates = new Stack<DocumentMemento>();

        public void Push(DocumentMemento memento) => DocumentStates.Push(memento);

        public DocumentMemento Pop() => DocumentStates.Pop();
    }
}