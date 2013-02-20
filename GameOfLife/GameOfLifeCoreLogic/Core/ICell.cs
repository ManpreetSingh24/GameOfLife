//--------------------------------------------------------------------------------------------------------------------------------
//Name: ICell.cs
//Author: Manpreet Singh
//Date Of Creation : 19Feb-2013
//Purpose : Interface to be implemented by a class which represent a single cell in a IGrid{TC} object.
//--------------------------------------------------------------------------------------------------------------------------------
namespace GameOfLifeCoreLogic.Core
{
    public interface ICell
    {
        int RowIndex { get; set; }
        int ColIndex { get; set; }
        bool IsAlive { get; set; }
    }
}
