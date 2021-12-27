using System.Collections.Generic;

namespace Design_Patterns_OOP.Memento.Editor
{
    public class EditorHistory
    {
        public Stack<EditorState> States { get; private set; } = new Stack<EditorState>();

        public void Push(EditorState editorState) => States.Push(editorState);

        public EditorState Pop() => States.Pop();
    }
}