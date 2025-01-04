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
            Console.WriteLine("Введите числа k,m,n");
            var k = int.Parse(Console.ReadLine()); 
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            if (IsDevisibleByThree(k, m, n)) 
            {
                Console.WriteLine("Числа кратны трём");
            }
            else { Console.WriteLine("Числа не кратны трём"); }
        }
        static bool IsDevisibleByThree (int k, int m, int n)
        {
            if ( (k % 3 == 0) && (m % 3 == 0) && (n % 3 == 0))
            {
                return true;
            } 
            return false;
           
           
        }
    }
}
