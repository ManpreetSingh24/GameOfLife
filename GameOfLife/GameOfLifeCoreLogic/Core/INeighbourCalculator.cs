//--------------------------------------------------------------------------------------------------------------------------------
//Name: INeighbourCalculator.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by a class which can be used to calculate neighboring cells of any particular cell.
//--------------------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace GameOfLifeCoreLogic.Core
{
    public interface INeighbourCalculator<TC, TG>  where TC : ICell where TG : IGrid<TC>
    {
        IEnumerable<TC> RetrieveNeighbours(int rowIndex, int columnIndex);
        TG Grid { get; set; }
    }
}
