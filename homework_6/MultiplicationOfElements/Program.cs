namespace MultiplicationOfElements
{
    //2) Знайти добуток елементів масиву, які більші за задане число.
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandomArray(5);
            PrintArray(randomArray);
            int number = ReadNumber();
            int product = CalculateMultiplicationOfElements(randomArray, number);
            Console.WriteLine(product);
        }

        private static int CalculateMultiplicationOfElements(int[] randomArray, int number)
        {
            int product = 1;

            foreach (int element in randomArray) { 
                if (element > number)
                {
                    product *= element;
                }
            }

            return product;
        }

        private static int[] GetRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(10);
            }
            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

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