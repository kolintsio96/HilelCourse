
namespace Address
{
    //Створити клас із ім'ям Address
    class Program
    {
        static void Main(string[] args)
        {
            string index = ReadConsole("Enter index: ");
            string country = ReadConsole("Enter country: ");
            string city = ReadConsole("Enter city: ");
            string street = ReadConsole("Enter street: ");
            int house = ReadConsole("Enter house: ", true);
            int apartment = ReadConsole("Enter apartment: ", true);
            Address address = new Address() { Index= index, Country= country, City= city, Street= street, House= house, Apartment= apartment };
            Console.WriteLine(address.GetAddress());
        }

        private static int ReadConsole(string message, bool isNumber)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadConsole(message, isNumber);
            }
            return result;

        }

        private static string ReadConsole(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Field can not be null or empty");
                return ReadConsole(message);
            }
            return input;

        }
    }
}