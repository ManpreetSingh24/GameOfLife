//--------------------------------------------------------------------------------------------------------------------------------
//Name: Program.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Main Class which starts the game and set all the required parameters.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic;
using GameOfLifeUILogic.Core;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the required core Logic Classes
            var neighbourCalculator = new NeighbourCalculator();
            var gameRules = new GameRules(new LiveCellRule(), new DeadCellRule());
            var evolution = new Evolution(neighbourCalculator, gameRules);
            var gridRowColumnParser = new GridRowColumnParser();
            //Implemented Constructor based DI.
            IGameOfLife gameOfLife = new GameOfLifeUILogic.GameOfLife(evolution, gridRowColumnParser);
            gameOfLife.StartTheGame();
        }
    }
}
