namespace Multiple
{
    //4*) Напишіть програму, яка приймає від користувача число від 1 до 100. При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
    class Program
    {
        static void Main(string[] args)
        {
            short number = ReadNumber();
            CalculateMultiple(number);
        }

        private static short ReadNumber()
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();
            bool succesfullParsing = short.TryParse(input, out short result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber();
            }else if (result < 1 || result > 100)
            {
                Console.WriteLine("Please enter number from 1 to 100");
                return ReadNumber();
            }
            return result;

        }
        private static void CalculateMultiple(short number)
        {
            if (number % 3 == 0 && number % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            } else if (number % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (number % 5 == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine("Please enter a number divisible by 3, 5 or 15");
                CalculateMultiple(ReadNumber());
            }
        }
    }
}