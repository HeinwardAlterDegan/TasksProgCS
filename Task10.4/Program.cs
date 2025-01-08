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
            Console.WriteLine("");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }


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
