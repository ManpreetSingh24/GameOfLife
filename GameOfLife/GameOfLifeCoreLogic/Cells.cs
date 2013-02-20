//--------------------------------------------------------------------------------------------------------------------------------
//Name: Cells.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Class used to represent a cell that can be used in a IGrid{TC}" object.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeCoreLogic
{
    public class Cell : ICell
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public bool IsAlive { get; set; }
    }
}
