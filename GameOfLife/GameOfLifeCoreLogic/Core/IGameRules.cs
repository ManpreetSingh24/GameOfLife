//--------------------------------------------------------------------------------------------------------------------------------
//Name: IGameRules.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by a class which will represent rules of the game of life.
//--------------------------------------------------------------------------------------------------------------------------------
namespace GameOfLifeCoreLogic.Core
{
    public interface IGameRules<TC, TG, TCR> where TC : ICell  where TG : IGrid<TC>  where TCR : ICellRule<TC, TG>
    {
        TCR LiveCellRule { get; }
        TCR DeadCellRule { get; }
    }
}
