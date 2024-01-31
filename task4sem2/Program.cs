// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

using System.Diagnostics;
using System;
namespace task4sem2
{
    class Multi
    {
        public static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.Clear();
            int num;
            {
                Console.Write("введите целое число :  ");
                num = int.Parse(Console.ReadLine()!);
                if ((num % 7 == 0) & (num % 23 == 0))
                    Console.WriteLine($"число {num} кратно одновременно 7 и 23");
                else
                    Console.WriteLine($"число {num} не кратно одновременно 7 и 23");;
                timer.Stop();
            }
            Console.WriteLine("время расчета -{0}", timer.Elapsed);
        }
    }
}