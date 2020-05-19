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
            var actualResult = Turn.Right(position);
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
            var actualResult = Turn.Right(position);
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
            var actualResult = Turn.Right(position);
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
            var actualResult = Turn.Right(position);
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
            var actualResult = Turn.Left(position);
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
            var actualResult = Turn.Left(position);
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
            var actualResult = Turn.Left(position);
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
            var actualResult = Turn.Left(position);
            var expectedResult = new Position(0, 0){Direction = Direction.South};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
        
    }
}