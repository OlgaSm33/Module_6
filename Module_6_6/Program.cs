using System.ComponentModel.DataAnnotations;

namespace Module_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen C = new Citizen { Age = 12 };
            C.SayYourAge();
            CivilServant C1 = new CivilServant();
            C1.Age = 12;
            C1.SayYourAge();
        }
    }

    class Citizen
    {
        public virtual double Age { get; set; }
        public void SayYourAge()
        {
            Console.Write(Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("< 18");
                }
                else { age = value; }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get { return age; }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("< 18");
                }
                else { age = value; }
            }
        }
    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }

        public virtual void Display()
        {
            Console.WriteLine("BaseClass");
        }
        public virtual void Method()
        {

        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override void Display()
        {
            base.Display();
            Console.WriteLine("DerivedClass");
        }
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                { counter = value; }
            }
        }
        public override void Method()
        {
            base.Method();
        }
    }
}
