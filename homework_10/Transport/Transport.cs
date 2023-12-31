﻿namespace Inheritance.Transport
{
    internal class Transport
    {
        internal string name = string.Empty;
        internal int maxSpeed;

        public Transport(string name, int maxSpeed) { 
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {name}\nMax speed: {maxSpeed}");
        }
    }
}
