using System.Collections.Generic;
using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class GridShould
    {
        [Fact]
        public void GenerateSquaresInGridWithCorrectCoordinates()
        {
            var sut = new Grid(3, 3);
            var expectedGrid = new List<Position>()
            {
                new Position(0, 0), new Position(0, 1), new Position(0, 2),
                new Position(1, 0), new Position(1, 1), new Position(1, 2),
                new Position(2, 0), new Position(2, 1), new Position(2, 2),

            };

            var actualGrid = sut.GenerateGrid();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.Equal(expectedGrid[i].XCoordinate, actualGrid[i].XCoordinate);
                    Assert.Equal(expectedGrid[j].YCoordinate, actualGrid[j].YCoordinate);
                }

            }

        }

        [Fact]
           public void GenerateGridWithSpecifiedDimensions()
           {
               var sut = new Grid(3, 3);
               Assert.Equal(16, sut.GenerateGrid().Count);
           }
           

    }
}