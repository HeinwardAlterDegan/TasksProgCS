using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество академических групп.");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число n должно быть натуральным");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите количество людей в каждой группе.");
            int m;
            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }
            if (m < 1)
            {
                Console.WriteLine("Число m должно быть натуральным");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите количество экзаменов, которые сдал каждый студент.");
            int k;
            if (!TryInputNumber(out k))
            {
                Console.ReadKey();
                return;
            }
            if (k < 1)
            {
                Console.WriteLine("Число k должно быть натуральным");
                Console.ReadKey();
                return;
            }

            
            double averageGadeOfGroup = 0;
            double maxAverageGrade = 0;
            for (int i = n ;i != 0; i --)
            {
                for (int im = m;im !=0; im--)
                {
                    averageGadeOfGroup = 0;
                    Console.WriteLine("Введите результаты каждого экзамена для студента");
                    for (int ik = k;ik !=0; ik--)
                    {
                    
                        int grade;
                        if (!TryInputNumber(out grade))
                        {

                            Console.ReadKey();
                            return;
                        }
                    
                        if (grade > 100 || grade < 0)
                        {
                            Console.WriteLine("Балл не может быть меньше 0 или больше 100");
                            Console.ReadKey();
                            return;
                        }
                    averageGadeOfGroup += grade;
                    }

                averageGadeOfGroup = averageGadeOfGroup / m;
                if (averageGadeOfGroup > maxAverageGrade) maxAverageGrade = averageGadeOfGroup;
                }
                
            }
            Console.WriteLine($"Группа с наибольшим средним баллом имеет бал:{maxAverageGrade}");

          
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
