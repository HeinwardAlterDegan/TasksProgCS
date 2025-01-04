using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черной ладьи");
            var blackRookPosition = Console.ReadLine();
           
            Console.WriteLine("Белая и черная ладья имеют следующие позиции:");
            Console.WriteLine(DecodePosition(whiteRookPosition));
            Console.WriteLine("");
            Console.WriteLine(DecodePosition(blackRookPosition));

            if (IsRooksPositionsIncorrect(blackRookPosition, whiteRookPosition)) 
            {
                Console.WriteLine("Изначальные позиции фигур некорректны. Фигуры под боем или стоят на одной клетке.");
                return;
            };

            Console.WriteLine("Введите ход белой ладьи.");
            var whiteRookMove = Console.ReadLine();
            if (IsWhiteRookMoveCorrect(whiteRookPosition, whiteRookMove)) {
                
                Console.WriteLine($"Ход на {DecodePosition(whiteRookMove)}соответствует правилам.");
            }
            else { Console.WriteLine("Клетка для хода выбрана неверно"); return; }

            if (IsWhiteRookMoveUnderAtack(whiteRookMove, blackRookPosition)){
                Console.WriteLine($"Ваш ход на {DecodePosition(whiteRookMove)} был фатальным. Белая ладья уничтожена");
            }
        }
        static bool IsRooksPositionsIncorrect (string blackRookPosition, string whiteRookPosiion) 
        {if (DecodePosition(whiteRookPosiion) == DecodePosition(blackRookPosition) || (
                blackRookPosition[0] == whiteRookPosiion[0]) || blackRookPosition[1] == whiteRookPosiion[1])
        return true;
        else return false;
        }

        static bool IsWhiteRookMoveCorrect(string whiteRookPosition,string whiteRookMove )
        {int wrCol, wrRow;
           (wrRow, wrCol)=  DecodePosition(whiteRookPosition);
         int wrmCol, wrmRow; 
           (wrmCol, wrmRow) = DecodePosition(whiteRookMove);
            return ((wrRow == wrmRow && wrCol != wrmCol) || (wrRow != wrmRow && wrCol != wrmCol));
        }
        static bool IsWhiteRookMoveUnderAtack (string whiteRookMove, string blackRookPosition)
        {
            int wrmRow, wrmCol;
            (wrmRow, wrmCol ) = DecodePosition(whiteRookMove);
            int brRow, brCol;
            (brRow, brCol) = DecodePosition(blackRookPosition);
            return ((wrmCol == brCol) || wrmRow == brRow);
        }
        static (int, int) DecodePosition(string position)
        {
            var column = (int)position[0] - 0x60;
            var row = int.Parse(position[1].ToString());

            return (row, column);
        }
    }
}
