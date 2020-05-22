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
            var position = new Position(0,0 ){Direction = Direction.North};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.East};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.South};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.West};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.North};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.East};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.South};
            var sut = new Turn(position);
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
            var position = new Position(0,0 ){Direction = Direction.West};
            var sut = new Turn(position);
            var actualResult = sut.Left();
            var expectedResult = new Position(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
    }
}