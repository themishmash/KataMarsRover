using System.Collections.Generic;
using System.Data;
using kata_MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class MovementShould
    {
        [Fact]
        public void YCoordinateIncreaseByOneWhenFacingNorthAndMovingForward()
        {
            
            var sut = new Move((0,0), n);
            
            Assert.Equal((0,1),sut.Forward());
        }
        
    }
}