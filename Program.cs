using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProgCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("f(x)=" + CalculateFunction(x));
        }
        static double CalculateFunction(double x)
        {
            if (x > 1) { return Math.Log(x); }

            else if (x > 0 && x <= 1)
            { return -Math.Log(x); }
            else { return 0; }; 


        }
    }
} 
