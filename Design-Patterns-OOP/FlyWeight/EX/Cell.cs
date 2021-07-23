using System;

namespace Design_Patterns_OOP.FlyWeight.EX
{
    public class Cell
    {
        private int row;
        private int column;
        private string content;
        public CellContext Context { get; private set; }

        public Cell(int row, int column, CellContext context)
        {
            this.row = row;
            this.column = column;
            Context = context;
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getFontFamily()
        {
            return Context.fontFamily;
        }

        public int getFontSize()
        {
            return Context.fontSize;
        }

        public void SetContext(CellContext ctx)
        {
            Context = ctx;
        }

        public void render()
        {
            System.Out.println($"({{row}}, {column}): {content} [{Context.fontFamily}]\n");
        }
    }
}