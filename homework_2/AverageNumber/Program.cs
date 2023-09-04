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
            double firstNumber = double.Parse(firstInput);

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = double.Parse(secondInput);

            double averageNumber = (firstNumber + secondNumber) / 2;
            Console.WriteLine($"Average number: {averageNumber}");
        }
    }
}