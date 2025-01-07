namespace Module_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
}
