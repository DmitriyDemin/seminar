// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую
using System;
using System.Diagnostics;
namespace task7sem2
{
    class Numbers
    {
        public static void Main()
        {
            Stopwatch timer = new Stopwatch();
            
            int num;
            int num1;
            int num2;
            Console.Clear();
            {
                Console.Write("введите натуральное число N:  ");
                num = int.Parse(Console.ReadLine()!);
                while (num <= 0)
                {
                    Console.Write("ошибка ввода!\nвведите натуральное число N:  ");
                    num = int.Parse(Console.ReadLine()!);
                }
                while (num > 10)
                {
                    num1 = num / 10;
                    num2 = num - (num1*10);
                    num = num1;
                    
                    Console.Write($"{num2}, ");
                    
                }
                
                Console.Write($"{num} ");
            }
        }
    }
}
