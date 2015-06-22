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
            _rover = new Rover { Orientation = Orientation.South };
            _roverMover = new RoverMover(_rover);
        }

        [Test]
        public void MoveRoverForwardOneUnit()
        {
            //Obviously a lot of the initial logic will change, but in true TDD style,
            //we will build from the most basic functionality up.
            //Review the kata information document in the root folder to see
            //what the goals are going to be.

            var action = new Action { Orientation = Orientation.North, UnitOfMovement = 1 };

            _roverMover.Execute(action);
            Assert.AreEqual(1, _rover.YAxis);
        }

        [Test]
        public void MoveRoverForwardTwoUnits()
        {
            var action = new Action { Orientation = Orientation.North, UnitOfMovement = 1 };

            var actions = new List<Action> {action, action};

            _roverMover.Execute(actions);
            Assert.AreEqual(2, _rover.YAxis);
        }

        [Test]
        public void MoveRoverBackwardOneUnits()
        {
            var action = new Action { Orientation = Orientation.North, UnitOfMovement = -1 };

            var actions = new List<Action> { action };

            _roverMover.Execute(actions);
            Assert.AreEqual(-1, _rover.YAxis);
        }

        [Test]
        public void MoveRoverInTheNegativeXAxisPositionBy10Units_Therefore_XAxis_WillBeNegative10()
        {
            var action = new Action { Orientation = Orientation.West, UnitOfMovement = 10 };

            var actions = new List<Action> { action };

            _roverMover.Execute(actions);
            Assert.AreEqual(-10, _rover.XAxis);
        }

        [Test]
        public void ChangingRoverOrientation_UpdatesRoverOrientation()
        {
            var action = new Action { Orientation = Orientation.South, UnitOfMovement = 5 };

            var nextAction = new Action {Orientation = Orientation.North, UnitOfMovement = 5};

            var actions = new List<Action> { action, nextAction };

            _roverMover.Execute(actions);
            Assert.AreEqual(Orientation.North, _rover.Orientation);
        }

        [Test]
        public void ChangingRoverOrientationWithoutMovement_UpdatesRoverOrientation()
        {
            var action = new Action { Orientation = Orientation.East };

            _roverMover.Execute(action);
            Assert.AreEqual(Orientation.East, _rover.Orientation);
        }
    }
}
