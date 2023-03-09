using System;
using System.Collections.Generic;
using System.Text;

namespace половинка_v2
{
    internal class Program
    {
        static double a, b, d, e;
        static int n = 1;
        static double f(double x)
        {
            double f = 2 * x * x + x + Math.Pow(Math.Cos(x), 2);
            return f;
        }
        static double xk1()
        {
            double local = (a + b) / 2 - d;
            return local;
        }
        static double xk2()
        {
            double local = (a + b) / 2 + d;
            return local;
        }
        static void Main(string[] args)
        {
            a = -1;
            b = 1;
            d = 0.0000001;
            e = 0.000001;
            while (b - a >= e)
            {
                if (f(xk1()) < f(xk2()))
                    b = xk2();
                else
                    a = xk1();
                n++;
            }
            Console.WriteLine("X минимальное: "+Convert.ToString((a+b)/2));
            Console.WriteLine("Значение функции в этой точке: "+Convert.ToString(f((a+b)/2)));
            Console.WriteLine("Количество итераций: "+Convert.ToString(n-1));
            Console.ReadLine();
        }
    }
}
