namespace StudentEvaluations
{
    //5) Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку. Використовуйте масиви для зберігання оцінок.
    class Program
    {
        static void Main(string[] args)
        {
            int[] mathGrades = GetRandomGrades(ReadNumber("math"));
            int[] physicsGrades = GetRandomGrades(ReadNumber("physics"));
            int[] chemistryGrades = GetRandomGrades(ReadNumber("chemistry"));
            OpenMainMenu(mathGrades, physicsGrades, chemistryGrades);
        }

        private static void OpenMainMenu(int[] mathGrades, int[] physicsGrades, int[] chemistryGrades)
        {
            while (true)
            {
                Console.Clear();
                Operations input = ReadOperation();

                switch (input)
                {
                    case Operations.Enter:
                        OpenSubmenu(Operations.Enter, mathGrades, physicsGrades, chemistryGrades);
                        break;
                    case Operations.Avarage:
                        OpenSubmenu(Operations.Avarage, mathGrades, physicsGrades, chemistryGrades);
                        Console.ReadLine();
                        break;
                    case Operations.Print:
                        OpenSubmenu(Operations.Print, mathGrades, physicsGrades, chemistryGrades);
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
        private static void OpenSubmenu(Operations operations, int[] mathGrades, int[] physicsGrades, int[] chemistryGrades)
        {
            while (true)
            {
                Console.Clear();
                switch (operations)
                {
                    case Operations.Enter:
                        Console.WriteLine("Enter a grade:");
                        Console.WriteLine();
                        break;
                    case Operations.Avarage:
                        Console.WriteLine("Get an average score:");
                        Console.WriteLine();
                        break;
                    case Operations.Print:
                        Console.WriteLine("Print grades:");
                        Console.WriteLine();
                        break;
                }
                Subjects input = ReadSubject();

                switch (input)
                {
                    case Subjects.Math:
                        switch (operations)
                        {
                            case Operations.Enter:
                                mathGrades = ReadAndAddGrade("Math", mathGrades);
                                break;
                            case Operations.Avarage:
                                CalculateAvarage("math", mathGrades);
                                break;
                            case Operations.Print:
                                PrintGrade("Math", mathGrades);
                                break;
                        }
                        break;
                    case Subjects.Physics:
                        switch (operations)
                        {
                            case Operations.Enter:
                                physicsGrades = ReadAndAddGrade("Physics", physicsGrades);
                                break;
                            case Operations.Avarage:
                                CalculateAvarage("physics", physicsGrades);
                                break;
                            case Operations.Print:
                                PrintGrade("Physics", physicsGrades);
                                break;
                        }
                        break;
                    case Subjects.Chemistry:
                        switch (operations)
                        {
                            case Operations.Enter:
                                chemistryGrades = ReadAndAddGrade("Chemistry", chemistryGrades);
                                break;
                            case Operations.Avarage:
                                CalculateAvarage("chemistry", chemistryGrades);
                                break;
                            case Operations.Print:
                                PrintGrade("Chemistry", chemistryGrades);
                                break;
                        }
                        break;
                    case Subjects.Exit:
                        OpenMainMenu(mathGrades, physicsGrades, chemistryGrades);
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
            Console.ReadLine();
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
            Console.ReadLine();
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

        private static Operations ReadOperation()
        {
            Console.Write("""
                    1. Enter a grade 
                    2. Get an average score
                    3. Print grades
                    4. Exit
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
            else if (result < Operations.Enter || result > Operations.Exit)
            {
                Console.Clear();
                Console.WriteLine($"Please enter number from 1 to 4");
                Console.WriteLine();
                return ReadOperation();
            }
            return result;

        }

        private static Subjects ReadSubject()
        {
            Console.Write("""
                    1. Math 
                    2. Physics
                    3. Chemistry
                    4. Exit
                    Choose an option:
                    """);
            string input = Console.ReadLine();
            bool succesfullParsing = Enum.TryParse<Subjects>(input, out Subjects result);
            if (!succesfullParsing)
            {
                Console.Clear();
                Console.WriteLine("You enter wrong number");
                Console.WriteLine();
                return ReadSubject();
            }
            else if (result < Subjects.Math || result > Subjects.Exit)
            {
                Console.Clear();
                Console.WriteLine($"Please enter number from 1 to 4");
                Console.WriteLine();
                return ReadSubject();
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

        private static int ReadNumber(string subject)
        {
            Console.Write($"Enter count of random grades for {subject}: ");
            string input = Console.ReadLine();
            bool succesfullParsing = int.TryParse(input, out int result);
            if (!succesfullParsing)
            {
                Console.WriteLine("You enter wrong number");
                return ReadNumber(subject);
            }
            return result;

        }
    }
}