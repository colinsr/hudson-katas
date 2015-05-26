using MarsKata;
using MarsKata.MoveRover;
using NUnit.Framework;

namespace UnitTests.MoveRoverTests
{
    [TestFixture]
    public class MoveShould
    {
        [Test]
        public void MoveRoverForwardOneUnit()
        {
            //Obviously a lot of the initial logic will change, but in true TDD style,
            //we will build from the most basic functionality up.
            //Review the kata information document in the root folder to see
            //what the goals are going to be.
            var rover = new Rover();

            var roverMover = new RoverMover();
            roverMover.Move(rover);
            Assert.AreEqual(1, rover.XAxis);
        }
    }
}
