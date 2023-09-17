namespace SumOfElements
{
    //1) Знайти суму елементів масиву, які розміщуються на парних індексах
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandomArray(10);
            PrintArray(randomArray);
            int sum = CalculateSumOfElemtns(randomArray);
            Console.WriteLine(sum);
        }

        private static int CalculateSumOfElemtns(int[] randomArray)
        {
            int sum = 0;
            for (int i = 0; i < randomArray.Length; i++) { 
                if (i % 2 == 0)
                {
                    sum += randomArray[i]; 
                }
            }
            return sum;    
        }

        private static int[] GetRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100);
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
    }
}