namespace Inheritance.Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleX = ReadNumber("Enter x for circle: ");
            int circleY = ReadNumber("Enter y for circle: ");
            int circleRadius = ReadNumber("Enter radius: ");
            Circle circle = new Circle(circleX, circleY, circleRadius);
            circle.PrintInfo();

            int rectangleX = ReadNumber("Enter x for rectangle: ");
            int rectangleY = ReadNumber("Enter y for rectangle: ");
            int width = ReadNumber("Enter width: ");
            int height = ReadNumber("Enter height: ");
            Rectangle rectangle = new Rectangle(rectangleX, rectangleY, width, height);
            rectangle.PrintInfo();
        }

        private static int ReadNumber(string message)
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
                return ReadNumber(message);
            }
        }
    }
}