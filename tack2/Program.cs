// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

using System;
namespace seminar
{
    class Programm
    {
        public static void Main()
        {
            System.Console.WriteLine("введите число N");
            int num_N = Convert.ToInt32(Console.ReadLine());
            int i = -num_N;
            while (i < num_N)
            {
                System.Console.Write(i + ", ");
                i = i + 1;
            }
            System.Console.WriteLine(num_N);
        }
    }
}