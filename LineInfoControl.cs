namespace VoltorbSolver
{
    internal partial class LineInfoControl : UserControl
    {
        private Game.Line Line { get; init; }

        public LineInfoControl(int index, Game.Line line)
        {
            Line = line;

            InitializeComponent();

            BackColor = index switch
            {
                0 => Color.Coral,
                1 => Color.MediumSeaGreen,
                2 => Color.Gold,
                3 => Color.LightBlue,
                4 or _ => Color.Orchid,
            };

            RefreshVisuals();
        }

        public void RefreshVisuals()
        {
            PointToalLabel.Text = Line.TotalPoints.ToString();
            BombTotalLabel.Text = Line.TotalBombs.ToString();
        }

        private void PointToalLabel_MouseUp(object sender, MouseEventArgs e)
        {
            Line.TotalPoints = Helper.ModifyValueAccordingToClickEvent(Line.TotalPoints, e);

            RefreshVisuals();
        }

        private void BombTotalLabel_MouseUp(object sender, MouseEventArgs e)
        {
            Line.TotalBombs = Helper.ModifyValueAccordingToClickEvent(Line.TotalBombs, e);

            RefreshVisuals();
        }
    }
}
