namespace Module_6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new BaseClass("Olga");
            //if (obj is BaseClass)
            //{
            //    BaseClass bs = (BaseClass)obj;
            //    Console.WriteLine("OK");
            //}

            //BaseClass bs = obj as BaseClass;
            //if (bs != null)
            //{
            //}

            //if (obj is BaseClass bs)
            //{
            //    //Код с использованием переменной bs как экземпляр класса BaseClass
            //}

        }
    }


    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        
        public string Description;

        public int Counter;
        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int couner) : this(name, description)
        {
            Counter = couner;
        }

    }


    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            this.owner = ownerName;
            this.length = objLength;
            this.count = count;
        }
    }

    class Fruits : Food
    {

    }

    class Vegetables : Food
    {

    }

    class Food
    {

    }

    class Apple : Fruits
    {

    }
}
