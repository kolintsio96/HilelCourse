namespace Inheritance.Transport
{
    internal class Car : Transport
    {
        byte countDoor;
        public Car(string name, int maxSpeed, byte countDoor) : base(name, maxSpeed) { 
            this.countDoor = countDoor;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Car");
            Console.WriteLine($"Name: {name}\nMax speed: {maxSpeed}\nCount of doors: {countDoor}");
        }
    }
}
