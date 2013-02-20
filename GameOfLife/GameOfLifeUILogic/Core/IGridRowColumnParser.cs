//--------------------------------------------------------------------------------------------------------------------------------
//Name: IGridRowColumnParser.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by classes which will return IGrid<ICell>
//          after parsing input string seperated by row and column seperator.
//--------------------------------------------------------------------------------------------------------------------------------
namespace GameOfLifeCoreLogic.Core
{
    public interface IGridRowColumnParser<TG> where TG : IGrid<ICell>
    {
        TG Parse(string gridRowColumnString, int numberofRows, int numberOfcolumns);
    }
}
