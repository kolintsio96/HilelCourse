namespace NameOfSeason
{
    //4) Написати програму, в якій користувач вводить номер місяця.  Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь». У будь-якому іншому випадку - "Немає такого місяця на цій планеті".
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfMonth = ReadNumber();
            GetNameOfSeason(numberOfMonth);
        }

        private static byte ReadNumber()
        {
            Console.Write("Enter number of month:");
            string input = Console.ReadLine();
            bool succesfullParsing = byte.TryParse(input, out byte result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber();
            }
            return result;

        }
        private static void GetNameOfSeason(byte number)
        {
            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Such a month does not exist");
                    break;
            }
        }
    }
}