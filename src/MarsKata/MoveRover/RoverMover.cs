using System;

namespace MarsKata.MoveRover
{
    public class RoverMover
    {
        public void Move(Rover rover)
        {
            rover.XAxis++;
        }

        public void Move(Rover rover, int spacesToMove)
        {
            for (int moveCounter = 0; moveCounter < spacesToMove; moveCounter++)
            {
                rover.XAxis++;
            }
        }
    }
}
