using MarsKata.MoveRover;

namespace MarsKata
{
    public class Rover
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public Orientation Orientation { get; set; }

        public Rover()
        {
            XAxis = 0;
            YAxis = 0;
        }
    }
}
