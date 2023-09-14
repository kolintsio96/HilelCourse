using System;

namespace ArrayComparison
{
    //5*) Вказано п'ять довільних цілих чисел (елементи масиву). Визначити, чи є їхнє розташування в масиві впорядкованим (тобто за зростанням або за спаданням) чи невпорядкованим.
    class Program
    {
        static void Main(string[] args)
        {
            int[] orderedArray = { 1, 12, 33, 45, 65 };
            int[] unorderedArray = { 15, 7, 98, 75, 38 };
            PrintArray(orderedArray);
            ArrayComparison(orderedArray);
            PrintArray(unorderedArray);
            ArrayComparison(unorderedArray);
        }

        private static void ArrayComparison(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1;  j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Console.WriteLine("Array is unordered");
                        return;
                    }
                }
            }
            Console.WriteLine("Array is ordered");
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