namespace User
{
    internal class User
    {
        string login;
        string name;
        string lastName;
        int age;
        DateTime createdAt;

        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age
        {
            get { return age; }
            set { if (value > 0)
                {
                    age = value;
                } 
            }
        }


        public DateTime CreatedAt { get; }

        public User(string login, string name, string lastName, int age) {
            this.Login = login;
            this.Name = name;
            this.LastName = lastName;
            this.age = age;
            CreatedAt = DateTime.Now;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Name: {Name}, lastname: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"User created at: {CreatedAt}");
        }
    }
}
