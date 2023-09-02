using System;

namespace AvarageNumber
{
    //4) Написати програму, яка обчислює середнє арифметичне двох чисел.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            double averageNumber = (firstNumber + secondNumber) / 2;
            Console.WriteLine($"Average number: {averageNumber}");
        }
    }
}