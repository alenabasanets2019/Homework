using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8.07
namespace Delevent
{
    delegate bool Examp(double x);
    //Делегати: Написати статичний клас для роботи з числовими масивами (там стат функції обчислення суми, макс і середнього значення) 
    //ці функції повинні приймати аргументами 1.масив 2.делегат який визначає умову для елемента масиву, чи він буде брати участь в обчисленні
    static class Calc{
        public static double Sum(double[] arr, Examp func)
        {
            double result = 0;
            foreach (double i in arr)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
        public static double Maxval(double[] arr, Examp func)
        {
            double result = arr[0];
            
            foreach (double i in arr)
            {
                if (func(i))
                { 
                    if(i > result)
                    result = i;
                }
            }
            return result;
        }
        public static double Averval(double[] arr, Examp func)
        {
            double result = 0;
            double length = 0;
            foreach (double i in arr)
            {
                if (func(i))
                {
                    result += i;
                    length++;
                }
                       
            }
            return result/length;
        }
    }
    //Івенти: Написати клас таймер з можливістю підписки на подію спрацювання таймера. Підписник виводить звуковий сигнал, коли таймер спрацьовує.
    class Timer
    {
        // Объявляем делегат
        public delegate void TimerOn(string message);
        // Событие
        public event TimerOn Triggering;
        public void Reaction()
        {
            
            if (Triggering != null)
                Triggering("Dzin");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            // найдем сумму чисел больше 5
            double result1 = Calc.Sum(integers, x => x > 5);
            Console.WriteLine(result1); // 30

            // найдем max четных чисел
            double result2 = Calc.Maxval(integers, x => x % 2 == 0);
            Console.WriteLine(result2);  //8

            // найдем average четных чисел
            double result3 = Calc.Averval(integers, x => x % 2 != 0);
            Console.WriteLine(result3);  //5

           Timer t = new Timer();
            // Добавляем обработчики события
            t.Triggering += Show_Message;
            //t.Triggering -= Show_Message;
            t.Reaction();

        }
        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
            Console.Beep(1000,10000);
        }
    }//калькулятор і перевірити unittest і mstest
}
