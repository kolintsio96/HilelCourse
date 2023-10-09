using System.Xml.Linq;

namespace Inheritance.Transport
{
    internal class Bicycle : Transport
    {
        string type = string.Empty;
        public Bicycle(string name, int maxSpeed, string type) : base(name, maxSpeed) {
             this.type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Bicycle");
            Console.WriteLine($"Name: {name}\nMax speed: {maxSpeed}\nType of bicycle: {type}");
        }
    }
}
