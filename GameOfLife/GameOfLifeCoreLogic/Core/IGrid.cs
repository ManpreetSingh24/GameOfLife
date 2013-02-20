//--------------------------------------------------------------------------------------------------------------------------------
//Name: IGrid.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by class which will represent a grid in the game of life.
//--------------------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace GameOfLifeCoreLogic.Core
{
    public interface IGrid<TA> where TA : ICell
    {
        IEnumerable<TA> Cells { get; }
        int NumberOfRows { get; }
        int NumberOfColumns { get; }
        TA GetCellByIndex(int rowIndex, int columnIndex);
        void AddCell(TA cell);
    }
}
