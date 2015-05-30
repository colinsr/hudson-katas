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
            Move(action.Direction);
        }

        private void Move(Direction direction)
        {
            if (direction.XAxis != 0)
            {
                Rover.XAxis = Rover.XAxis + direction.XAxis;
            }

            if (direction.YAxis != 0)
            {
                Rover.YAxis = Rover.YAxis + direction.YAxis;
            }
        }
    }
}
