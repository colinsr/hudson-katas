using MarsKata;
using MarsKata.MoveRover;
using NUnit.Framework;

namespace UnitTests.MoveRoverTests
{
    [TestFixture]
    public class MoveShould
    {
        private Rover _rover;
        private RoverMover _roverMover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover();
            _roverMover = new RoverMover();
        }

        [Test]
        public void MoveRoverForwardOneUnit()
        {
            //Obviously a lot of the initial logic will change, but in true TDD style,
            //we will build from the most basic functionality up.
            //Review the kata information document in the root folder to see
            //what the goals are going to be.
            _roverMover.Move(_rover);
            Assert.AreEqual(1, _rover.XAxis);
        }

        [Test]
        public void MoveRoverForwardTwoUnits()
        {
            _roverMover.Move(_rover, 2);
            Assert.AreEqual(2, _rover.XAxis);
        }
    }
}
