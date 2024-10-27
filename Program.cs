using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProgCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано выражение:x= (2+e^(-2))/(3) + ((3+e^(-3))/(5) + (5+5^(-5))/7)");
            Console.WriteLine("");
            Console.WriteLine("X="+(CalculateX(3)+CalculateX(5)+CalculateX(7)));
        }
        static double CalculateX(double n)
        {
            return (1 / n) * ((Math.Round(n * 2 / 3) + Math.Pow(Math.E, -(n * 2 / 3))));
        }
    }
}
