using System.Collections.Generic;
using System.Data;
using kata_MarsRover;
using Xunit;
using Moq;

namespace MarsRoverTests
{
    public class MoveShould
    {
        [Fact]
        public void YCoordinateIncreaseByOneWhenFacingNorthAndMovingForward()
        {
            
            var sut = new Move(new Square(0,0), Direction.N, new IGrid(3, 3));
            var actualResult = sut.Forward();
            var expectedResult = new Square(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
          
        }

        [Fact]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            var sut = new Move(new Square(0,0), Direction.E, );
            var actualResult = sut.Forward();
            var expectedResult = new Square(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        [Fact]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            Mock<IGrid> mockGrid = new Mock<IGrid>();
            var expectedGrid = new List<Square>()
            {
                new Square(0, 0), new Square(0, 1), new Square(0, 2),
                new Square(1, 0), new Square(1, 1), new Square(1, 2),
                new Square(2, 0), new Square(2, 1), new Square(2, 2),

            };
            mockGrid.Setup(g => g.GenerateGrid()).Returns(expectedGrid);
            var sut = new Move(new Square(0,0), Direction.S, mockGrid.Object);
            var actualResult = sut.Forward();
            var expectedResult = new Square(0, 2);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

    }
}