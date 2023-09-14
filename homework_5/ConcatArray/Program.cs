using System;

namespace ConcatArray
{
    //3) Написати програму створення масиву із двох масивів. У підсумковому масиві мають бути елементи першого та другого масиву.
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRandomArray = GetRandomArray(10);
            int[] secondRandomArray = GetRandomArray(5);
            int[] concatArray = ConcatArray(firstRandomArray, secondRandomArray);
            PrintArray(firstRandomArray);
            PrintArray(secondRandomArray);
            PrintArray(concatArray);
        }

        private static int[] ConcatArray(int[] firstArray, int[] secondArray)
        {
            int[] newArray = new int[firstArray.Length + secondArray.Length];

            #region FirstOption
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < firstArray.Length)
                {
                    newArray[i] = firstArray[i];
                }
                else
                {
                    newArray[i] = secondArray[i - firstArray.Length];
                }
            }
            #endregion

            #region SecondOption
            //newArray = firstArray.Concat(secondArray).ToArray();
            #endregion

            return newArray;
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