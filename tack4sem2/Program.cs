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
            int num;
            for (num=1; num<200; num++)
            {
            if ((num%7==0)&(num%23==0))
            Console.WriteLine("yes - {0}", num);
            timer.Stop();
            // else
            // Console.WriteLine("yes - {0}", num);
            
            }
            Console.WriteLine("время расчета -{0}", timer.Elapsed);
        } 
    }
}