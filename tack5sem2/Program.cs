// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

using System;
using System.Diagnostics;
namespace tack5sem2
{
    class Coordinates
    {
        public static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int X;
            Console.WriteLine("введите координаты по оси Х");
            X = Convert.ToInt32(Console.ReadLine());
            int Y;
            Console.WriteLine("введите координаты по оси Y");
            Y = Convert.ToInt32(Console.ReadLine());
            if ((X > 0) & (Y > 0))
                Console.WriteLine("номер координатной четверти - I");
            if ((X > 0) & (Y < 0))
                Console.WriteLine("номер координатной четверти - II");
            if ((X < 0) & (Y < 0))
                Console.WriteLine("номер координатной четверти - III");
            if ((X < 0) & (Y > 0))
                Console.WriteLine("номер координатной четверти - IV");
            timer.Stop();
            Console.WriteLine("-{0}", timer.Elapsed);
        }
    }
}