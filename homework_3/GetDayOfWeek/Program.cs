namespace DayOfWeek
{
    //3) Написати програму, яка виводить назву дня неділі за його номером (1 - понеділок, 7 - неділя). 
    class Program
    {
        static void Main(string[] args)
        {
            byte dayOfWeek = ReadNumber();
            GetDayOfWeek(dayOfWeek);
        }

        private static byte ReadNumber()
        {
            Console.Write("Enter number day of week:");
            string input = Console.ReadLine();
            bool succesfullParsing = byte.TryParse(input, out byte result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber();
            }
            else if (result < 1 || result > 7)
            {
                Console.WriteLine("Please enter number from 1 to 7");
                return ReadNumber();
            }
            return result;

        }
        private static void GetDayOfWeek(byte number)
        {
            switch (number) { 
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}