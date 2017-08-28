using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FourTask
{
    class Program
    {
            /*
            4.  Даны целые положительные числа A и B(A<B).
            Вывести все целые числа от A до B включительно;
            каждое число должно выводиться на новой строке;
            при этом каждое число должно выводиться количество раз,
            равное его значению. Например: если А = 3, а В = 7,
            то программа должна сформировать в консоли следующий вывод:
            */
        static void Main(string[] args)
        {
            Metka:
            Clear();
            Write("Введите первое число: ");
            int numA = Convert.ToInt32(ReadLine());
            Write("\nВведите второе число: ");
            int numB = Convert.ToInt32(ReadLine());
            if (numA < 0 || numB < 0)
            {
                WriteLine("\nЧисла должны быть положительными!");
                WriteLine("\nНажмите Enter для возврата к вводу числа...");
                ReadLine();
                goto Metka;
            }
            WriteLine();
            for (int i = numA; i <= numB; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(i + " ");
                }
                WriteLine();
            }
            WriteLine("\nНажмите Enter для возврата к вводу числа...");
            ReadLine();
            goto Metka;
        }
    }
}
