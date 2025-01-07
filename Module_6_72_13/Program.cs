namespace Module_6_72_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new Book[] {
                new Book { Name = "Мастер и Маргарита", Author = "Булгаков"},
                new Book { Name = "Отцы и дети", Author = "И.С. Тургенев"}
            };
            ////var AS = new AbstractClass(); // потому что он абстрактный
            //int num1 = 3;
            //int num2 = 58;
            //Helper.Swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            string str = "Hello";
            Console.WriteLine(str.GetLastChar());

            Console.WriteLine("Строка".GetLastChar());

            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }
    }

    static class IntExtension
    {
        public static int GetNegative (this int value)
        {
            if (value > 0)
            {
                return -value;
            }
            else
            {
                return value;
            }
        }
        public static int GetPositive(this int value)
        {
            if (value < 0)
            {
                return -value;
            }
            else
            {
                return value;
            }
        }

    }
    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }
    }

    class Helper
    {
        public static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;

        }
    }


    class Obj1
    {
        public string Name;
        public string Description;
        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj1()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }


    }




    class Obj
    {
        public string Name;
        public string Description;
        public static int MaxValue = 2000;
    }


    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {

        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    abstract class AbstractClass
    {
        public string Name;
    }


    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    return 0;
                }
                else
                {
                    return array[index];
                }
            }

            private set
            {
                if (index > 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
    }


    class Book
    {
        public string Name;
        public string Author;
    }

    class BookCollection
    {
        private Book[] Collection;
        public BookCollection(Book[] Collection)
        {
            this.Collection = Collection;
        }

        public Book this[int index]
        {
            get
            {
                if ((index >= 0) && (index < this.Collection.Length))
                {

                    return this.Collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                if ((index >= 0) && (index < this.Collection.Length))
                {

                    this.Collection[index] = value;
                }
            }

        }

        public Book this[string name]
        {
            get
            {
                for (int i = 0; i < this.Collection.Length; i++)
                {
                    if (this.Collection[i].Name == name)
                    {
                        return this.Collection[i];
                    }
                }
                return null;
            }
        }
    }
}
