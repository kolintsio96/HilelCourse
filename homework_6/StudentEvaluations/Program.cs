namespace StudentEvaluations
{
    //5) Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку. Використовуйте масиви для зберігання оцінок.
    class Program
    {
        static void Main(string[] args)
        {
            int[] mathGrades = GetRandomGrades(7);
            int[] physicsGrades = GetRandomGrades(5);
            int[] chemistryGrades = GetRandomGrades(10);
            while (true)
            {
                Console.Write("""
                    1. Enter a math grade 
                    2. Enter a physics grade
                    3. Enter a chemistry grade
                    4. Get an average score
                    5. Show all of grades
                    6. Exit
                    Choose an option:
                    """);
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        mathGrades = ReadAndAddGrade("Math", mathGrades);
                        break;
                    case "2":
                        physicsGrades = ReadAndAddGrade("Physics", physicsGrades);
                        break;
                    case "3":
                        chemistryGrades = ReadAndAddGrade("Chemistry", chemistryGrades);
                        break;
                    case "4":
                        CalculateAvarage("math", mathGrades);
                        CalculateAvarage("physics", physicsGrades);
                        CalculateAvarage("chemistry", chemistryGrades);
                        Console.ReadLine();
                        break;
                    case "5":
                        PrintGrade("Math", mathGrades);
                        PrintGrade("Physics", physicsGrades);
                        PrintGrade("Chemistry", chemistryGrades);
                        Console.ReadLine();
                        break;
                    case "6":
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

        private static void CalculateAvarage(string subject, int[] grades)
        {
            float avarage = (float)grades.Sum() / grades.Length;
            Console.WriteLine($"Average grade in {subject}: {Math.Round(avarage, 2)}");
        }

        private static int[] ReadAndAddGrade(string subject, int[] grades)
        {
            int grage = ReadGrade(subject);
            grades = grades.Append(grage).ToArray();
            return grades;
        }
        private static void PrintGrade(string subject, int[] grades)
        {
            Console.Write($"{subject} grades: ");
            PrintArray(grades);
        }

        private static int[] GetRandomGrades(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 13);
            }
            return array;
        }

        private static int ReadGrade(string subject)
        {
            Console.Write($"{subject} grade: ");
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadGrade(subject);
            }
            else if (result < 1 || result > 12)
            {
                Console.WriteLine("Please enter grade from 1 to 12");
                return ReadGrade(subject);
            }
            return result;

        }

        private static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

        }
    }
}