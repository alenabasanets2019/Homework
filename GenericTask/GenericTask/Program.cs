using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> ts= new List<int>(20){ 7, 9, 11, 5, 18, 40 };
            foreach (int i in ts)
                 Console.WriteLine(i);
            
            ts.Sort();
            foreach (int i in ts)
                Console.WriteLine(i);
            double[] b = new double[] { 10.1, 8.3,12.5,27.0};
            
           
            for (int k = 0; k < b.Length; k++)
            {
                if (b[k] < ts[0])
                    ts.Insert(0, (int)b[k]);
                for (int i = 1; i < ts.Count; i++)
                {
                    if (b[k] > ts[i - 1] && b[k] <= ts[i])
                    {
                        ts.Insert(i, (int)b[k]);
                        break;
                    }
                }
            }

            foreach (int i in ts)
                Console.WriteLine(i);

            //4
           string s = "I live in Newquay!It’s a small town on the Atlantic coast in the south of England!It has got great beaches and is the best place to surf in the UK. There are lots of surf schools where you can learn how to surf. I go surfing with my friends every weekend. My favourite place is Fistral Beach.I love Newquay because there are lots of other things to do as well as surfing.If you like water sports, you can go kayaking, water-skiing or coasteering. Coasteering is different because it is rock climbing, jumping into the sea and swimming in the same activity, but you should always go with a special instructor.If you like animals you can also visit the Blue Reef Aquarium and see lots of different fish and even sharks.You can also go horse riding on the beach or visit Newquay Zoo.There are lots of other attractions too like mini golf and bowling. Come and see for yourself!";
            int n = s.Length;
           
            //Console.WriteLine(s.Replace('!', '.'));
            List<char> str = new List<char>(n);
            str.AddRange(s.ToCharArray());
            str.Distinct();
            int y = 0;
            foreach (char i in str.Distinct())
            {
                //Console.Write(i + " ");
                y++;
            }
            Console.WriteLine();
            Console.WriteLine("Numbers of elements " + y);
            //8
            List<int> list = new List<int>() { 8, 28, 4, 25, 17, 11, 5 };
            //double av = list.Average();
            int av = list[list.Count/2];
            Console.WriteLine(av);
            int variab;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] < av && j > list.IndexOf(av))
                {
                    variab = list[j];
                    list.Remove(list[j]);
                    list.Insert(list.IndexOf(av)-1, variab);
                }
                if (list[j] >= av && j < list.IndexOf(av))
                {
                    variab = list[j];
                    list.Remove(list[j]);
                    list.Insert(list.IndexOf(av) + 1, variab);
                }
            }
            foreach (int i in list)
                Console.WriteLine(i);
            ArrayList arr = new ArrayList();
            arr.Add(7);
            arr.Add(56.8);
            arr.Add("Hello");
            arr.Add('j');
            arr.Add(new int[,] { { 9, 8, 7 }, { 8, 0, 2 } });
            int[,] l = (int[,])arr[4];
            for(int i = 0; i<l.GetLength(0);i++)
            {
                for (int j = 0; j < l.GetLength(1); j++)
                {
                    Console.WriteLine(l[i, j]);
                }
            }
            
            //arr.Sort();
            //foreach (ArrayList i in arr)
                //Console.WriteLine(i);
        }
    }
}
