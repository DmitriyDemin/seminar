// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// 20 мин
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

using System;
namespace Matrix
{
    class seminar_5
    {
        public static void Main()
        {
            Console.Clear();
            void inputMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = new Random().Next(1, 10); // [1, 11]
                    }
                }
            }

            void printMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }


            double[] searchAvg(int[,] matrix, double[] array)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    double sumRow = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sumRow += matrix[i, j];
                    }
                    array[i] = Math.Round(sumRow / matrix.GetLength(1), 2);
                    // int / int = int
                    // int / double = double
                    // double / int = double
                }
                return array;
            }


            Console.Clear();
            Console.Write("Введите размеры 2D массива: ");
            int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            double[] avgArray = new double[size[0]];
            inputMatrix(matrix);
            Console.WriteLine("Начальный массив: ");
            printMatrix(matrix);
            Console.WriteLine($"Сред. ариф. каждой строки: [{string.Join(", ", searchAvg(matrix, avgArray))}]");


        }
    }
}
