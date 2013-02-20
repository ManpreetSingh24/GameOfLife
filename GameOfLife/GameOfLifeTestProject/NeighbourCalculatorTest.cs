using GameOfLifeCoreLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameOfLifeCoreLogic.Core;
using System.Collections.Generic;
using GameOfLifeCoreLogic;

namespace GameOfLifeTestProject
{
    
    
    /// <summary>
    ///This is a test class for NeighbourCalculatorTest and is intended
    ///to contain all NeighbourCalculatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NeighbourCalculatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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


        /// <summary>
        ///A test for RetrieveNeighbours
        ///</summary>
        [TestMethod()]
        public void RetrieveNeighboursTest()
        {
            NeighbourCalculator target = new NeighbourCalculator(); // TODO: Initialize to an appropriate value
            int rowIndex = 2; // TODO: Initialize to an appropriate value
            int columnIndex = 2; // TODO: Initialize to an appropriate value
            IEnumerable<ICell> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<ICell> actual;
            actual = target.RetrieveNeighbours(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
