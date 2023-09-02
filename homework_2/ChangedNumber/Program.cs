namespace ChangedNumber
{
    //3) Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
    class Program
    {
        static void Main(string[] args)
        {
            char temp;
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            char[] char_array = input.ToCharArray();
            temp = char_array[0];
            char_array[0] = char_array[1];
            char_array[1] = temp;
            int num = int.Parse(new string(char_array.ToArray()));
            Console.WriteLine($"Changed number: {num}");
        }
    }
}