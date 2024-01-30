// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
using System;
using System.Diagnostics;
namespace tack6sem2
{
    class Numbers
    {
        public static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int num;
            Console.Clear();
            {
                Console.Write("введите целое число из отрезка [10, 99]:  ");
                num = int.Parse(Console.ReadLine()!);
                while (num < 10 || num > 99)
                {
                    Console.Write("ошибка ввода!\nвведите целое число из отрезка [10, 99]:  ");
                    num = int.Parse(Console.ReadLine()!);
                }
            }
            int num1 = num / 10;
            int num2 = num % 10;
            if (num1 > num2)
                Console.WriteLine($"ннаибольшая цифра числа {num}: {num1}");
            else
                Console.WriteLine($"ннаибольшая цифра числа {num}: {num2}");
            timer.Stop();
            Console.WriteLine("-{0}", timer.Elapsed);
        }
    }
}
