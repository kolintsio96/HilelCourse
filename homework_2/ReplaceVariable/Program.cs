namespace ReplaceVariables
{
    //5*) Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //1
            (a, b) = (b, a);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //2      
            a = (byte)(a * b);
            b = (byte)(a / b);
            a = (byte)(a / b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //3      
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}