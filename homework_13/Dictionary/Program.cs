namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory directory = new PhoneDirectory();
            while (true)
            {
                Console.Clear();
                Operations input = ReadOperation();

                switch (input)
                {
                    case Operations.Add:
                        int key = ReadInput("Enter phone: ", true);
                        string value = ReadInput("Enter name: ");
                        directory.Add(key, value);
                        Console.ReadLine();
                        break;
                    case Operations.RemoveByName:
                        string nameForRemove = ReadInput("Enter name: ");
                        directory.RemoveByName(nameForRemove);
                        Console.ReadLine();
                        break;
                    case Operations.GetPhoneByName:
                        string name = ReadInput("Enter name: ");
                        try
                        {
                            int phone = directory.GetPhoneByName(name);
                            Console.WriteLine(phone);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadLine();
                        break;
                    case Operations.GetAllPhones:
                        directory.GetAllPhones();
                        Console.ReadLine();
                        break;
                    case Operations.Exit:
                        Console.WriteLine("Exiting program");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
        }

        private static Operations ReadOperation()
        {
            Console.Write("""
                    1. Add to dictionary
                    2. Remove by name
                    3. Get phone by name
                    4. Get all phones
                    Choose an option:
                    """);
            string input = Console.ReadLine();
            bool succesfullParsing = Enum.TryParse<Operations>(input, out Operations result);
            if (!succesfullParsing)
            {
                Console.Clear();
                Console.WriteLine("You enter wrong number");
                Console.WriteLine();
                return ReadOperation();
            }
            else if (result < Operations.Add || result > Operations.Exit)
            {
                Console.Clear();
                Console.WriteLine($"Please enter number from 1 to 4");
                Console.WriteLine();
                return ReadOperation();
            }
            return result;

        }

        private static int ReadInput(string message, bool isNumber)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
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
                return ReadInput(message, isNumber);
            }

        }
        private static string ReadInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            try
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Field can not be empty");
                    return ReadInput(message);
                }
                return input;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ReadInput(message);
            }

        }
    }
}