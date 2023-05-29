namespace VoltorbSolver
{
    internal partial class CellControl : UserControl
    {
        private readonly Color RedColor = Color.FromArgb(239, 21, 50);
        private readonly Color GreenColor = Color.FromArgb(22, 225, 36);

        private Game.Cell Cell { get; init; }
        private CellInfoControl CellInfos { get; init; }

        internal CellControl(Game.Cell cell, CellInfoControl cellInfoControl)
        {
            Cell = cell;
            CellInfos = cellInfoControl;

            InitializeComponent();

            RefreshVisuals();
        }

        public void RefreshVisuals(double gridMaxScore = 1)
        {
            if (Cell.Discovered)
            {
                BackColor = Color.Gray;
                ValueLabel.Text = Cell.Value.ToString();
            }
            else
            {
                switch (Cell.Status)
                {
                    case Game.CellStatus.Safe:
                        BackColor = Color.Teal;
                        ValueLabel.Text = "Free !";
                        break;

                    case Game.CellStatus.Bomb:
                        BackColor = Color.Firebrick;
                        ValueLabel.Text = @"/!\";
                        break;

                    case Game.CellStatus.Useless:
                        BackColor = Color.Maroon;
                        ValueLabel.Text = "...";
                        break;

                    case Game.CellStatus.Default:
                        if(Cell.Safety >= 0)
                        {
                            double score = Cell.Score;

                            double scoreRatio = score / gridMaxScore;
                            double invRatio = 1 - scoreRatio;
                            BackColor = Color.FromArgb(
                                (int)((RedColor.R * invRatio) + (GreenColor.R * scoreRatio)),
                                (int)((RedColor.G * invRatio) + (GreenColor.G * scoreRatio)),
                                (int)((RedColor.B * invRatio) + (GreenColor.B * scoreRatio)));

                            ValueLabel.Text = $"{Math.Round(score, 2)}";
                        }
                        else
                        {
                            BackColor = Color.LightGray;
                            ValueLabel.Text = "";
                        }
                        break;

                    default:
                        throw new ApplicationException();
                }
            }
        }

        private void ValueLabel_Click(object sender, MouseEventArgs e)
        {
            Cell.Value = Helper.ModifyValueAccordingToClickEvent(Cell.Value, e);

            RefreshVisuals();
        }

        private void ValueLabel_MouseEnter(object sender, EventArgs e)
        {
            CellInfos.SetCell(Cell);
        }

        private void ValueLabel_MouseLeave(object sender, EventArgs e)
        {
            CellInfos.SetCell(null);
        }
    }
}
