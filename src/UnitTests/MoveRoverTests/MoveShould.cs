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
            var rover = new Rover();
            
            //Refactor this (A new rover should probably be initialized at (0,0)
            rover.XAxis = 0;
            rover.YAxis = 0;

            var roverMover = new RoverMover();
            roverMover.Move();
            Assert.AreEqual(1, rover.XAxis);
        }
    }
}
