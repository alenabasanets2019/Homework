using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7, 5];
            Random ran = new Random();
            int[] sumrow = new int[7];
            int[] sumline = new int[5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", array[i, j]);

                }
                Console.WriteLine();
            }

            for (int i = 0, k = 0; i < 7 && k < 7; i++, k++)
            {
                for (int j = 0; j < 5; j++)
                {

                    sumrow[k] += array[i,j];
                    
                    
                }
                
            }
            for (int i = 0, m = 0; i < 5 && m < 5; i++, m++)
            {
                for (int j = 0; j < 7; j++)
                {

                    

                    sumline[m] += array[j, i];
                }

            }
            for (int k = 0;k<sumrow.Length;k++)
            {
                if(sumrow[k] == sumrow.Max())
                    Console.WriteLine("max sum row " + sumrow.Max() + " in line " + k);
            }
            
            for (int k = 0; k < sumline.Length; k++)
            {
                if (sumline[k] == sumline.Max())
                    Console.WriteLine("max sum line " + sumline.Max() + " in row " + k);
            }

        }
    }
}
// в двовимірному масиві знайти № рядка і№ стовпця з найбільшою сумою чисел
// class car
//overriding operators