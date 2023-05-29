namespace VoltorbSolver.Game
{
    internal sealed class Line
    {
        private Cell[] Cells { get; } = new Cell[5];
        public Cell this[int index]
        {
            get => Cells[index];
        }

        public int TotalPoints { get; set; } = 5;
        public int TotalBombs { get; set; } = 1;

        public int DiscoveredCells => Cells.AsEnumerable().Count(c => c.Discovered);
        public int DiscoveredPoints => Cells.AsEnumerable().Sum(c => c.Discovered ? c.Value : 0);

        //public int AnalysedBombs => Cells.AsEnumerable().Count(c => c.Analysis[0] );


        public Line(Cell[] cell)
        {
            Cells = cell;

            //foreach (Cell c in cell)
            //    c.AnalysisChanged += new EventHandler((source, args) => Analyse());
        }

        public void ResetInfos()
        {
            TotalPoints = 5;
            TotalBombs = 1;
        }

        //public void Analyse()
        //{
        //    if (AnalysedBombs == TotalBombs)
        //    {
        //        foreach (Cell c in Cells.Where(c => c.Analysis != CellAnalysis.Bomb))
        //            c.AddAnalysis(CellAnalysis.Safe);
        //    }
        //    else if (DiscoveredPoints == TotalPoints)
        //    {
        //        foreach (Cell c in Cells)
        //        {
        //            if (!c.Discovered)
        //                c.AddAnalysis(CellAnalysis.Bomb);
        //        }
        //    }
        //    else
        //    {
        //        int remainingCells = 5 - DiscoveredCells;
        //        int remainingPoints = TotalPoints - DiscoveredPoints;

        //        if (remainingCells == remainingPoints + TotalBombs)
        //        {
        //            foreach (Cell c in Cells)
        //                c.AddAnalysis(CellAnalysis.Useless);
        //        }
        //    }
        //}
    }
}
