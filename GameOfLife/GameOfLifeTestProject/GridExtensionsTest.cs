//--------------------------------------------------------------------------------------------------------------------------------
//Name: GridExtensionsTest.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose :This is a test class for GridExtensionsTest and is intended to contain all GridExtensionsTest Unit Tests.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeUILogic.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeTestProject
{
    [TestClass()]
    public class GridExtensionsTest
    {
        private TestContext testContextInstance;

        ///Gets or sets the test context which provides information about and functionality for the current test run.
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        
        //A test for ToConsoleFormattedString
        [TestMethod()]
        public void ToConsoleFormattedStringTest()
        {
            IGrid<ICell> grid = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = GridExtensions.ToConsoleFormattedString(grid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        [TestMethod()]
        public void Testing_ToConsoleFormattedString_ForTwoxTwoGrid()
        {
            var grid = TestObjects.TwoxTwoGrid;
            InitializeTwoxTwoGrid(false);
            //- -
            //- -
            var expectedString = "- - " + Environment.NewLine + "- - " + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(),expectedString);

            InitializeTwoxTwoGrid(true);
            //X X
            //X X
            expectedString = "X X " + Environment.NewLine + "X X " + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(), expectedString);

            InitializeTwoxTwoGrid(false);
            grid.GetCellByIndex(0, 0).IsAlive = true;
            grid.GetCellByIndex(1, 0).IsAlive = true;
            //X -
            //X -
            expectedString = "X - " + Environment.NewLine + "X - " + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(), expectedString);
        }
        private void InitializeTwoxTwoGrid(bool isAlive)
        {
            var grid = TestObjects.TwoxTwoGrid;

            foreach (var cell in grid.Cells)
            {
                cell.IsAlive = isAlive;
            }
        }
        [TestMethod()]
        public void Testing_ToConsoleFormattedString_ForThreexThreeGrid()
        {
            var grid = TestObjects.ThreexThreeGrid;
            InitializeThreexThreeGrid(false);
            //- - -
            //- - - 
            //- - - 
            var expectedString = "- - - " + Environment.NewLine + "- - - " + Environment.NewLine + "- - - " + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(), expectedString);

            InitializeThreexThreeGrid(true);
            //X X X 
            //X X X 
            //X X X 
            expectedString = "X X X " + Environment.NewLine + "X X X " + Environment.NewLine + "X X X" + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(), expectedString);

            InitializeThreexThreeGrid(false);
            grid.GetCellByIndex(0, 0).IsAlive = true;
            grid.GetCellByIndex(0, 2).IsAlive = true;
            grid.GetCellByIndex(1, 0).IsAlive = true;
            grid.GetCellByIndex(2, 1).IsAlive = true;
            //X - X 
            //X - - 
            //- X - 
            expectedString = "X - X " + Environment.NewLine + "X - - " + Environment.NewLine + "- X - " + Environment.NewLine;
            Assert.AreEqual(grid.ToConsoleFormattedString(), expectedString);
        }
        private void InitializeThreexThreeGrid(bool isAlive)
        {
            var grid = TestObjects.ThreexThreeGrid;

            foreach (var cell in grid.Cells)
            {
                cell.IsAlive = isAlive;
            }
        }
    }
}
