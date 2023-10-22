using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //1) Фільтрація: Дано список цілих чисел: {2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.
            int[] nums = { 2, 5, 8, 12, 15, 18, 22 };
            nums = nums.Where(num => num > 10).ToArray();
            Console.WriteLine(string.Join(", ", nums));

            //2) Сортування: Дано список імен фруктів: {"Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.
            string[] fruits = { "Яблуко", "Апельсин", "Банан", "Ківі" };
            fruits = fruits.OrderBy(f => f).ToArray();
            Console.WriteLine(string.Join(", ", fruits));

            //3) Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
            string[] cahrs = { "А", "Б", "В", "А", "Г", "В" };
            cahrs = cahrs.Distinct().ToArray();
            Console.WriteLine(string.Join(", ", cahrs));

            //4) Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
            int[] rates = { 85, 92, 78, 95, 88, 90 };
            rates = rates.Where(rate => rate > 90).ToArray();
            Console.WriteLine(rates.Length);

            //5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
            List<Product> products = new List<Product>();
            products.Add(new Product("Pineapple", 128));
            products.Add(new Product("Banana", 57));
            products.Add(new Product("Potato", 35));
            products.Add(new Product("Tomato", 75));
            products.Add(new Product("Onion", 48));
            products.Add(new Product("Apple", 65));
            var sortedProducts = products.Where(product => product.Price > 50).ToList();
            sortedProducts.Sort((productA, productB) => productA.Price - productB.Price);
            foreach (Product item in sortedProducts)
            {
                Console.WriteLine(item);
            }

            //6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
            int[] numbers = { 10, 25, 8, 45, 15, 30, 55, 5 };
            Console.WriteLine(Array.IndexOf(numbers, numbers.Max()));
            Console.WriteLine();


            //*** 7) Завдання: У вас є список студентів з такими властивостями: Ім'я (Name), Оцінка (Grade) та Курс (Course). Вам потрібно вирішити наступні завдання, використовуючи LINQ:
            List<Student> students = new List<Student>();
            students.Add(new Student("Ann", 85, "C# Basic"));
            students.Add(new Student("Volodymyr", 91, "C# Basic"));
            students.Add(new Student("Ivan", 95, "C# Pro"));
            students.Add(new Student("Olya", 70, "C# Basic"));
            students.Add(new Student("Igor", 90, "C# Pro"));
            students.Add(new Student("Natalia", 89, "C# Pro"));
            students.Add(new Student("Oleg", 84, "C# Basic"));
            students.Add(new Student("Andrii", 97, "C# Pro"));
            students.Add(new Student("Veronika", 80, "C# Basic"));

            Console.WriteLine("Студенти, які мають оцінку більше або рівну 90.");
            var filteredStudens = students.Where(student => student.Grade >= 90);
            foreach (Student item in filteredStudens)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Сортування студентів за оцінкою в спадаючому порядку");
            students.Sort((studentA, studentB) => studentB.Grade - studentA.Grade);
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.");
            var groupedStudents = students.GroupBy(student => student.Course);
            foreach (var group in groupedStudents)
            {
                foreach (Student item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Кількість  студентів в групі: {group.Count()}");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: \"Ім'я: Олена, Оцінка: 95\".");
            var projection = students.Select(student => new
            {
                Name = student.Name,
                Grade = student.Grade
            });
            foreach (var item in projection)
            {
                Console.WriteLine($"Name: {item.Name}, Grade: {item.Grade}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price}";
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Course { get; set; }

        public Student(string name, int grade, string course)
        {
            Name = name;
            Grade = grade;
            Course = course;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Grade: {Grade} - Course: {Course}";
        }
    }
}