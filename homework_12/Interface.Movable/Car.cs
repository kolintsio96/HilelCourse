namespace Interface.Movable
{
    internal class Car : Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }
}
