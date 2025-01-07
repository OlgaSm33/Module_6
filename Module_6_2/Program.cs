using System.Collections.Specialized;

namespace Module_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class User
    {
        private int age;
        private string login;
        private string email;
        private DateTime lastSeen;
        public string HairColor { get; private set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст не должен быть < 18");
                }
                else
                {
                    age = value;
                }

            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее трёх символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            private set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Email должен содержать символ '@'");
                }
            }
        }

        public DateTime LastSeen
        {
            set
            {
                lastSeen = value;
            }
        }

    }
}
