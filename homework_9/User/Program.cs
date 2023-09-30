namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = ReadInput("Enter login: ");
            string name = ReadInput("Enter name: ");
            string lastName = ReadInput("Enter lastName: ");
            int age = ReadInput("Enter age: ", true);
            User user = new User(login, name, lastName, age);
            user.PrintUserInfo();
        }

        private static int ReadInput(string message, bool isNumber)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadInput(message, isNumber);
            } else if (result <= 0)
            {
                Console.WriteLine("Please enter number more then 0");
                return ReadInput(message, isNumber);
            }
            return result;

        }
        private static string ReadInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Field can not be empty");
                return ReadInput(message);
            }
            return input;

        }
    }
}