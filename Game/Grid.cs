using System.Collections;

namespace VoltorbSolver.Game
{
    internal sealed class Grid
    {
        #region Properties
        /// <summary>
        /// [x][y]
        /// x : 0 → 4
        /// y : 0 ↑ 4
        /// </summary>
        private Cell[,] Cells { get; } = new Cell[5,5];
        public Cell this[int x, int y]
        {
            get => Cells[x, y];
        }
        public Cell this[Point p]
        {
            get => Cells[p.X, p.Y];
        }

        public Line[] Columns { get; } = new Line[5];
        public Line[] Rows { get; } = new Line[5];
        private List<Line> Lines { get; } = new();
        #endregion

        #region Constructors
        public Grid() 
        { 
            for(int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Cell c = new();
                    Cells[x, y] = c;
                }
            }

            for(int i = 0; i < 5; i++)
            {
                Line column = new(new Cell[] { Cells[i, 0], Cells[i, 1], Cells[i, 2], Cells[i, 3], Cells[i, 4] });
                Columns[i] = column;
                Lines.Add(column);

                Line row = new(new Cell[] { Cells[0, i], Cells[1, i], Cells[2, i], Cells[3, i], Cells[4, i] });
                Rows[i] = row;
                Lines.Add(row);
            }
        }
        #endregion

        #region IEnumerable
        public IEnumerator GetEnumerator()
        {
            return Cells.GetEnumerator();
        }
        #endregion

        #region Misc Methods
        public void Reset()
        {
            ResetCases();
            ResetLineInfos();
        }
        private void ResetCases()
        {
            foreach(Cell c in Cells)
                c.Reset();
        }
        private void ResetLineInfos()
        {
            foreach (Line l in Columns)
                l.ResetInfos();

            foreach (Line l in Rows)
                l.ResetInfos();
        }
        #endregion
    }
}
