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
        [Trait("Category", "North")]
        public void YCoordinateIncreaseByOneWhenFacingNorthAndMovingForward()
        {
           var sut = new Move(new Position(0,0), Direction.N, new Grid(3,3));

            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "North")]
        public void YCoordinateResetsToOneWhenMovingForwardAndFacingNorthFromMaximumLength()
        {
            var sut = new Move(new Position(0, 3), Direction.N, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 0);
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "South")]
        public void YCoordinateResetsToMaxYValueWhenFacingSouthAndMovingForward()
        {
            
            var sut = new Move(new Position(0,0), Direction.S, new Grid(3,3) );
            var actualResult = sut.Forward();
            
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }
        
        [Fact]
        [Trait("Category", "South")]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            var sut = new Move(new Position(0,0), Direction.S, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        

        [Fact]
        [Trait("Category", "East")]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            var sut = new Move(new Position(0,0), Direction.E, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Position(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        [Fact]
        [Trait("Category", "East")]
        public void XCoordinateResetstoZeroWhenFacingEastAndMovingForwardFromUpperBoundary()
        {
            var sut = new Move(new Position(3, 0), Direction.E, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "West")]
        public void XCoordinateDecreasesByOneWhenFacingWestAndMovingForward()
        {
            var sut = new Move(new Position(2, 1), Direction.W, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(1, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "West")]
        public void XCoordinateResetsToMaxXCoordinateValueWhenFacingWestAndMovingForwardAtLowerBoundary()
        {
            var sut = new Move(new Position(0, 0), Direction.W, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        


    }
}