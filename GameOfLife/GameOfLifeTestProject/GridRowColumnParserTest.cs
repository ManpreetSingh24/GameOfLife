//--------------------------------------------------------------------------------------------------------------------------------
//Name: GridRowColumnParserTest.cs.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose :This is a test class for GridRowColumnParserTest and is intended to contain all GridRowColumnParserTest Unit Tests.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLifeCoreLogic.Core;

namespace GameOfLifeTestProject
{
    [TestClass()]
    public class GridRowColumnParserTest
    {
        private TestContext testContextInstance;
        
        //Gets or sets the test context which provides information about and functionality for the current test run.
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
        
        ///A test for Parse
        [TestMethod()]
        public void ParseTest()
        {
            char rowColumnPairsSeparator = ':'; // TODO: Initialize to an appropriate value
            char rowColumnSeparator = ','; // TODO: Initialize to an appropriate value
            GridRowColumnParser target = new GridRowColumnParser(rowColumnPairsSeparator, rowColumnSeparator); // TODO: Initialize to an appropriate value
            string gridRowColumnString = string.Empty; // TODO: Initialize to an appropriate value
            int numberofRows = 2; // TODO: Initialize to an appropriate value
            int numberOfcolumns = 2; // TODO: Initialize to an appropriate value
            IGrid<ICell> expected = null; // TODO: Initialize to an appropriate value
            IGrid<ICell> actual;
            actual = target.Parse(gridRowColumnString, numberofRows, numberOfcolumns);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
