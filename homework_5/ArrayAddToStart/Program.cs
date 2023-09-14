namespace ArrayAddToStart
{
    //1) Потрібно додати до масиву елемент на початок.
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandomArray(10);
            PrintArray(randomArray);
            randomArray = AddToStart(randomArray);
            PrintArray(randomArray);
        }

        private static int[] AddToStart(int[] array)
        {
            Random random = new Random();

            #region FirstOption
            int[] newArray = new int[array.Length + 1];
            int randomNumber = random.Next(100);
            newArray[0] = randomNumber;
            for (int i = 1; i <= array.Length; i++) {
                newArray[i] = array[i - 1];
            }
            #endregion

            #region SecondOption
            //int[] newArray = array.Prepend(randomNumber).ToArray();
            #endregion

            return newArray;
        }

        private static int[] GetRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
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