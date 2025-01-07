namespace Module_6_762
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }

    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Engine
    {

    }
    class ElectricEngine : Engine 
    {

    }

    class GasEngine : Engine
    {
        
    }

    class CarPart
    {

    }
    class Battery : CarPart
    {

    }

    class Differential : CarPart
    {

    }

    class Wheel : CarPart
    {

    }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine = default(TEngine);

        public virtual void ChangePart<Tpart> (Tpart newpart) where Tpart : CarPart
        {

        }

        public double Fuel;
        public int Mileage;
        public string Color;
        private TurnDirection turn;
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
            Color = "White";
        }



        protected internal virtual void Move()
        {
            Console.WriteLine("Обычный");
            Fuel -= 0.5;
            Mileage++;

        }

        private void Turn(TurnDirection turnDirection)
        {
            turn = turnDirection;
        }
        public void FiilTheCar()
        {
            Fuel = 50;
        }

        public string GetColor(string color)
        {
            return color;
        }

        public void ChangeColor(string new_color)
        {
            if (new_color != Color)
            {
                Color = new_color;
            }
        }

        public bool IsTurningLeft(TurnDirection turnDirection)
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight(TurnDirection turnDirection)
        {
            return turn == TurnDirection.Right;
        }

    }

    enum FuelType
    {
        Gas = 0,
        Electicity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;
        public Double Gas;
        public double Electicity;
        public HybridCar() : base()
        {
            Electicity = base.Fuel;
            Gas = base.Fuel;
        }
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }

        protected internal override void Move()
        {
            base.Move();
            Console.WriteLine("Метод Гибрид");
            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electicity:
                    Electicity -= 0.5;
                    break;
            }
        }
    }
}
