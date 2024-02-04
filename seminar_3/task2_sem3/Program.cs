// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

using System;
namespace task2_sem3;
class Programm
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++) // можно сразу сослаться на 'n' но лучше length
            array[i] = new Random().Next(-10, 11);
        Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                array[i] = -array[i];
            else if (array[i] > 0)
                array[i] = -array[i];
        }
        Console.WriteLine($"Преобразованный массив: [{string.Join(", ", array)}]");
    }
}

