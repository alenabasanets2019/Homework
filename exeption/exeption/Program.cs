using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeption
{
    class Program
    {
        public int[] ReadNumber(int start, int end)
        {
            int[] a = new int[10];
            try
            {
                a[0] = 4;
                for (int i = 1; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (a[i] < a[i - 1])
                        {
                            throw new Exception("incorrect data: next element is smaller than previous");

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка: {e.Message}");
                        return null;
                    }
                }
                if (a[0] < start || a[9] > end)
                {
                    throw new Exception("incorrect data");
                }

                else return a;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return null;
            }

        }
        static void Main(string[] args)
        {
            
            try
            {
                Program p = new Program();
                p.ReadNumber(1, 100);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            }
        }//анонімні типи даних
    //linq
    }

