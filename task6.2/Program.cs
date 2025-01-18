using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s ="Теплоход";
            var word1 = ReverseString(s).Substring(2,3)+ s.Remove(0,6);


            var word2 = s.Substring(7,1) + s.Remove(2,1).Substring(1,3);
            Console.WriteLine(word1);
            Console.WriteLine("");
            Console.WriteLine(word2);
  
        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        } 
    }
}
