//--------------------------------------------------------------------------------------------------------------------------------
//Name: LiveCellRule.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Class representing the rule which will act on live Cell objects. The rule states that a live cell continues
//          to remain alive if it has exactly 2 or 3 neighbors. In all other cases, it becomes dead.
//--------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Linq;
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeCoreLogic
{
    public class LiveCellRule : CellRule<ICell, IGrid<ICell>>
    {
        public override void Execute(ICell cell)
        {
            ValidateCell(cell);
            var neighbours = NeighbourCalculator.RetrieveNeighbours(cell.RowIndex, cell.ColIndex);
            var aliveNeighbours = neighbours.Where(n => n.IsAlive).ToList();
            if (aliveNeighbours.Count() < 2 || aliveNeighbours.Count() > 3)
            {
                cell.IsAlive = false;
            }
        }

        protected override void ValidateCell(ICell cell)
        {
            base.ValidateCell(cell);
            if (!cell.IsAlive)
            {
                throw new ArgumentException("This rule can only be applied to alive cells");
            }
        }
    }
}
