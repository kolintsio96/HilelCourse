namespace RemoveElementFromArray
{
    //4) Написати програму, в якій з масиву видаляється один елемент з позиції, яку вводить користувач. 
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandomArray(10);
            PrintArray(randomArray);
            int position = ReadNumber();
            int[] newArray = RemoveFromArray(randomArray, position);
            PrintArray(newArray);
        }

        private static int[] RemoveFromArray(int[] array, int position)
        {
            int[] newArray = new int[array.Length - 1];
            #region FirstOption
            for (int i = 0; i < array.Length; i++)
            {
                if (i < position)
                {
                    newArray[i] = array[i];
                }
                else if (i > position)
                {
                    newArray[i - 1] = array[i];
                }

            }
            #endregion

            #region SecondOption
            //newArray = array.Where((val, idx) => idx != position).ToArray();
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

        private static int ReadNumber()
        {
            Console.Write("Enter position:");
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