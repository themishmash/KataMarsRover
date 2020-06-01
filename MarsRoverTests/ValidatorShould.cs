using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class ValidatorShould
    {
        [Fact]
        public void DetermineIfCoordinatesAreValidNumbers()
        {
            Assert.False(Validator.AreNumbersValid("A, 2"));
            Assert.True(Validator.AreNumbersValid("1, 2"));
        }
        
        [Fact]
        public void DetermineIfCoordinatesAreWithinGridBoundary()
        {
            var grid = new Grid(3, 3);
            
            Assert.False(Validator.AreCoordinatesValid(new int[] {5, 7}, grid ));
            Assert.True(Validator.AreCoordinatesValid(new int[] {2, 2}, grid));
        }

        [Fact]
        public void DetermineIfDirectionIsValid()
        {
            Assert.True(Validator.IsDirectionValid("w"));
            Assert.False(Validator.IsDirectionValid("H"));
        }
        
    }
}