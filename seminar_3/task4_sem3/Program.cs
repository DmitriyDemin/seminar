// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 
// Console.Write("Введите натурольное трехзначное число: ");
// string number = Console.ReadLine()!;
// int n = int.Parse(Console.ReadLine()!);
// int arrey = new int(number.Length);

// for (int i=0; i<number.Length; i++)
// {
//     if 
// }
//     if


Console.Clear();
int n = 456;
int[] array = new int[3];
array[0] = n % 10;
array[1] = (n % 100) / 10;
array[2] = n / 100;
Console.WriteLine($"[{string.Join(" ", array)}]");