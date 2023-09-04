namespace ChangedNumber
{
    //3) Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
    class Program
    {
        static void Main(string[] args)
        {
            // 1)
            char temp;
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            char[] char_array = input.ToCharArray();
            temp = char_array[0];
            char_array[0] = char_array[1];
            char_array[1] = temp;
            int num = int.Parse(new string(char_array.ToArray()));
            Console.WriteLine($"Changed number: {num}");

            // 2)
            Console.Write("Enter number: ");
            string input2 = Console.ReadLine();
            int[] numbers = input2.Select(o => Convert.ToInt32(o) - 48).ToArray();
            numbers[0] = numbers[0] + numbers[1];
            numbers[1] = numbers[0] - numbers[1];
            numbers[0] = numbers[0] - numbers[1];
            string[] result = numbers.Select(i => i.ToString()).ToArray();
            Console.WriteLine($"Changed number: {String.Join("", result)}");
        }
    }
}