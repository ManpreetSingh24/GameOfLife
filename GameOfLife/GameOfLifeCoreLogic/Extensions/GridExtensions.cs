//--------------------------------------------------------------------------------------------------------------------------------
//Name: GridExtensions.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Extension class for <see cref="IGrid{ICell}"/>.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeCoreLogic.Extensions
{
    public static class GridExtensions
    {
        public static IGrid<ICell> GetDeepCopy(this IGrid<ICell> grid)
        {
            var gridCopy = new Grid(grid.NumberOfRows, grid.NumberOfColumns);
            foreach (var cell in grid.Cells)
            {
                var cellCopy = new Cell { RowIndex = cell.RowIndex, ColIndex = cell.ColIndex, IsAlive = cell.IsAlive };
                gridCopy.AddCell(cellCopy);
            }

            return gridCopy;
        }
    }
}
