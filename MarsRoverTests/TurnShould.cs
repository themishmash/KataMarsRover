using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class TurnShould
    {
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToEastIfFacingNorthAndTurningRight()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.North});
            var actualResult = sut.Right();
            var expectedResult = new Position(0, 0){Direction = Direction.East};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToSouthIfFacingEastAndTurningRight()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.East});
            var actualResult = sut.Right();
            var expectedResult = new Position(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToWestIfFacingSouthAndTurningRight()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.South});
            var actualResult = sut.Right();
            var expectedResult = new Position(0, 0){Direction = Direction.West};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnRight")]
        public void ChangeDirectionToNorthIfFacingWestAndTurningRight()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.West});
            var actualResult = sut.Right();
            var expectedResult = new Position(0, 0){Direction = Direction.North};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToWestIfFacingNorthAndTurningLeft()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.North});
            var actualResult = sut.Left();
            var expectedResult = new Position(0, 0){Direction = Direction.West};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToNorthIfFacingEastAndTurningLeft()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.East});
            var actualResult = sut.Left();
            var expectedResult = new Position(0, 0){Direction = Direction.North};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToEastIfFacingSouthAndTurningLeft()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.South});
            var actualResult = sut.Left();
            var expectedResult = new Position(0, 0){Direction = Direction.East};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
        [Fact]
        [Trait("Category", "TurnLeft")]
        public void ChangeDirectionToSouthIfFacingWestAndTurningLeft()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.West});
            var actualResult = sut.Left();
            var expectedResult = new Position(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
    }
}