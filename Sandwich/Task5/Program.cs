using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*class Person
    {
        public string Name { get; set; }
    }
    class Student : Person
    {
        public static explicit operator Student(Person p)
        {
            return new Student();
        }
    }*/
    class Bread
    {
        public int Weight { get; set; } // масса
        public static Sandwich operator +(Bread br, Butter bt)
        {
            return new Sandwich { Weight = br.Weight + bt.Weight };
        }
    }

    // масло
    class Butter
    {
        public int Weight { get; set; } // масса
    }

    // бутерброд
    class Sandwich
    {
        public int Weight { get; set; } // масса
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);  // 100
        }
    }
}
