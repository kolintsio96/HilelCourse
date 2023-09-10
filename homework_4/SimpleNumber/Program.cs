namespace SimpleNumber
{
    //4) Перевірка чи є введене натуральне число простим
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = GetRandom();
            bool isSimpleNumber = CheckNumber(randomNumber);
            Console.WriteLine(isSimpleNumber ? "Simple" : "Not simple");  
        }

        private static bool CheckNumber(int randomNumber)
        {
            for (int i = 2; i < Math.Sqrt(randomNumber) + 1; i++)
            {
                if (randomNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetRandom()
        {
            Random random = new Random();
            return random.Next(2, 1000);

        }
    }
}