using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2.	Ввести с клавиатуры номер трамвайного билета (6-значное число)
             и про-верить является ли данный билет счастливым (если на билете напечатано шестизначное число,
             и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
             */
            string ticket;              //строка для ввода номера трамвайного билета
            int number;                 //номер трамвайного билета
            int countDigit = 100000;    //(6-значное число)
            int tenThousand = 10000;    //(5-значное число)
            int thousand = 1000;        //(4-значное число)
            int hundred = 100;          //(3-значное число)
            int ten = 10;               //(2-значное число)
            do
            {
                Clear();
                Write("Введите номер трамвайного билета: ");
                ticket = ReadLine();
                number = Int32.Parse(ticket);
            } while (number <= countDigit);

            if (number / countDigit > 0)
            {
                int digitOne = number / countDigit;
                int digitTwo = (number % countDigit) / tenThousand;
                int digitThree = ((number % countDigit) % tenThousand) / thousand;
                int digitFour = (((number % countDigit) % tenThousand) % thousand) / hundred;
                int digitFive = ((((number % countDigit) % tenThousand) % thousand) % hundred) / ten;
                int digitSix = ((((number % countDigit) % tenThousand) % thousand) % hundred) % ten;

                int sumFirst = digitOne + digitTwo + digitThree;
                int sumLast = digitFour + digitFive + digitSix;

                if (sumFirst == sumLast)
                {
                    WriteLine("Счастливый билет!");
                }
                else
                {
                    WriteLine("Не счастливый билет!");
                }
            }
            else WriteLine("Введен несуществующий билет!");
            ReadLine();
        }
    }
}
