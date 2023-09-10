namespace CheckPassword
{
    //1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений. Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectPassword = ReadAndCheckPassword();
            while (!isCorrectPassword)
            {
                Console.WriteLine("Wrong password!");
                isCorrectPassword = ReadAndCheckPassword();
            }
            Console.Write("Password is correct!");
        }

        private static bool ReadAndCheckPassword()
        {
            string password = ReadPassword();
            return CheckPassword(password);
        }

        private static string ReadPassword()
        {
            Console.Write("Enter password:");
            return Console.ReadLine();

        }

        private static bool CheckPassword(string password)
        {
            return password == "root";
        }
    }
}