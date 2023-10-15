namespace MathUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = ReadInput("First argument for addition: ");
            double b = ReadInput("Second argument for addition: ");

            Console.WriteLine($"{a} + {b} = {MathUtility.Addition(a, b)}");

            a = ReadInput("First argument for subtraction: ");
            b = ReadInput("Second argument for subtraction: ");
            Console.WriteLine($"{a} - {b} = {MathUtility.Subtraction(a, b)}");

            a = ReadInput("First argument for division: ");
            b = ReadInput("Second argument for division: ");
            Console.WriteLine($"{a} / {b} = {MathUtility.Division(a, b)}");

            a = ReadInput("First argument for multiplication: ");
            b = ReadInput("Second argument for multiplication: ");
            Console.WriteLine($"{a} * {b} = {MathUtility.Multiplication(a, b)}");
        }

        private static double ReadInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = double.TryParse(input, out double result);
            try
            {
                if (!succesfullParsing)
                {
                    throw new Exception("You enter wrong number");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ReadInput(message);
            }

        }
    }
}