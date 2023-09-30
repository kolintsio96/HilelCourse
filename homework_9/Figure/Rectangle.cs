namespace Figure
{
    internal class Rectangle
    {
        double side1, side2;

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }
        
        public Rectangle(double side1): this(side1, side1)
        {
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        
        public void PrintResult()
        {
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
