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
           var sut = new Move(new Position(0,0) {Direction = Direction.N}, new Grid(3,3));

            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-North")]
        public void YCoordinateResetsToOneWhenMovingForwardAndFacingNorthFromMaximumLength()
        {
            var sut = new Move(new Position(0, 3) {Direction =  Direction.N}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 0);
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateResetsToMaxYValueWhenFacingSouthAndMovingForward()
        {
            
            var sut = new Move(new Position(0,0) {Direction = Direction.S}, new Grid(3,3) );
            var actualResult = sut.Forward();
            
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }
        
        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            var sut = new Move(new Position(0,0){Direction = Direction.S}, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            var sut = new Move(new Position(0,0){ Direction = Direction.E}, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Position(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateResetstoZeroWhenFacingEastAndMovingForwardFromUpperBoundary()
        {
            var sut = new Move(new Position(3, 0){Direction = Direction.E}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateDecreasesByOneWhenFacingWestAndMovingForward()
        {
            var sut = new Move(new Position(2, 1) {Direction = Direction.W}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(1, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateResetsToMaxXCoordinateValueWhenFacingWestAndMovingForwardAtLowerBoundary()
        {
            var sut = new Move(new Position(0, 0){Direction = Direction.W}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Position(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateDecreasesBy1WhenFacingNorthAndMovingBackward()
        {
            var sut = new Move(new Position(0,1) {Direction = Direction.N}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateResetsToMaxYValueWhenFacingNorthAndMovingBackwardFromLowerBoundary()
        {
            var sut = new Move(new Position(0,0) {Direction = Direction.N}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateDecreasesBy1WhenFacingEastAndMovingBackward()
        {
            var sut = new Move(new Position(1,0) {Direction = Direction.E}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateResetsToMaxXValueWhenFacingEastAndMovingBackwardFromLowerBoundary()
        {
            var sut = new Move(new Position(0,0) {Direction = Direction.E}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateIncreasesby1WhenFacingSouthAndMovingBackward()
        {
            var sut = new Move(new Position(1,1) {Direction = Direction.S}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(1, 2);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateResetsToMinYValueWhenFacingSouthAndMovingBackwardFromUpperBoundary()
        {
            var sut = new Move(new Position(0,3) {Direction = Direction.S}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateIncreasesBy1WhenFacingWestAndMovingBackward()
        {
            var sut = new Move(new Position(1,0) {Direction = Direction.W}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(2, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateResetsToMinXValueWhenFacingWestAndMovingBackwardFromUpperBoundary()
        {
            var sut = new Move(new Position(3,0) {Direction = Direction.W}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Position(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }

        
        

    }
}