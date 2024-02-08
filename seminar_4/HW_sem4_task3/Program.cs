//  Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
namespace Method
{
    class HW_sem_4_task3
    {
        public static void Main()
        {
            Console.Clear();
Console.Write("введите количество элементов массива:  ");
int n = int.Parse(Console.ReadLine()!);
int[] num = new int[n];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(100, 1000);
Console.WriteLine($"созданный массив: [{string.Join(", ", num)}]");

for (int j = 0; j < num.Length / 2; j++)
    {
        int temp = num[j];
        num[j] = num[num.Length - j-1];
        num[num.Length - j-1] = temp;
    }
Console.WriteLine($"созданный массив: [{string.Join(", ", num)}]");    
        }
    }
}
