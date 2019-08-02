using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar
{
    class Car
    {
        const string CompanyName = "Audi";
        string color;
        Car[] cars = new Car[6];
        public Car this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        public string name;
        public double price;
        public Car()
        {

        }
        public Car(string n, string c, double p)
        {
            name = n;
            color = c;
            price = p;
        }
        public void Input()
        {
            name = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
            
            color = Console.ReadLine();
        }
        public void Print()
        {

            Console.WriteLine("name " + name);
            Console.WriteLine("price " + price);
            Console.WriteLine("color " + color);
        }
        public static bool operator != (Car c1, Car c2)
        {
            return c1.color != c2.color || c1.price != c2.price;
        }
        public static bool operator == (Car c1, Car c2)
        {
            return c1.color == c2.color && c1.price == c2.price;
        }
        public static Car operator +(Car c1, double x)
        {
            return new Car { price = c1.price + x };
        }
        public static double operator +(double x, Car c1)
        {
            return x = c1.price + x;
        }
        public static Car operator -(Car c1, double x)
        {
            return new Car { price = c1.price - x };
        }
        public double ChangePrice (double x)
        {
           
                return price = price - x/100;
        }
        public string ToString ()
        {
            return name + " " + price + " " + color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car o1 = new Car("5478", "black", 700.0);
            Car o2 = new Car("5478", "white", 700.0);
            Car o3 = new Car("5478", "black", 700.0);
            o2.Color = "red";
            o2.Print();
            o1.price = o1.price + 7.0;
            Console.WriteLine(o1.price);
            o1.ChangePrice(10.0);
            o1.Print();
            Car o4 = new Car("n755","blue",500.0);
            Console.WriteLine(o4.ToString());
            o4[0] = new Car("875","green",900.0);
            Console.WriteLine(o4[0].name);
            o4[1] = new Car();
            Console.WriteLine(o4[1].ToString());

             

        }
    }
}//+ перевантаження який буде збільшуввати ціну, двосторонній
//колекція машин індксатори
