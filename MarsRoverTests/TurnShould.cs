using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class TurnShould
    {
        [Fact]
        [Trait("Category", "TurnRight-North")]
        public void ChangeDirectionToEastIfFacingNorthAndTurningRight()
        {
            var sut = new Turn(new Position(0,0 ){Direction = Direction.North});
            var actualResult = sut.Right();
            var expectedResult = new Position(0, 0){Direction = Direction.East};
            Assert.Equal(expectedResult.XCoordinate, actualResult.XCoordinate);
            Assert.Equal(expectedResult.YCoordinate, actualResult.YCoordinate);
            Assert.Equal(expectedResult.Direction, actualResult.Direction);
        }
    }
}