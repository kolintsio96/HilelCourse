namespace EvenOddNumbers
{
    //1) Написати програму, яка перевіряє введене число на парність/непарність. 
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber();
            CheckingEvenOddNumbers(number);
        }

        private static int ReadNumber()
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing) {
                Console.WriteLine("You enter wrong number");
                return ReadNumber();
            } else if(result == 0)
            {
                Console.WriteLine("Please enter number not equal 0");
                return ReadNumber();
            }
            return result;

        }
        private static void CheckingEvenOddNumbers(int number)
        {
            if (number % 2 == 0) {
                Console.WriteLine("You enter even number");    
            } else
            {
                Console.WriteLine("You enter odd number");    
            }
        }
    }
}