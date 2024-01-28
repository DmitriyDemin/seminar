// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17
using System;
namespace seminar
{
    class Programm
    {
        public static void Main()
        {
            System.Console.WriteLine("введите любое число N");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                num = num * (-1);
            }
            int num_last = num % 10;
            while (num > 10)
            {
                num = num / 10;
            }
            System.Console.WriteLine(num + num_last);
        }
    }
}
