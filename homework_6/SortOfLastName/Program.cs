using System;
using System.Drawing;

namespace SortOfLastName
{
    //4) Відсортуйте введений список прізвищ за алфавітом та виведіть його на екран.
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Console.WriteLine($"Please enter {size} last names!");
            string[] arrayOfLastNames = new string[size];
            arrayOfLastNames = FillArray(size);            
            string[] sortedArray = SortArray(arrayOfLastNames);
            PrintArray(arrayOfLastNames);
            PrintArray(sortedArray);
        }

        private static string[] SortArray(string[] array)
        {
            string[] newArray = (string[])array.Clone();
            Array.Sort(newArray);
            return newArray;
        }

        private static string[] FillArray(int size)
        {
            string[] newArray = new string[size];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ReadLastName(i + 1);
            }

            return newArray;
        }

        private static void PrintArray(string[] array)
        {
            foreach (string i in array)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

        }

        private static string ReadLastName(int index)
        {
            Console.Write($"{index} last name: ");
           return Console.ReadLine(); ;

        }
    }
}