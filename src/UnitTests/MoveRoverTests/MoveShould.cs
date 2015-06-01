using System.Collections.Generic;
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
            _roverMover = new RoverMover(_rover);
        }

        [Test]
        public void MoveRoverForwardOneUnit()
        {
            //Obviously a lot of the initial logic will change, but in true TDD style,
            //we will build from the most basic functionality up.
            //Review the kata information document in the root folder to see
            //what the goals are going to be.

            var direction = new Direction {XAxis = 1};
            var action = new Action { Direction = direction, UnitOfMovement = 1 };

            _roverMover.Execute(action);
            Assert.AreEqual(1, _rover.XAxis);
        }

        [Test]
        public void MoveRoverForwardTwoUnits()
        {
            var direction = new Direction { XAxis = 1 };
            var action = new Action { Direction = direction, UnitOfMovement = 1 };

            var actions = new List<Action> {action, action};

            _roverMover.Execute(actions);
            Assert.AreEqual(2, _rover.XAxis);
        }

        [Test]
        public void MoveRoverBackwardOneUnits()
        {
            var direction = new Direction { XAxis = -1 };
            var action = new Action { Direction = direction, UnitOfMovement = 1 };

            var actions = new List<Action> { action };

            _roverMover.Execute(actions);
            Assert.AreEqual(-1, _rover.XAxis);
        }

        [Test]
        public void MoveRoverInTheNegativeXAxisPositionBy10Units_Therefore_XAxis_WillBeNegative10()
        {
            var direction = new Direction { XAxis = -1 };
            var action = new Action { Direction = direction, UnitOfMovement = 1 };

            var actions = new List<Action> { action };

            _roverMover.Execute(actions);
            Assert.AreEqual(-10, _rover.XAxis);
        }
    }
}
