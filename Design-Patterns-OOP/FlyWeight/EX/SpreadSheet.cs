using System;

namespace Design_Patterns_OOP.FlyWeight.EX
{
    public class SpreadSheet
    {
        private const int MAX_ROWS = 3;
        private const int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private string fontFamily = "Times New Roman";
        private int fontSize = 12;
        private bool isBold = false;

        private Cell[,] cells = new Cell[MAX_ROWS, MAX_COLS];
        private readonly CellContextFactory factory;


        public SpreadSheet(CellContextFactory factory)
        {
            this.factory = factory;
            generateCells();
        }

        public void setContent(int row, int col, string content)
        {
            ensureCellExists(row, col);

            cells[row, col].setContent(content);
        }

        public void setFontFamily(int row, int col, string fontFamily)
        {
            ensureCellExists(row, col);

            var cell = cells[row, col];
            var currentContext = cell.Context;
            var context = factory.GetContext(fontFamily, currentContext.fontSize, currentContext.IsBold);

            cells[row, col].SetContext(context);
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new IllegalArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new IllegalArgumentException();
        }

        private void generateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
            for (var col = 0; col < MAX_COLS; col++)
            {
                cells[row, col] = new Cell(row, col, GetDefaultContext());
            }
        }

        private CellContext GetDefaultContext()
        {
            // In a real app, these values should not be hardcoded here.
            // They should be read from a configuration file.
            return new CellContext("Times New Roman", 12, false);
        }

        public void render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
            for (var col = 0; col < MAX_COLS; col++)
                cells[row, col].render();
        }
    }

    internal class IllegalArgumentException : Exception
    {
    }
}