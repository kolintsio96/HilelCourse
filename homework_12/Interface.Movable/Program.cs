namespace Interface.Movable
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move(10, 45);
            Console.WriteLine($"Car started from X:{car.Position.X}, Y:{car.Position.Y}");
            car.StartEngine();
            car.Move(100, 450);
            car.StopEngine();
            Console.WriteLine($"Car arrived to X:{car.Position.X}, Y:{car.Position.Y}");
        }
    }
}