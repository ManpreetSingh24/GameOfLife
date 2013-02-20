//--------------------------------------------------------------------------------------------------------------------------------
//Name: CellRule.cs
//Author: Manpreet Singh
//Date Of Creation : 19Feb-2013
//Purpose : Abstract class that should be implemented by a class representing rule to act on Cell objects.
//--------------------------------------------------------------------------------------------------------------------------------
using System;

namespace GameOfLifeCoreLogic.Core
{
    public abstract class CellRule<TC, TG> : ICellRule<TC, TG>
        where TC : ICell
        where TG : IGrid<TC>
    {
        public abstract void Execute(TC cell);
        public INeighbourCalculator<TC, TG> NeighbourCalculator { get; set; }
        public TG Grid { get; set; }
        protected virtual void ValidateCell(TC cell)
        {
            if (Grid == null)
            {
                throw new Exception("Grid needs to be set before calling this method");
            }

            if (NeighbourCalculator == null)
            {
                throw new Exception("NeighbourCalculator needs to be set before calling this method");
            }

            if (cell == null)
            {
                throw new ArgumentNullException("cell", "Cannot be null");
            }
        }
    }
}
