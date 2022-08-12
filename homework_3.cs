// Задача 19
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine() ??"");
// if (num > 99999 || num < 10000)
// {
//     Console.Write("Введено неверное число!"); return;
// }
// if (num / 10000 != num % 10 )
// {
//     Console.Write("Введенное число не является палиндромом");
// }
// else if ((num / 1000) % 10 != (num % 100) / 10)
// {
//     Console.Write("Введенное число не является палиндромом");
// }
// else
// {
//     Console.Write($"Число {num} является палиндромом");
// }

// Решение 19 задачи при помощи массива
// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// char[] array = Math.Abs(num).ToString().ToCharArray();
// int index = 0;
// while (index < array.Length/2)
// {
//     if (array[index] != array[array.Length - index - 1])
//     {
//         Console.Write($"Число {num} НЕ является палиндромом"); return;
//     }
//     index++;
// }
// Console.Write($"Число {num} является палиндромом");

// Задача 21
// Console.Clear();
// Console.WriteLine("Введите поочередно координаты первой точки: ");
// int x1 = int.Parse(Console.ReadLine() ?? "0");
// int y1 = int.Parse(Console.ReadLine() ?? "0");
// int z1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите поочередно координаты второй точки: ");
// int x2 = int.Parse(Console.ReadLine() ?? "0");
// int y2 = int.Parse(Console.ReadLine() ?? "0");
// int z2 = int.Parse(Console.ReadLine() ?? "0");
// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z1-z2, 2));
// Console.Write($"d = {d:f2}");

// Задача 23
// Console.Clear();
// Console.Write("put the number: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int count = 1;
// while (count <= num)
// {
//     Console.Write($"|{Math.Pow(count++, 3)}| ");
// }