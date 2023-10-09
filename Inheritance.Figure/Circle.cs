namespace Inheritance.Figure
{
    internal class Circle : Figure
    {
        int radius;
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Coordinate: x = {x}, y = {y}");
            Console.WriteLine($"Radius: {radius}");
        }
    }
}
