using System.Drawing;

namespace Interface.Movable
{
    internal class Vehicle : IMovable
    {
        public Point Position { get; set; } = new Point();

        public void Move(int x, int y)
        {
            Position = new Point(x, y);
        }
    }
}
