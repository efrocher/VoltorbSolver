using System.Diagnostics;
using VoltorbSolver.Analysis;
using VoltorbSolver.Game;

namespace VoltorbSolver
{
    public partial class SolverForm : Form
    {
        #region Properties
        private Grid GameGrid { get; init; } = new();

        private List<CellControl> CellControlList { get; } = new();
        private List<LineInfoControl> LineInfoControlList { get; } = new();
        #endregion

        #region Constructor
        public SolverForm()
        {
            InitializeComponent();

            ResetAnalysisTimeLabel();

            for (int x = 0; x < 5; x++)
            for(int y = 0; y < 5; y++)
            {
                CellControl c = new(GameGrid[x, y], CellInfos);
                CellControlList.Add(c);
                GameGridLayout.Controls.Add(c, x, y);
            }

            for (int i = 0; i < 5; i++)
            {
                LineInfoControl column = new(i, GameGrid.Columns[i]);
                LineInfoControlList.Add(column);
                ColumnInfosLayout.Controls.Add(column, i, 0);

                LineInfoControl row = new(i, GameGrid.Rows[i]);
                LineInfoControlList.Add(row);
                RowInfosLayout.Controls.Add(row, 0, i);
            }
        }
        #endregion

        #region Methods
        public void RefreshVisuals()
        {
            double maxScore = -1;
            foreach (Cell c in GameGrid)
            {
                if (!c.Discovered && c.Status == CellStatus.Default)
                    maxScore = Math.Max(maxScore, c.Score);
            }

            foreach (CellControl c in CellControlList)
                c.RefreshVisuals(maxScore);

            foreach (LineInfoControl c in LineInfoControlList)
                c.RefreshVisuals();
        }

        public void ResetAnalysisTimeLabel()
        {
            AnalysisTimeLabel.Text = "";
        }
        public void UpdateAnalysisTimeLabel(int solutionsCount, long ellapsedMs)
        {
            AnalysisTimeLabel.Text = $"Analysis: {(solutionsCount > 0 ? "SAT" : "UNSAT")} [{solutionsCount} - {ellapsedMs}ms]";

            AnalysisTimeLabel.BackColor = solutionsCount > 0 ? Color.LightGreen : Color.LightCoral;
        }
        #endregion

        #region Events
        private void ResetButton_Click(object sender, EventArgs e)
        {
            GameGrid.Reset();
            RefreshVisuals();
            ResetAnalysisTimeLabel();
        }

        private void AnalyseButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Stopwatch sw = new();

            sw.Start();
            int solutionsCount = Z3Analyser.Analyse(GameGrid);
            sw.Stop();

            UpdateAnalysisTimeLabel(solutionsCount, sw.ElapsedMilliseconds);

            if(solutionsCount > 0)
                RefreshVisuals();
            else
            {
                // TODO
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}