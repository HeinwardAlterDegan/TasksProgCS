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
            Console.WriteLine("Введите число целое а. Оно должно быть меньше 500");
            int a;

            if (!TryInputNumber(out a))
            {
                Console.ReadKey();
                return;
            }
            if (a >= 500)
            {
                Console.WriteLine("Число а больше или равно 500");
                Console.ReadKey();
                return;
            }

            double product = 0;

            for (double i = a; i < 500; i++)
            {
                product += Math.Pow(i, 3);
            }

            Console.WriteLine($"Сумма кубов чисел от a до 500 ={product} ");
            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Введено неверное число.");
                return false;
            }

            number = n;
            return true;
        }
    }
}
