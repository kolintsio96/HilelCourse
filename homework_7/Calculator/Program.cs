namespace Calculator
{
    //1) Доробити калькулятор - використати TryParse.
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = ReadNumber("Enter first number: ");
            double secondNumber = ReadNumber("Enter second number: ");
            Operation operation = ReadOperation();
            Calculate(firstNumber, secondNumber, operation);
        }

        private static Operation ReadOperation()
        {
            Console.Write("Enter operation 1(+), 2(-), 3(*), 4(/):");
            string input = Console.ReadLine();
            bool succesfullParsing = Enum.TryParse<Operation>(input, out Operation result);
            if (!succesfullParsing)
            {
                Console.Clear();
                Console.WriteLine("You enter wrong number");
                Console.WriteLine();
                return ReadOperation();
            }
            else if (result < Operation.Add || result > Operation.Divide)
            {
                Console.Clear();
                Console.WriteLine($"Please enter number from 1 to 4");
                Console.WriteLine();
                return ReadOperation();
            }
            return result;

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
        
        private static void Calculate(double firstNumber, double secondNumber, Operation operation)
        {
            double result = 0;
            string sign = "";
            switch (operation)
            {
                case Operation.Add:
                    result = (double)firstNumber + secondNumber;
                    sign = "+";
                    break;
                case Operation.Subtract:
                    result = (double)firstNumber - secondNumber;
                    sign = "-";    
                    break;
                case Operation.Multiply:
                    result = (double)firstNumber * secondNumber;
                    sign = "*";
                    break;
                case Operation.Divide:
                    result = (double)firstNumber / secondNumber;
                    sign = "/";
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");

        }
    }
}