// (int, int) InputNumbers()
// {
//     int num1;
//     int num2;
//     while (true)
//     {
//         Console.Write("Введите первое натурально число: ");
//         num1 = int.Parse(Console.ReadLine()!);
//         if (num1 < 0)
//         {
//             Console.WriteLine("Введено не натуральное число!"); continue;
//         }
//         break;
//     }

//     while (true)
//     {
//         Console.Write("Введите второе натуральное число: ");
//         num2 = int.Parse(Console.ReadLine()!);
//         if (num2 < 0)
//         {
//             Console.WriteLine("Введено не натуральное число!"); continue;
//         }
//         break;
//     }
//     return (num1, num2);
// }
// Задача 65
// void PrintNumbers(int num1, int num2)
// {
//     while(num1 <= num2)
//     {
//         Console.Write($"{num1}" + (num1 < num2 ? ", " :""));
//         num1++;
//     }
// }

// (int num1, int num2) = InputNumbers();
// PrintNumbers(num1, num2);

// Задача 66
// int PrintNumbers(int num1, int num2)
// {   
//     int sum = 0;
//     while(num1 <= num2)
//     {
//         sum += num1;
//         num1++;
//     }
//     return sum;
// }
// (int num1, int num2) = InputNumbers();
// Console.WriteLine();
// Console.Write($"Сумма натуральных натуральных элементов в промежутке от {num1} до {num2}: " +
//                                                                          PrintNumbers(num1, num2));

// Задача 68
// int Ack(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ack(m - 1, 1);
//     }
//     else
//     {
//         return Ack(m - 1, Ack(m, n - 1));
//     }
// }
// (int num1, int num2) = InputNumbers();
// Console.Write(Ack(num1,num2));