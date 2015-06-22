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
                Rover.YAxis = Rover.YAxis + unitOfMovement;
            }
            else if (orientation == Orientation.South)
            {
                Rover.YAxis = Rover.YAxis - unitOfMovement;
            }
            else if (orientation == Orientation.West)
            {
                Rover.XAxis = Rover.XAxis - unitOfMovement;
            }
            else
            {
                Rover.XAxis = Rover.XAxis + unitOfMovement;
            }
        }
    }
}
