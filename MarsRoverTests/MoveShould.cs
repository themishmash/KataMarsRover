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
           var sut = new Move(new Location(0,0) {Direction = Direction.North}, new Grid(3,3));

            var actualResult = sut.Forward();
            var expectedResult = new Location(0, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-North")]
        public void YCoordinateResetsToOneWhenMovingForwardAndFacingNorthFromMaximumLength()
        {
            var sut = new Move(new Location(0, 3) {Direction =  Direction.North}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Location(0, 0);
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateResetsToMaxYValueWhenFacingSouthAndMovingForward()
        {
            
            var sut = new Move(new Location(0,0) {Direction = Direction.South}, new Grid(3,3) );
            var actualResult = sut.Forward();
            
            var expectedResult = new Location(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }
        
        [Fact]
        [Trait("Category", "Forward-South")]
        public void YCoordinateDecreasesByOneWhenFacingSouthAndMovingForward()
        {
            var sut = new Move(new Location(0,0){Direction = Direction.South}, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Location(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateIncreasesByOneWhenFacingEastAndMovingForward()
        {
            var sut = new Move(new Location(0,0){ Direction = Direction.East}, new Grid(3,3) );

            var actualResult = sut.Forward();
            var expectedResult = new Location(1, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            
        }

        [Fact]
        [Trait("Category", "Forward-East")]
        public void XCoordinateResetstoZeroWhenFacingEastAndMovingForwardFromUpperBoundary()
        {
            var sut = new Move(new Location(3, 0){Direction = Direction.East}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Location(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateDecreasesByOneWhenFacingWestAndMovingForward()
        {
            var sut = new Move(new Location(2, 1) {Direction = Direction.West}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Location(1, 1);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }
        
        [Fact]
        [Trait("Category", "Forward-West")]
        public void XCoordinateResetsToMaxXCoordinateValueWhenFacingWestAndMovingForwardAtLowerBoundary()
        {
            var sut = new Move(new Location(0, 0){Direction = Direction.West}, new Grid(3, 3) );
            var actualResult = sut.Forward();
            var expectedResult = new Location(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
        }

        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateDecreasesBy1WhenFacingNorthAndMovingBackward()
        {
            var sut = new Move(new Location(0,1) {Direction = Direction.North}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-North")]
        public void YCoordinateResetsToMaxYValueWhenFacingNorthAndMovingBackwardFromLowerBoundary()
        {
            var sut = new Move(new Location(0,0) {Direction = Direction.North}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(0, 3);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateDecreasesBy1WhenFacingEastAndMovingBackward()
        {
            var sut = new Move(new Location(1,0) {Direction = Direction.East}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-East")]
        public void XCoordinateResetsToMaxXValueWhenFacingEastAndMovingBackwardFromLowerBoundary()
        {
            var sut = new Move(new Location(0,0) {Direction = Direction.East}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(3, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateIncreasesby1WhenFacingSouthAndMovingBackward()
        {
            var sut = new Move(new Location(1,1) {Direction = Direction.South}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(1, 2);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-South")]
        public void YCoordinateResetsToMinYValueWhenFacingSouthAndMovingBackwardFromUpperBoundary()
        {
            var sut = new Move(new Location(0,3) {Direction = Direction.South}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateIncreasesBy1WhenFacingWestAndMovingBackward()
        {
            var sut = new Move(new Location(1,0) {Direction = Direction.West}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(2, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "Backward-West")]
        public void XCoordinateResetsToMinXValueWhenFacingWestAndMovingBackwardFromUpperBoundary()
        {
            var sut = new Move(new Location(3,0) {Direction = Direction.West}, new Grid(3,3));
            var actualResult = sut.Backward();
            var expectedResult = new Location(0, 0);
            
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);

        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToEastIfFacingNorthAndTurningRight()
        {
            var position = new Location(0,0 ){Direction = Direction.North};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Right();
            var expectedResult = new Location(0, 0){Direction = Direction.East};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToSouthIfFacingEastAndTurningRight()
        {
            var position = new Location(0,0 ){Direction = Direction.East};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Right();
            var expectedResult = new Location(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToWestIfFacingSouthAndTurningRight()
        {
            var position = new Location(0,0 ){Direction = Direction.South};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Right();
            var expectedResult = new Location(0, 0){Direction = Direction.West};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToNorthIfFacingWestAndTurningRight()
        {
            var position = new Location(0,0 ){Direction = Direction.West};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Right();
            var expectedResult = new Location(0, 0){Direction = Direction.North};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToWestIfFacingNorthAndTurningLeft()
        {
            var position = new Location(0,0 ){Direction = Direction.North};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Left();
            var expectedResult = new Location(0, 0){Direction = Direction.West};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToNorthIfFacingEastAndTurningLeft()
        {
            var position = new Location(0,0 ){Direction = Direction.East};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Left();
            var expectedResult = new Location(0, 0){Direction = Direction.North};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToEastIfFacingSouthAndTurningLeft()
        {
            var position = new Location(0,0 ){Direction = Direction.South};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Left();
            var expectedResult = new Location(0, 0){Direction = Direction.East};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToSouthIfFacingWestAndTurningLeft()
        {
            var position = new Location(0,0 ){Direction = Direction.West};
            var sut = new Move(position, new Grid(3, 3));
            var actualResult = sut.Left();
            var expectedResult = new Location(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }

    }
    
    //can consider using theory and inline data since some of these are duplicated

}