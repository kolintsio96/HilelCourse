namespace Inheritance.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = ReadInput("Enter car name: ");
            int carMaxSpeed= ReadInput("Enter car max speed: ", true, 300);
            int countOfDoors = ReadInput("Enter count of doors: ", true, 5);
            Transport car = new Car(carName, carMaxSpeed, (byte)countOfDoors);
            car.PrintInfo();

            string bicycleName = ReadInput("Enter bicycle name: ");
            int bicycleMaxSpeed = ReadInput("Enter bicycle max speed: ", true, 50);
            string type = ReadInput("Enter type of bicycle: ");
            Bicycle bicycle = new Bicycle(bicycleName, bicycleMaxSpeed, type);
            bicycle.PrintInfo();
        }

        private static int ReadInput(string message, bool isNumber, int max)
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
                else if (result > max)
                {
                    throw new Exception($"You enter number more then max. Max: {max}");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ReadInput(message, isNumber, max);
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