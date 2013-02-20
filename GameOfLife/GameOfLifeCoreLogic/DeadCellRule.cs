//--------------------------------------------------------------------------------------------------------------------------------
//Name: DeadCellRule.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : class representing the rule which will act on dead Cell objects.The rule is that each dead cell with exactly
//          3 neighbors becomes alive, in rest all cases it remains to be dead.
//--------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Linq;
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeCoreLogic
{
    public class DeadCellRule : CellRule<ICell, IGrid<ICell>>
    {
        public override void Execute(ICell cell)
        {
            ValidateCell(cell);
            var neighbours = NeighbourCalculator.RetrieveNeighbours(cell.RowIndex, cell.ColIndex);
            var aliveNeighbours = neighbours.Where(n => n.IsAlive);
            if (aliveNeighbours.Count() == 3)
            {
                cell.IsAlive = true;
            }
        }

        protected override void ValidateCell(ICell cell)
        {
            base.ValidateCell(cell);
            if (cell.IsAlive)
            {
                throw new ArgumentException("This rule can only be applied to dead cells");
            }
        }
    }
}
