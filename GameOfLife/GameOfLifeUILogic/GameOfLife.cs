//--------------------------------------------------------------------------------------------------------------------------------
//Name: Game of Life.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Class which starts the game and set all the required parameters.
//--------------------------------------------------------------------------------------------------------------------------------
using System;
using GameOfLifeUILogic.Core;
using GameOfLifeUILogic.Extensions;
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeUILogic
{
    public class GameOfLife : IGameOfLife
    {
        #region Fields

        private int _numberOfRows;
        private int _numberOfColumns;
        private int _numberOfEvolutions;
        private IGrid<ICell> _userGrid;
        private readonly IGridRowColumnParser<IGrid<ICell>> _gridRowColumnParser;
        private readonly IEvolution<ICell, IGrid<ICell>> _evolution;

        #endregion

        #region Constructor

        public GameOfLife(IEvolution<ICell, IGrid<ICell>> evolution, IGridRowColumnParser<IGrid<ICell>> gridRowColumnParser)
        {
            _evolution = evolution;
            _gridRowColumnParser = gridRowColumnParser;
        }

        #endregion

        #region Public Function Exposed

        public void StartTheGame()
        {
            do
            {
                //Print the Game Instructions on the Console screen
                PrintGameHeader();
                //Get the Number of Rows
                while (!NumberOfRowsGet())
                    InvalidInput();
                //Get the Number of Columns
                while (!NumberOfColumnsGet())
                    InvalidInput();
                //Get the Live cell location to be shown in 2D array.
                while (!LiveCellsGet())
                    InvalidInput();
                //Get the number of times the Matrix is evaluated.
                while (!NumberOfEvolutions())
                    InvalidInput();
                Console.WriteLine("Following Grid will be used:");
                //Print the Formed Matrix
                Console.WriteLine(_userGrid.ToConsoleFormattedString());
                Console.WriteLine("Press Enter key to continue.");
                Console.ReadLine();
                StartEvolution();
            } while (GetUserConfirmation());

        }
        #endregion

        #region Private Function Exposed

        private void PrintGameHeader()
        {
            Console.WriteLine("------------------------------GAME OF LIFE--------------------------------\n");
            Console.WriteLine("INSTRUCTIONS..\n");
            Console.WriteLine("1.Specify the size of the Grid.");
            Console.WriteLine("2.Choose the initial live cells location in the Grid.");
            Console.WriteLine("3.The number of times you want the Grid to evolve or change.");
            Console.WriteLine("4.Specify the live cells in the format : rowIndex,colIndex : rowIndex,colIndex : ....\n");
            Console.WriteLine("REPRESENTATION..\n");
            Console.WriteLine("1.Live cell is represented by X");
            Console.WriteLine("2.Dead cell is represented by -\n\n");
            Console.WriteLine("RULES OF LIFE..\n");
            Console.WriteLine("1.Any Live cell with fewer than two live neighbours dies,as if by loneliness.");
            Console.WriteLine("2.Any Live cell with more than three live neighbours dies,as if by overcrowding.");
            Console.WriteLine("3.Any Live cell with two or three live neighbours lives, unchanged, to the next generation.");
            Console.WriteLine("4.Any Dead cell with exactly three live neighbours comes to life, to the next generation.\n");
            Console.WriteLine("Please enter te following required inputs to continue...\n");
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }
        private bool NumberOfRowsGet()
        {
            Console.WriteLine("Enter number of rows followed by Enter key:");
            return Int32.TryParse(Console.ReadLine(), out _numberOfRows);
        }
        private bool NumberOfColumnsGet()
        {
            Console.WriteLine("Enter number of columns followed by Enter key.");
            return Int32.TryParse(Console.ReadLine(), out _numberOfColumns);
        }
        private bool LiveCellsGet()
        {
            Console.WriteLine("Enter live cells locations in the format mentioned in Instructions above : rowIndex,colIndex : rowIndex,colIndex :....followed by Enter key");
            var userInput = Console.ReadLine();
            var result = false;
            try
            {
                _userGrid = _gridRowColumnParser.Parse(userInput, _numberOfRows, _numberOfColumns);
                result = true;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("Following error occurred : " + exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unknown error occurred : " + exception.Message);
            }
            return result;
        }
        private bool NumberOfEvolutions()
        {
            Console.WriteLine("Enter number of Evolutions followed by Enter key....");
            return Int32.TryParse(Console.ReadLine(), out _numberOfEvolutions);
        }
        private void InvalidInput()
        {
            Console.WriteLine("Invalid input.Please enter again");
        }
        private void StartEvolution()
        {
            for (int count = 0; count < _numberOfEvolutions; count++)
            {
                _evolution.Execute(_userGrid);
                Console.WriteLine("Grid after {0} evolution(s). Press enter to continue", count + 1);
                Console.WriteLine(_userGrid.ToConsoleFormattedString());
                Console.ReadLine();
            }
        }
        private bool GetUserConfirmation()
        {
            Console.WriteLine("Press Y followed by the Enter key to continue.");
            var userInput = Console.ReadLine();
            if (string.Equals(userInput.Trim(), "Y", StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }

        #endregion
    }
}
