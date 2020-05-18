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
        [Trait("Category", "Forward-North")]
        public void YCoordinateIncreaseByOneWhenFacingNorthAndMovingForward()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.North};
            var grid = new Grid(3,3);

            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-North")]
        public void YCoordinateResetsToOneWhenMovingForwardAndFacingNorthFromMaximumLength()
        {
            var initialPosition = new Position(0, 3) {Direction = Direction.North};
            var grid = new Grid(3, 3);
            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateResetsToMaxYValueWhenFacingSouthAndMovingForward()
        {

            var initialPosition = new Position(0, 0) {Direction = Direction.South};
            var grid = new Grid(3,3);
            var actualResult = Move.Forward(initialPosition, grid);
            
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }
        
        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.South};
            var grid = new Grid(3,3);

            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.East};
            var grid = new Grid(3,3);

            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateResetstoZeroWhenFacingEastAndMovingForwardFromUpperBoundary()
        {
            var initialPosition = new Position(3, 0) {Direction = Direction.East};
            var grid = new Grid(3, 3);
            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateDecreasesByOneWhenFacingWestAndMovingForward()
        {
            var initialPosition = new Position(2, 1) {Direction = Direction.West};
            var grid = new Grid(3, 3);
            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(1, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateResetsToMaxXCoordinateValueWhenFacingWestAndMovingForwardAtLowerBoundary()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.West};
            var grid = new Grid(3, 3);
            var actualResult = Move.Forward(initialPosition, grid);
            var expectedResult = new Position(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateDecreasesBy1WhenFacingNorthAndMovingBackward()
        {
            var initialPosition = new Position(0, 1) {Direction = Direction.North};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateResetsToMaxYValueWhenFacingNorthAndMovingBackwardFromLowerBoundary()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.North};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateDecreasesBy1WhenFacingEastAndMovingBackward()
        {
            var initialPosition = new Position(1, 0) {Direction = Direction.East};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateResetsToMaxXValueWhenFacingEastAndMovingBackwardFromLowerBoundary()
        {
            var initialPosition = new Position(0, 0) {Direction = Direction.East};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateIncreasesBy1WhenFacingSouthAndMovingBackward()
        {
            var initialPosition = new Position(1, 1) {Direction = Direction.South};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(1, 2);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateResetsToMinYValueWhenFacingSouthAndMovingBackwardFromUpperBoundary()
        {
            var initialPosition = new Position(0, 3) {Direction = Direction.South};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateIncreasesBy1WhenFacingWestAndMovingBackward()
        {
            var initialPosition = new Position(1, 0) {Direction = Direction.West};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(2, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateResetsToMinXValueWhenFacingWestAndMovingBackwardFromUpperBoundary()
        {
            var initialPosition = new Position(3, 0) {Direction = Direction.West};
            var grid = new Grid(3,3);
            var actualResult = Move.Backward(initialPosition, grid);
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }

        
        

    }
}