//--------------------------------------------------------------------------------------------------------------------------------
//Name: IEvolution.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Interface to be implemented by a class which will evolve cells in a grid using the game rules.
//--------------------------------------------------------------------------------------------------------------------------------
namespace GameOfLifeCoreLogic.Core
{
    public interface IEvolution<TC, TG> where TC : ICell where TG : IGrid<TC>
    {
        void Execute(TG currentGrid);
    }
}
