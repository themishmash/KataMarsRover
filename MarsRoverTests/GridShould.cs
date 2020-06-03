using System.Collections.Generic;
using kata_MarsRover;
using Moq;
using Xunit;

namespace MarsRoverTests
{
    public class GridShould
    {
        [Fact]
        public void GenerateSquaresInGridWithCorrectCoordinates()
        {
            var sut = new Grid(3, 3);
            var expectedGrid = new List<Location>()
            {
                new Location(0, 0), new Location(0, 1), new Location(0, 2),
                new Location(1, 0), new Location(1, 1), new Location(1, 2),
                new Location(2, 0), new Location(2, 1), new Location(2, 2),

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
           public void GenerateGridWithSpecifiedDimensions() //remove this
           {
               var sut = new Grid(3, 3);
               Assert.Equal(16, sut.GenerateGrid().Count);
           }

           [Fact]
           public void CreateThreeObstacles()
           {
               var sut = new Grid(3, 3);
               var mockObstacleRandomizer = new Mock<IObstacleRandomizer>();
               mockObstacleRandomizer.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>()))
                   .Returns(2) //(0,2)
                   .Returns(5) //(1,1)
                   .Returns(7);//(1,3)
               sut.AddObstacles(mockObstacleRandomizer.Object);
               
               Assert.True(sut.GetLocation(0, 2).HasObstacle);
               Assert.True(sut.GetLocation(1, 1).HasObstacle);
               Assert.True(sut.GetLocation(1, 3).HasObstacle);
               Assert.False(sut.GetLocation(0,0).HasObstacle);

           }
           

    }
}