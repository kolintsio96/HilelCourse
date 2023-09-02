namespace RevertNumber
{
    //1) Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int revert_number = 0;
            Console.Write("Enter distance: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            while (num > 0)
            {
                revert_number = revert_number * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine($"Reverted number: {revert_number}");
        }
    }
}