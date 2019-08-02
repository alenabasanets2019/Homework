using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generic<T>
    {
        public T a;
        public static T b;
        public T[] generics = new T[8];
        public T Adddata(T data)
        {
            
            int newsize = generics.Length + 1;
            Array.Resize(ref generics, newsize);
            generics[newsize - 1] = data;
            return data;
        }
        public void Deletedata(T data)
        {
            for (int i = 0; i < generics.Length; i++)
            {
                if (generics[i].Equals(data))
                {
                    
                    var tmp = new List<T>(generics); // Преобразование в список
                    tmp.RemoveAt(i); // Удаление элемента
                    generics = tmp.ToArray(); // Преобразование в массив
                }  
            }
            return;
        }
        public T Searchdata(int data)
        {
            for (int i = 0; i < generics.Length; i++)
            {
                if (i == data)
                    return generics[i];
                
            }
            
            return generics[0]; //Не спрацює
        }
        public int Lentharray()
        {
            return generics.Length;
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Generic<string> ob1 = new Generic<string>();
            string[] s1 = new string[4] { "ghu", "xgdg", "zxdg", "gsgfh" };
            ob1.generics = s1;
            ob1.Adddata("jhg");
            foreach (String i in ob1.generics)
            {
                Console.WriteLine(i);
            }
           
            Console.WriteLine(ob1.Lentharray());
            ob1.Deletedata("jhg");
            foreach (String i in ob1.generics)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ob1.Searchdata(3));
            Console.WriteLine(ob1.Lentharray());
            Generic<int> account1 = new Generic<int>();
            account1.a = 5436;

            Generic<string> account2 = new Generic<string>();
            Generic<string>.b = "45245";

            Console.WriteLine(account1.a);      // 5436
            Console.WriteLine(Generic<string>.b);   // 45245
        }
    }
}
