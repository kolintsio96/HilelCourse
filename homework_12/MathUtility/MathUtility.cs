namespace MathUtility
{
    internal class MathUtility
    {
        public static double Addition(double a, double b) {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static double Division(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new Exception("Division by zero");
                }
                return a / b;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
