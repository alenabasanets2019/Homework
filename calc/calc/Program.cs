using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calc
    {
        public int x;
        public int y;
        public int Sum (int x,int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x*y;
        }
        public int square(int x)
        {
            return x*x;
        }
        public double Root(int x)
        {
            return Math.Pow(x, 0.5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            Console.WriteLine(c.Root(225));
        }
    }
}
