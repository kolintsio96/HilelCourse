namespace Inheritance.Figure
{
    internal class Rectangle : Figure
    {
        int width, height;
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Coordinate: x = {x}, y = {y}");
            Console.WriteLine($"Width: {width}, height: {height}");
        }
    }
}
