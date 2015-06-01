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
            Move(action.Direction, action.UnitOfMovement);
        }

        private void Move(Direction direction, int unitOfMovement)
        {
            if (direction == null)
            {
                return;
            }

            if (direction.XAxis == 1)
            {
                Rover.XAxis = Rover.XAxis + unitOfMovement;
            }
            else if (direction.XAxis == -1)
            {
                Rover.XAxis = Rover.XAxis - unitOfMovement;
            }

            if (direction.YAxis != 0)
            {
                Rover.YAxis = Rover.YAxis + direction.YAxis;
            }
        }
    }
}
