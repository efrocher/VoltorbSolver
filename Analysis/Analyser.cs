using Microsoft.Z3;
using VoltorbSolver.Game;

namespace VoltorbSolver.Analysis
{
    internal static class Z3Analyser
    {
        private const int CASE_MAX_VALUE = 3;

        private readonly static Context Ctx;
        private readonly static IntExpr[,] Cases; // 0 = Bomb, 1 | 2 | 3 = Points
        private readonly static BoolExpr Rules;

        static Z3Analyser()
        {
            // Context
            Ctx = new Context();

            // Cases 
            Cases = new IntExpr[5, 5];
            for (uint x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Cases[x, y] = (IntExpr)Ctx.MkConst($"c:{x}-{y}", Ctx.IntSort);
                }
            }

            // Rules
            Rules = Ctx.MkTrue();

            // Valeur min et max de chaque case
            BoolExpr[][] casesMinMax_rules = new BoolExpr[5][];
            for(uint x = 0; x < 5; x++)
            {
                casesMinMax_rules[x] = new BoolExpr[5];
                for (uint y = 0; y < 5; y++)
                {
                    casesMinMax_rules[x][y] = Ctx.MkAnd(
                        Ctx.MkGe(Cases[x, y], Ctx.MkInt(0)), // Pas de total points négatif
                        Ctx.MkLe(Cases[x, y], Ctx.MkInt(CASE_MAX_VALUE))); // Max 3 points dans une case
                }
            }

            foreach (BoolExpr[] exprs in casesMinMax_rules)
                Rules = Ctx.MkAnd(Rules, Ctx.MkAnd(exprs));
        }

        public static int Analyse(Grid grid)
        {
            using Solver s = MakeSolver(grid);

            int[,][] allSolutionsCounted = new int[5, 5][];
            for(int x = 0; x < 5; x++)
            {
                for(int y = 0; y < 5; y++)
                {
                    allSolutionsCounted[x, y] = new int[4];
                }
            }

            int solutionsCount = 0;
            while (s.Check() == Status.SATISFIABLE)
            {
                solutionsCount++;

                BoolExpr[] currentSolution = new BoolExpr[25];
                for(int x = 0, i = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++, i++)
                    {
                        Expr expr = s.Model.Eval(Cases[x, y]);
                        currentSolution[i] = Ctx.MkEq(Cases[x, y], expr);
                        allSolutionsCounted[x, y][int.Parse(expr.ToString())]++;
                    }
                }

                // Forbid current solution
                s.Assert(Ctx.MkNot(Ctx.MkAnd(currentSolution)));
            }

            // Conclusion de l'analyse
            for (int x = 0, i = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++, i++)
                {
                    grid[x, y].SetAnalysis(allSolutionsCounted[x, y]);
                }
            }

            return solutionsCount;
        }
        private static Solver MakeSolver(Grid grid)
        {
            Solver s = Ctx.MkSolver();

            BoolExpr instance = Ctx.MkTrue();

            BoolExpr[] rowPoints_rule = new BoolExpr[5];
            BoolExpr[] colPoints_rule = new BoolExpr[5];
            BoolExpr[] rowBombs_rule = new BoolExpr[5];
            BoolExpr[] colBombs_rule = new BoolExpr[5];
            int[] coeffs = new int[5] { 1, 1, 1, 1, 1 };
            IntNum zero = Ctx.MkInt(0);
            for (int i = 0; i < 5; i++)
            {
                rowPoints_rule[i] = Ctx.MkEq(
                    Ctx.MkInt(grid.Rows[i].TotalPoints),
                    Ctx.MkAdd(
                        Cases[0, i],
                        Cases[1, i],
                        Cases[2, i],
                        Cases[3, i],
                        Cases[4, i]));

                colPoints_rule[i] = Ctx.MkEq(
                    Ctx.MkInt(grid.Columns[i].TotalPoints),
                    Ctx.MkAdd(
                        Cases[i, 0],
                        Cases[i, 1],
                        Cases[i, 2],
                        Cases[i, 3],
                        Cases[i, 4]));

                rowBombs_rule[i] = Ctx.MkPBEq(
                    coeffs,
                    new BoolExpr[5]
                    {
                        Ctx.MkEq(Cases[0, i], zero),
                        Ctx.MkEq(Cases[1, i], zero),
                        Ctx.MkEq(Cases[2, i], zero),
                        Ctx.MkEq(Cases[3, i], zero),
                        Ctx.MkEq(Cases[4, i], zero),
                    },
                    grid.Rows[i].TotalBombs);

                colBombs_rule[i] = Ctx.MkPBEq(
                    coeffs,
                    new BoolExpr[5]
                    {
                        Ctx.MkEq(Cases[i, 0], zero),
                        Ctx.MkEq(Cases[i, 1], zero),
                        Ctx.MkEq(Cases[i, 2], zero),
                        Ctx.MkEq(Cases[i, 3], zero),
                        Ctx.MkEq(Cases[i, 4], zero),
                    },
                    grid.Columns[i].TotalBombs);
            }

            BoolExpr caseValues_rule = Ctx.MkTrue();
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (grid[x, y].Discovered)
                    {
                        caseValues_rule = Ctx.MkAnd(
                            caseValues_rule,
                            Ctx.MkEq(
                                Cases[x, y],
                                Ctx.MkInt(grid[x, y].Value)));
                    }
                }
            }

            instance = Ctx.MkAnd(instance, Ctx.MkAnd(rowPoints_rule));
            instance = Ctx.MkAnd(instance, Ctx.MkAnd(colPoints_rule));
            instance = Ctx.MkAnd(instance, Ctx.MkAnd(rowBombs_rule));
            instance = Ctx.MkAnd(instance, Ctx.MkAnd(colBombs_rule));

            instance = Ctx.MkAnd(instance, caseValues_rule);

            s.Assert(Rules);
            s.Assert(instance);

            return s;
        }
    }
}
