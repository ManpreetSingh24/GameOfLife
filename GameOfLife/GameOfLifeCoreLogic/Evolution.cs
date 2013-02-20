//--------------------------------------------------------------------------------------------------------------------------------
//Name: Evolution.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : class which applies rules on  the Cell objects of IGrid{ICell} to evolved it.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic.Core;
using GameOfLifeCoreLogic.Extensions;

namespace GameOfLifeCoreLogic
{
    public class Evolution : IEvolution<ICell, IGrid<ICell>>
    {
        private INeighbourCalculator<ICell, IGrid<ICell>> _neighbourCalculator;
        private IGameRules<ICell, IGrid<ICell>, ICellRule<ICell, IGrid<ICell>>> _gameRules;

        public Evolution(INeighbourCalculator<ICell, IGrid<ICell>> neighbourCalculator,
                         IGameRules<ICell, IGrid<ICell>, ICellRule<ICell, IGrid<ICell>>> gameRules)
        {
            _neighbourCalculator = neighbourCalculator;
            _gameRules = gameRules;
            _gameRules.LiveCellRule.NeighbourCalculator = neighbourCalculator;
            _gameRules.DeadCellRule.NeighbourCalculator = neighbourCalculator;
        }
        public void Execute(IGrid<ICell> currentGrid)
        {
            var gridCopy = currentGrid.GetDeepCopy();
            _neighbourCalculator.Grid = gridCopy;
            _gameRules.LiveCellRule.Grid = gridCopy;
            _gameRules.DeadCellRule.Grid = gridCopy;
            foreach (var cell in currentGrid.Cells)
            {
                if (cell.IsAlive)
                {
                    _gameRules.LiveCellRule.Execute(cell);
                }
                else
                {
                    _gameRules.DeadCellRule.Execute(cell);
                }
            }
        }
    }
}
