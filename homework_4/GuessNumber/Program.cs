namespace GuessNumber
{
    //2) Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його. У разі неправильної відповіді програма підказує «більше» або «менше»
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = GetRandom();
            ReadAndGuess(randomNumber);
        }

        private static void ReadAndGuess(int randomNumber)
        {
            int number = ReadNumber();
            while (randomNumber != number)
            {
                string consoleText = number > randomNumber ? "Enter lower number" : "Enter larger number";
                Console.WriteLine(consoleText);
                number = ReadNumber();
            };
            Console.WriteLine("Victory!");
        }

        private static int GetRandom()
        {
            Random random = new Random();
            return random.Next(1, 147);

        }

        private static int ReadNumber()
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber();
            }
            return result;

        }
    }
}