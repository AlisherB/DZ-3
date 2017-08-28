using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ThirdTask
{
    class Program
    {
        /*
         3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. 
         Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
        */
        static void Main(string[] args)
        {
            char symbol = '0';
            while (symbol != '.')
            {
                symbol = ReadKey().KeyChar;
                if (symbol >= 'а' && symbol <= 'я')
                {
                   Write("\b" + (char)(symbol - 32));
                }
                else if (symbol >= 'А' && symbol <= 'Я')
                {
                   Write("\b" + (char)(symbol + 32));
                }
            }
            ReadLine();
        }
    }
}
