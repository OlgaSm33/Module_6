namespace Module_6_727
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    class Obj
    {
        public int Value;
        public static Obj operator + (Obj x, Obj y)
        {
            return new Obj
            {
                Value = x.Value + y.Value
            };
        }

        public static Obj operator - (Obj x, Obj y)
        {
            return new Obj
            {
                Value = x.Value - y.Value
            };
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public new void Display()
        {  
            Console.WriteLine("B"); 
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }

    class E :C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }
}
