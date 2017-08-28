using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FifthTask
{
    class FifthTask
    {
        /*
        5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
        Например, если было введено число 345, то программа должна вывести число 543. 
        */
        static void Main(string[] args)
        {
            Metka:
            Clear();
            WriteLine("Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.");
            Write("\nВведите число: ");
            int num = Convert.ToInt32(ReadLine());
            int reverseNum = 0;
            if (num < 0)
            {
                Clear();
                WriteLine("Число отрицательное!");
                WriteLine("Нажмите Enter для возврата к вводу числа...");
                ReadLine();
                goto Metka;
            }

            while (num > 0)
            {
                reverseNum += num % 10;
                num /= 10;
                reverseNum *= 10;
            }
            reverseNum /= 10;
            WriteLine("\nРезультат = " + reverseNum);
            WriteLine("Нажмите Enter для возврата к вводу числа...");
            ReadLine();
            goto Metka;
        }
    }
}