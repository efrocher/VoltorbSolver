namespace VoltorbSolver.Game
{
    public enum CellStatus
    {
        Default = 0, // Unknown
        Useless = 1, // Bomb or 1 point
        Bomb = 2,
        Safe = 3, // No risk 
    }

    internal sealed class Cell
    {
        public event EventHandler AnalysisChanged;

        public int Value { get; set; } = 0;
        public bool Discovered => Value > 0;

        public int[] Analysis { get; private set; } = null;
        public void SetAnalysis(int[] a)
        {
            if (
                (a is null != Analysis is null) 
                || (a is not null && Analysis is not null && (a[0] != Analysis[0] || a[1] != Analysis[1] || a[2] != Analysis[2] || a[3] != Analysis[3])))
            {
                Analysis = a;
                AnalysisChanged?.Invoke(this, new EventArgs());
            }
        }

        public CellStatus Status
        {
            get
            {
                if (Analysis is not null)
                {
                    if (Analysis[0] == 0)
                        return CellStatus.Safe;

                    int total = Analysis.Sum();

                    if (Analysis[0] == total)
                        return CellStatus.Bomb;

                    if (Analysis[0] + Analysis[1] == total)
                        return CellStatus.Useless;
                }

                return CellStatus.Default;
            }
        }
        public double Safety
        {
            get
            {
                if (Analysis is null)
                    return -1;

                int total = Analysis.Sum();
                return ((double)total - Analysis[0]) / total;
            }
        }
        public double Score
        {
            get
            {
                if (Analysis is null)
                    return -1;

                return ((Analysis[1] * 1) + (Analysis[2] * 2) + (Analysis[3] * 3)) / (double)Analysis.Sum() * Safety;
            }
        }

        public Cell() 
        { }
        public Cell(int value) { Value = value; }

        public void Reset()
        {
            Value = 0;
            SetAnalysis(null);
        }
    }
}
