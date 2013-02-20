//--------------------------------------------------------------------------------------------------------------------------------
//Name: GameRules.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Class which represents rules that will be applied on dead and live cells in the game of life.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeCoreLogic
{
    public class GameRules : IGameRules<ICell, IGrid<ICell>, ICellRule<ICell, IGrid<ICell>>>
    {
        public GameRules(ICellRule<ICell, IGrid<ICell>> liveCellRule, ICellRule<ICell, IGrid<ICell>> deadCellRule)
        {
            LiveCellRule = liveCellRule;
            DeadCellRule = deadCellRule;
        }
        public ICellRule<ICell, IGrid<ICell>> LiveCellRule { get; private set; }
        public ICellRule<ICell, IGrid<ICell>> DeadCellRule { get; private set; }
    }
}
