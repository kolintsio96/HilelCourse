namespace ComparingNumbers
{
    //2) Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа. Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = ReadNumber("Enter first number:");
            int secondNumber = ReadNumber("Enter second number:");
            ComparingNumbers(firstNumber, secondNumber);
        }

        private static int ReadNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber(message);
            }

            return result;

        }
        private static void ComparingNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"Numbers are equal {firstNumber} = {secondNumber}");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine($"First number is larger {firstNumber}");
            } else
            {
                Console.WriteLine($"Secong number is larger {secondNumber}");
            }
        }
    }
}