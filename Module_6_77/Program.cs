using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Module_6_77
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }


    static class StringExtentions
    {
        public static bool CheckString(this string str, string nameStr)

        {
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine($"{nameStr} должно содержать символы");
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Customer //клиенты
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.CheckString("Имя"))
                {
                    name = value;
                }
            }
        }
        private string secondName;
        public string SecondName
        {
            get { return secondName; }
            set
            {
                if (value.CheckString("Фамилия"))
                {
                    secondName = value;
                }
            }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (value.CheckString("Адрес"))
                {
                    address = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.CheckString("Телефонный номер"))
                {
                    phoneNumber = value;
                }
            }

        }
        private PaymentMethod paymentMethod;
        public Customer()
        {
            this.name = "Неизвестно";
            this.secondName = "Неизвестно";
            address = "г. Кемерово";
            phoneNumber = "+79000000000";
            paymentMethod = new PaymentMethod();

        }

        public Customer(string name, string secondName)
        {
            this.name = name;
            this.secondName = secondName;
            address = "г. Кемерово";
            phoneNumber = "+79000000000";
            paymentMethod = new PaymentMethod();
        }

        public Customer(string name)
        {
            this.name = name;
            this.secondName = "Неизвестно";
            address = "г. Кемерово";
            phoneNumber = "+79000000000";
            paymentMethod = new PaymentMethod();
        }

        
        



    }


    interface IProduct<Tid> // создали этот интерфейс, так как нужен был доступ к цене товара из корзины, но у класса товаров было обобщение
    {
        int Price { get; }
        string Name { get; }
        Tid Id  { get; }

    }
    class Product<TId> : IProduct<TId>
    {
        public TId Id { get; set; }
        public string Name { get; set; }
        public string Description;
        public int Price { get; set; }
        public bool Availability;

        public Product(TId id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    class Category<TProduct, TId> where TProduct : IProduct<TId>
    {
        public string Name;
        public string Description;
        public List<TProduct> products;
      
    }

    class Status
    {
        public string Name;
        public string Description;
    }

    
    class ProductList<Tproduct, TId> where Tproduct : IProduct<TId>//корзина товаров
    {
        public List<Tproduct> productList;
        public int Count()
        {
            int count = 0;
            foreach (Tproduct product in productList)
            {
                count++;
            }
            return count;
        }

        public int Cost()
        {
            int cost = 0;
            foreach (Tproduct product in productList)
            {
                cost += product.Price;
            }
            return cost;
        }

        public static ProductList<Tproduct, TId> operator + (ProductList<Tproduct, TId> x, Tproduct y) // перегрузка, чтобы можно было через += добавлять в корзину товар
        {
            x.productList.Add(y);
            return x;
        }

        public static ProductList<Tproduct, TId> operator -(ProductList<Tproduct, TId> x, Tproduct y) // перегрузка, чтобы можно было через -= удалять из корзины
        {
            x.productList.Remove(y);
            return x;
        }

        public Tproduct this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return productList[index];
                }
                else
                {
                    return default(Tproduct);
                }
            }

        }


    }

    class PaymentMethod
    {
        public string Name;
        public string Type;
        public long ID;
        

    }

    class Order<TDelivery, TProduct, TId> where TDelivery : Delivery  where TProduct : IProduct<TId>
    {
        public TDelivery delivery;
        public int Number;
        public string Description;
        public DateTime CreationDate;
        public Status OrderStatus;
        public ProductList<TProduct, TId> productList;
        public string Address;
        public PaymentMethod paymentMethod;

  




        public void DisplayAddress()
        {
            Console.WriteLine(delivery.Address);
        }

    }

    abstract class Delivery
    {
        protected static int deliveryTimeDayBase = 3;
        protected static int deliverySpeed = 500; 
        private string address;
        private int deliveryTimeDay; // количество дней доставки
        public virtual int deliveryTimeDayCount(double DistanceKm)
        {
            return (int)Math.Ceiling(deliveryTimeDayBase + DistanceKm / deliverySpeed);
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                value.CheckString("Адрес");
            }
        }

    }

    class HomeDelivery : Delivery
    {
        private static double K = 1.5; // коэффициент для расчёта количества дней доставки
        public override int deliveryTimeDayCount(double DistanceKm)
        {
            return (int)Math.Ceiling((deliveryTimeDayBase + DistanceKm / deliverySpeed) * K);
        }


    }

    class PickPointDelivery : Delivery
    {
        private static int K; // количество дней, на которые уменьшается доставка при получении из пункта выдачи
        public override int deliveryTimeDayCount(double DistanceKm)
        {
            return (int)Math.Ceiling(deliveryTimeDayBase + DistanceKm / deliverySpeed) - K;
        }
    }

    class ShopDelivery : Delivery
    {
        public override int deliveryTimeDayCount(double DistanceKm)
        {
            if (DistanceKm > 1000)
            {
                return 0; // возващаем 0, так как доставка невозможна
            }
            else
            {
                return (int)Math.Ceiling(DistanceKm / deliverySpeed);
            }
        }
    }
}
