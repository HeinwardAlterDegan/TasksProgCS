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
            Console.WriteLine($"Дано выражение: y=|x+|x+|x+√(x+1)|||");
            Console.WriteLine("");
            Console.WriteLine("Введите значение x, чтобы получить y");
            var x = double.Parse( Console.ReadLine());
            Console.WriteLine("Значение y ="+CalculateY(x));
        }
        static double CalculateY(double x)
        {
            var y = Math.Abs(x + Math.Abs(x + Math.Abs(x + Math.Sqrt(x + 1))));
            return y;
        }
    }
}
