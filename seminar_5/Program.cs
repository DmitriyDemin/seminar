// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// 15 мин
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
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
                        matrix[i, j] = new Random().Next(50, 101);
                    }

                }
            }

            void printMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} \t"); /*\t - табуляция \n -  переход на новую строку*/
                    }
                    Console.WriteLine();
                }
            }
            void replaceElements(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i += 2)
                { // i++ <=> i = i + 1
                    for (int j = 0; j < matrix.GetLength(1); j += 2)
                    {
                        matrix[i, j] *= matrix[i, j];
                    }
                }
            }
            Console.Write("Введите размеры двумерного массива:  ");
            int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            inputMatrix(matrix);
            Console.WriteLine("Начальный массив: ");
            printMatrix(matrix);
            replaceElements(matrix);
            Console.WriteLine("\nКонечный массив: ");
            printMatrix(matrix);
          
            // преложила Илона
            // double[] array;
            // if (args.Length >= 1)
            // {
            //     // Объединяем все аргументы командной строки в одну строку
            //     string joinedArgs = String.Join(" ", args);

            //     // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            //     array = joinedArgs.Split(", ").Select(double.Parse)
            //     .ToArray();
            //     // Теперь arr содержит преобразованные в целые числа из командной строки

        }
    }
}

