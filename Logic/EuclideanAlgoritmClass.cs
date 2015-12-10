using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logic
{
    public class EuclideanAlgoritmClass
    {
        public static int Algoritm(Stopwatch timer, int a, int b)
        {
            if (a == 0||b==0)
            {
                throw new ArgumentException();
            }
            timer.Start();
            int t;
            a = Math.Abs(a);
            b = Math.Abs(b);
            
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        public static int Algoritm(Stopwatch timer, int a, int b, int c)
        {
            return Algoritm(timer, Algoritm(timer, a, b), c);
        }

        public static int Algoritm(Stopwatch timer, params int[] arg)
        {
            int temp = Algoritm(timer, arg[0], arg[1]);

            for (int i = 2; i < arg.Length; i++)
            {
                temp = Algoritm(timer, temp, arg[i]);
            }

            return temp;

        }




    }
}
