// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
using System;
namespace task1_sem3;
class Programm
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++) // можно сразу сослаться на 'n'
            array[i] = new Random().Next(-10, 11); // [-10; 10] для того чтобы верхний предел входил делать на +1
        Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
        Console.Write("Введите искомый элемент: ");
        int element = int.Parse(Console.ReadLine()!);
        string result = "Нет";
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
                result = "Да";
        }
        Console.WriteLine(result);
    }
}

