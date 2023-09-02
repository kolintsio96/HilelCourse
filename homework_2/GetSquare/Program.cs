namespace GetSquare
{
    //2) Написати програму, яка обчислює квадрат будь-якого введеного числа.
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double square;
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            num = int.Parse(input);
            square = Math.Pow(num, 2); // num * num
            Console.WriteLine($"Square of number: {square}");
        }
    }
}