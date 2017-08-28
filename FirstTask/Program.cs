using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Написать программу, которая считывает символы
            с клавиатуры, пока не будет введена точка.
            Программа должна сосчитать
            количество введенных пользователем пробелов
            */
            int countSpaces = 0;
            char symbol;
            WriteLine("Введите текст");
            do
            {
                symbol = ReadKey().KeyChar;
                if (symbol == ' ')
                    countSpaces++;
            } while (symbol != '.');

            WriteLine("\nКоличество пробелов = " + countSpaces);
            ReadKey();
        }
    }
}
