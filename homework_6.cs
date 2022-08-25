// Задача 41
// Console.Clear();
// Console.Write("Введите несколько чисел через пробел: ");
// string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
// int count = 0;
// for (int i = 0; i < st.Length; i++)
// {
//     if (int.Parse(st[i]) > 0)
//     {
//         count++;
//     }
// }
// Console.Write($"Среди введенных чисел {count} чисел(ла) больше нуля");


// Задача 43
// double CalculateX(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1)/(k1-k2);
//     return x;
// }

// double CalculateY(double b1, double k1, double b2, double k2)
// {
//     double y = k1*((b2-b1)/(k1-k2)) + b1;
//     return y;
// }

// Console.Write("b1: ");
// double b1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("k1: ");
// double k1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("b2: ");
// double b2 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("k2: ");
// double k2 = double.Parse(Console.ReadLine() ?? "0");
// if (k1 == k2)
// {
//     Console.Write("Прямые параллельны"); return;
// }
// double x = CalculateX(b1, k1, b2, k2);
// double y = CalculateY(b1, k1, b2, k2);
// Console.Write($"Точка пересечения прямых двух прямых: x ={x}, y ={y}");

// Задача 42
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// Console.Write($"{num} в двоичной системе = ");
// string res = Convert.ToString(num%2);
// while (num/2 != 0)
// {
// num /= 2;
// res = num%2 + res;
// }
// Console.Write(res);

// Задача 44
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int[] array = new int[num];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < array.Length; i++)
// {
//     array[i] = array[i -1] + array[i -2];
    
// }
// Console.Write($"{String.Join(", ", array)}");

// Задача 45
// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
// }
// int[] CopyArray(int[] source)
// {
//     int[] array = new int[source.Length];
//     for (int i = 0; i < source.Length; i++)
//     {
//         array[i] = source[i];
//     }
//     return array;
// }

// Console.Write("Введите длину случайного массива: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// int[] source = new int[size];
// FillArray(source, -10, 10);
// Console.WriteLine($"Копируемый массив: [{String.Join(", ",source)}]");
// int[] dist = CopyArray(source);
// Console.WriteLine($"Скопированный массив: [{String.Join(", ",dist)}]");