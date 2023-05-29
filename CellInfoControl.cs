using VoltorbSolver.Game;

namespace VoltorbSolver
{
    public partial class CellInfoControl : UserControl
    {
        private Cell CurrentCell { get; set; }

        public CellInfoControl()
        {
            InitializeComponent();
            UpdateVisuals();
        }

        internal void SetCell(Cell cell)
        {
            CurrentCell = cell;
            UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            if(CurrentCell?.Analysis is null)
            {
                BombLabel.Text = "";
                ScoreOneLabel.Text = "";
                ScoreTwoLabel.Text = "";
                ScoreThreeLabel.Text = "";

                SafetyLabel.Text = "";
            }
            else
            {
                double total = CurrentCell.Analysis.Sum();

                BombLabel.Text = $"Bomb chance : {Math.Round(CurrentCell.Analysis[0] / total * 100)}%";
                ScoreOneLabel.Text = $"1 chance : {Math.Round(CurrentCell.Analysis[1] / total * 100)}%";
                ScoreTwoLabel.Text = $"2 chance : {Math.Round(CurrentCell.Analysis[2] / total * 100)}%";
                ScoreThreeLabel.Text = $"3 chance : {Math.Round(CurrentCell.Analysis[3] / total * 100)}%";

                SafetyLabel.Text = $"Safety : {Math.Round(CurrentCell.Safety * 100)}%";
            }
        }
    }
}
