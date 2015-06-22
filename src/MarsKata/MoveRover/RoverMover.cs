using System.Collections.Generic;

namespace MarsKata.MoveRover
{
    public class RoverMover
    {
        private Rover Rover { get; set; }

        public RoverMover(Rover rover)
        {
            Rover = rover;
        }

        public void Execute(IEnumerable<Action> actions)
        {
            foreach (var action in actions)
            {
                Execute(action);
            }
        }

        public void Execute(Action action)
        {
            Move(action.Orientation, action.UnitOfMovement);
        }

        private void Move(Orientation orientation, int unitOfMovement)
        {
            Rover.Orientation = orientation;
            if (orientation == Orientation.North)
            {
                GoNorth(unitOfMovement);
            }
            else if (orientation == Orientation.South)
            {
                GoSouth(unitOfMovement);
            }
            else if (orientation == Orientation.East)
            {
                GoEast(unitOfMovement);
            }
            else if (orientation == Orientation.West)
            {
                GoWest(unitOfMovement);
            }
        }

        private void GoNorth(int unitOfMovement)
        {
            Rover.YAxis = Rover.YAxis + unitOfMovement;
        }

        private void GoSouth(int unitOfMovement)
        {
            Rover.YAxis = Rover.YAxis - unitOfMovement;
        }

        private void GoEast(int unitOfMovement)
        {
            Rover.XAxis = Rover.XAxis + unitOfMovement;
        }

        private void GoWest(int unitOfMovement)
        {
            Rover.XAxis = Rover.XAxis - unitOfMovement;
        }
    }
}
