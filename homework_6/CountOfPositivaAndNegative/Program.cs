namespace CountOfPositivaAndNegative
{
    //3) Задано квадратну матрицю цілих чисел. Підрахуйте кількість негативних та позитивних елементів.
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            int[,] randomArray = new int[n, m];
            randomArray = GetRandomArray(n, m);
            PrintArray(randomArray);
            CalculateCountOfPositiveAndNegative(randomArray);
        }

        private static void CalculateCountOfPositiveAndNegative(int[,] array)
        {
            int positive = 0;
            int negative = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (array[i,j] < 0)
                    {
                        negative++;
                    } else
                    {
                        positive++;
                    }
                }
            }
            Console.WriteLine($"Count of positive: {positive}");
            Console.WriteLine($"Count of negative: {negative}");
        }

        private static int[,] GetRandomArray(int horizontalSize, int verticalSize)
        {
            Random random = new Random();
            int[,] array = new int[horizontalSize, verticalSize];
            for (int i = 0; i < horizontalSize; i++)
            {
                for (int j = 0; j < verticalSize; j++)
                {
                    array[i, j] = random.Next(-10, 11);
                }
            }
            return array;
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}