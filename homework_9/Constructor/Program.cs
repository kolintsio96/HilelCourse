namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = ReadNumber("Enter first side: ");
            double side2 = ReadNumber("Enter second side: ");
            Rectangle rectangle = new Rectangle(side1, side2);
        }

        private static double ReadNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = double.TryParse(input, out double result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber(message);
            }
            return result;

        }
    }
}