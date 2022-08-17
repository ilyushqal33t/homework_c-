// Задача 25
// Console.Write("Введите первое число: ");
// int numA = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите второе число: ");
// int numB = int.Parse(Console.ReadLine() ?? "0");
// int res = 1;
// for (int i = 0; i < numB; i++)
// {
//     res *= numA;
// }
// Console.Write($"{numA}^{numB} = {res}");

// Задача 27
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// char[] array = Math.Abs(num).ToString().ToCharArray();
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     int convert = int.Parse(array[i].ToString());  // int convert = array[i] - '0'; - второй вариант  
//     sum = sum + convert;
// }
// Console.Write($"Сумма цифр в числе {num} = {sum}");

// Задача 29
// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(0, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}" + (i < array.Length - 1 ? ", " : ""));
//     }
//     Console.Write("]");
// }

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);