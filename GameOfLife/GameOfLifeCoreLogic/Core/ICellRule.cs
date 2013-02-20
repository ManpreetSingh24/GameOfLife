//--------------------------------------------------------------------------------------------------------------------------------
//Name: ICellRule.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by a class which will act as rule on a Cell object.
//--------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeCoreLogic.Core
{
    public interface ICellRule<TC, TG>
        where TC : ICell
        where TG : IGrid<TC>
    {
        void Execute(TC cell);
        INeighbourCalculator<TC, TG> NeighbourCalculator { get; set; }
        TG Grid { get; set; }
    }
}
