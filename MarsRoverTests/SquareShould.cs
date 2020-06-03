using System;
using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class SquareShould
    {
        [Fact]
        public void HaveXandYCoordinate()
        {
            var square = new Location(0,0);
            Assert.Equal(0, square.XCoordinate);
            Assert.Equal(0, square.YCoordinate);
        }
        
        //todo: write test for obstacle
    }

   
}