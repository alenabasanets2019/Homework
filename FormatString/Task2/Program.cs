using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {  //кортежи
        static public (string name, int year) Perso (int year, string name)
        {
            int age = 2019 - year;
            return (name, age);
        }
        struct Person
        {
            public int age;
            public string name;
            public Person (string n, int a)
            {
                name = n;
                age = a;
            }
        }
         static void Main(params string[] args)

        {
            string result = "";
            
            for (int i = 0;i<args.Length;i++)
            {
            result += args[i];
            //Console.WriteLine(args[i] + "+");
            }
            Console.WriteLine(result);
           
            //Person person = new Person();
            //Console.WriteLine(new Person());
            //кортежи
            //Console.WriteLine(Perso(1995, "Alex"));
            //Console.WriteLine("input number of phone that contain 9 figures");
            //string  number = Console.ReadLine();
            //long n = Convert.ToInt64(number);
            //string result = String.Format("{0:+38 (0##) ###-##-##}", n);
            //Console.WriteLine(result);


        /*    Console.WriteLine("input some text:");
            string sentence = Console.ReadLine();
            Regex regex = new Regex(@"m(\w+)a", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(sentence);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("no matches");
            }

            Console.WriteLine("input some data:");
            string data = Console.ReadLine();
            Regex regex1 = new Regex(@"\w*\d\w*", RegexOptions.IgnoreCase);
            MatchCollection matches1 = regex1.Matches(data);
            if (matches1.Count > 0)
            {
                foreach (Match match in matches1)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("no matches");
            }*/



        }
        
        
    }
}//qicksort алгоритм