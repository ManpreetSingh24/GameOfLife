﻿//--------------------------------------------------------------------------------------------------------------------------------
//Name: TestObjects.cs
//Author: Manpreet Singh
//Date Of Creation : 19-Feb-2013
//Purpose : Created TestObjects to be used in Unit Level testing.
//--------------------------------------------------------------------------------------------------------------------------------
using GameOfLifeCoreLogic;

namespace GameOfLifeTestProject
{
    public static class TestObjects
    {
        public static Grid TwoxTwoGrid;
        public static Grid ThreexThreeGrid;

        static TestObjects()
        {
            CreateAndInitializeTwoxTwoGrid();
            CreateAndInitializeThreexThreeGrid();
        }
        private static void CreateAndInitializeTwoxTwoGrid()
        {
            TwoxTwoGrid = new Grid(2, 2);

            TwoxTwoGrid.AddCell(new Cell() { RowIndex = 0, ColIndex = 0 });
            TwoxTwoGrid.AddCell(new Cell() { RowIndex = 0, ColIndex = 1 });
            TwoxTwoGrid.AddCell(new Cell() { RowIndex = 1, ColIndex = 0 });
            TwoxTwoGrid.AddCell(new Cell() { RowIndex = 1, ColIndex = 1 });
        }
        private static void CreateAndInitializeThreexThreeGrid()
        {
            ThreexThreeGrid = new Grid(3, 3);

            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 0, ColIndex = 0 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 0, ColIndex = 1 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 0, ColIndex = 2 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 1, ColIndex = 0 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 1, ColIndex = 1 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 1, ColIndex = 2 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 2, ColIndex = 0 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 2, ColIndex = 1 });
            ThreexThreeGrid.AddCell(new Cell() { RowIndex = 2, ColIndex = 2 });
        }
    }
}
