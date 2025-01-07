namespace Module_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            //human.Greetings();
            //Human human1 = new Human(21);
            //human1.Greetings();
            //Human human2 = new Human("Olga");
            //human2.Greetings();
            //Human human3 = new Human("Olga", 26);
            //human3.Greetings();





            //Data data = new Data { Name = "Запись", Lenght = 10, Version = 1, Array = new[] { 15, 30 } };
            //Obj obj = new Obj { Name = "Стол", IsAlive = false, Weight = 15 };

            //var DataCopy = data;
            //var ObjCopy = obj;

            //data.Name = "Значение";
            //data.Lenght = 25;
            //data.Version = 3;
            //data.Array[0] = 18;

            //obj.Name = "Стул";
            //obj.IsAlive = false;
            //obj.Weight = 5;

            //data.Show();
            //DataCopy.Show();
            //obj.Show();
            //ObjCopy.Show();

            //Department department = new Department { Company = new Company { Type = "Банк", Name = "ВТБ" }, City = new City { Name = "Санкт-Петербург" } };

            //if ((department?.Company?.Type == "Банк") && (department?.City?.Name == "Санкт-Петербург"))
            //{
            //    Console.WriteLine($"У банка {department.Company.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге");
            //}

            //Bus bus = new Bus { load = 20 };
            //bus.PrintStatus();

        }
    }

    class Triangle
    {
        public int x;
        public int y;
        public int z;

        public int Perimeter(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Square(int x, int y, int z)
        {
            int p = this.Perimeter(x, y, z);
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

    }
    class FoureSquare
    {
        public int x;
        public int Perimeter(int x)
        {
            return 4 * x;
        }
        public int Square(int x)
        { 
            return x * x;
        }
    }

    class Circle
    {
        public int r;
        public double Lenght(int r)
        {
            return 2 * Math.PI * r;
        }
        public double Square(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }



    class Car
    {
        public double Fuel;
        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }
    }
    class Bus
    {
        public int? load;
        public void PrintStatus()
        {
            if (load.HasValue && load != 0)
            {
                Console.WriteLine($"В автобусе {load} человек");
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }

        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    struct Data
    {
        public string Name;
        public int Lenght;
        public int Version;
        public int[] Array;
        public void Show()
        {
            Console.WriteLine($"Name = {Name}; Lenght = {Lenght}; Version = {Version}, Array = {Array[0]}, {Array[1]}");
        }
    }

    class Obj
    {
        public string Name;
        public bool IsAlive;
        public int Weight;
        public void Show()
        {
            Console.WriteLine($"Name = {Name}; IsAlive = {IsAlive}; Weight = {Weight}");
        }
    }


    class Rectangle
    {
        public int a;
        public int b;
        public int Square(int x, int y) => x * y;
        public Rectangle(int x, int y)
        {
            a = x;
            b = y;
        }

        public Rectangle(int x)
        {
            a = x;
            b = x;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

    }
    class Pen
    {
        public string Color;
        public int Cost;
        public Pen()
        {
            Color = "Чёрный";
            Cost = 100;

        }
        public Pen(string color)
        {
            Color = color;
            Cost = 100;

        }
        public Pen(int cost)
        {
            Color = "Чёрный";
            Cost = cost;

        }
        public Pen(string color, int cost)
        {
            Color = color;
            Cost = cost;

        }
    }
    class Human
    {
        public string Name;
        public int Age;

        public void Greetings()
        {
            Console.WriteLine($"Меня зовут {Name}, мне {Age} лет");
        }

        public Human()
        {
            Name = "Неизвестно";
            Age = 20;
        }

        public Human(string name)
        {
            Name = name;
            Age = 20;
        }

        public Human(int age)
        {
            Age = age;
            Name = "Неизвестно";
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    struct Animal
    {
        public string Type;
        public string Name;
        public int Age;

        public void Info()
        {
            Console.WriteLine($"Это {Type} по кличке {Name}, ему {Age}");
        }
    }
}
