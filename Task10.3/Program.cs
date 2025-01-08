using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            if (n < 0) 
            {
             Console.WriteLine("n не является натуральным");
             Console.ReadKey(); 
             return; 
            }

        

            Console.WriteLine($"Вот поседовательность квадратов натуральных чисел от 0 до {n}");
            for (int i = 0; i<=n; i++)
            {

                Console.WriteLine($"{Math.Pow(i,2)}");
            }
            Console.ReadKey() ;
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
    }
}
