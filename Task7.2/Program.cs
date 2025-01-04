using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки на плоскости:");
            Console.WriteLine("Координата х:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Координата у:");
            var y = int.Parse(Console.ReadLine());
            if (IsDotInTheArea(x , y))
            {
                Console.WriteLine("Точка лежит в области");
            }
            else { Console.WriteLine("Точка не лежит в области"); }
            Console.ReadKey();
        }
        static bool IsDotInTheArea(int x, int y) 
        {
            if ((x <= -3 && x >= -2) || (x >=-1 && y >= -2) ) { return true; }
            else return false;
        }
    }
}
