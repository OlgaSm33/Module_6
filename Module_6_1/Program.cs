namespace Module_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new HybridCar();
            car.Move();
            Car car1 = new Car();
            car1.Move();
            ((Car)car).Move();
           
        }
    }

    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Car
    {
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
