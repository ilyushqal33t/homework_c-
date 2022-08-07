// Задача 2
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 > num1){
//     Console.Write("max = " + num2 + 
//     " min = " + num1);
// }
// else{
//     Console.Write("max = " + num1 +
//     " min = " + num2);
// }

// Задача 4
// Console.WriteLine("Введите поочередно 3 числа ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num2 < num1 && num3 < num1)
// {
//     Console.Write("max = " + num1);
// }
// else if (num3 < num2 && num1 < num2)
//     {
//         Console.Write("max = " + num2);
//     }
//     else
//     {
//         Console.Write("max = " + num3);
//     }

// Задача 6
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0){
//     Console.Write(num + " - четное число");
// }
// else {
//     Console.Write(num + " - нечетное число");
// }

//Задача 8
// Console.WriteLine("enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (num > 0)
// {
//     while (count < num)
//     {
//         count += 2;
//         Console.Write(count + (count + 2 <= num ? ", " : ""));
//     }
// }
// else 
// {
//     while (count > num)
//     {
//         count -= 2;
//         Console.Write(count + (count - 2 >= num ? ", " : ""));
//     }
// }

//  Необязательные задачи
// Задача 5
// Console.WriteLine("enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// int right = num > 0 ? num: -num; // right - N
// int left = -right;               // left - -N
// while (left <= right)
// {
//     Console.Write(left++ + (left <= right ? ", " : ""));
// }

// Задача 7
// Console.WriteLine("enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("result " + Math.Abs(num) % 10);