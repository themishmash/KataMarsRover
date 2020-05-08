using System;
using Xunit;

namespace MarsRoverTests
{
    public class SquareShould
    {
        [Fact]
        public void HaveXandYCoordinate()
        {
            var square = new Position(0,0);
            Assert.Equal(0, square.XCoordinate);
            Assert.Equal(0, square.YCoordinate);
        }
    }

   
}