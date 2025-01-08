using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            if (n<0)
            {
                Console.WriteLine("Число n не является натуральным");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число k. От 0 до 8.");
            int k;
            if (!TryInputNumber(out k))
            {
                Console.ReadKey();
                return;
            }
            if (k > 8 && k < 0)
            {
                Console.WriteLine("Число k не соответсвутет условиям");
                Console.ReadKey();
                return;
            }

            int summ = 0;
            int nForSumm = n;
            while (nForSumm != 0) 
            {
                int digit = nForSumm % 10; 
                if (digit > k) 
                {
                    summ += digit; 
                }
                nForSumm = nForSumm / 10; 

            }
            Console.WriteLine($"Сумма цифр числа {n}, подходящих условию, равна {summ}");
            Console.ReadKey ();
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
