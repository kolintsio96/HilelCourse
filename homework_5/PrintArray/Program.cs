namespace PrintArray
{
    //2) Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 12, -1, 32 };
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                if (i == -1) return;
                Console.Write(i + "  ");
            }

        }
    }
}