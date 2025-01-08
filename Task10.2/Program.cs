using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество слагаемых");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            double summ = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите слагаемое");
                double number;
                if (!TryInputNumberDouble(out number))
                {
                    Console.ReadKey();
                    return;
                }
                summ += Math.Abs(number);
            }
            Console.WriteLine($"Сумма введённых {n} слагаемых равна:{summ}");
            Console.ReadKey();
        }




        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }
        static bool TryInputNumberDouble(out double number)
        {
            number = 0;
            if (!double.TryParse(Console.ReadLine(), out double n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }
    }
}
