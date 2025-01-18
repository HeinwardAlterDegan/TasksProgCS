using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
       
      
            static void Main(string[] args)
            {
            Console.WriteLine("Введите текст на английском");
            Console.WriteLine("Он будет переведён на Leet.");
            Console.WriteLine("");


            var text = Console.ReadLine();
                Console.WriteLine(LeetTranslator(text));

                Console.ReadKey();
            }
            static string LeetTranslator(string s)
            {
                s = s.
                    ToUpper()
                    .Replace("A", "2")
                    .Replace("B", "4")
                    .Replace("C", "(")
                    .Replace("D", "|)")
                    .Replace("E", "3")
                    .Replace("F", "|=")
                    .Replace("G", "6")
                    .Replace("H", "|-|")
                    .Replace("I", "!")
                    .Replace("J", ")")
                    .Replace("K", "|<")
                    .Replace("L", "1")
                    .Replace("M", @"|\/|") 
                    .Replace("N", @"|\|") 
                    .Replace("O", "0")
                    .Replace("P", "|>")
                    .Replace("Q", "9")
                    .Replace("R", "|2")
                    .Replace("S", "5")
                    .Replace("T", "7")
                    .Replace("U", "|_|")
                    .Replace("V", @"\/")
                    .Replace("W", @"\/\/")
                    .Replace("X", "><")
                    .Replace("Y", "'/")
                    .Replace("Z", "2")
                    ;
            return s;
            throw new NotImplementedException();
            
        }
        }
    }
    

