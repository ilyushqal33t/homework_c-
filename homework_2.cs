// Задача 10
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 || num > 999)
// {
//     Console.WriteLine("Введено не трехзначное число!"); 
// }
// else 
// {
//     Console.WriteLine($"Вторая цифра введенного числа: {(num / 10) % 10}");
// }

// Задача 13
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// char[] array = Math.Abs(num).ToString().ToCharArray();
// Console.WriteLine(array.Length > 3 ? $"Третья цифра введенного числа: {array[2]}": "Третьей цифры нет");

// Задача 15
// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7)
// {
//     Console.Write("Несуществующий день недели!");
// }
// else 
// {
//     Console.Write(day == 6 || day == 7? "Выходной день": "Рабочий день");
// }

// Console.Write("Input random number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(Math.Abs(num) < 100)
// { 
//     Console.Write("There is no third digit");
// }

// else
// {
//     while(Math.Abs(num) >= 1000)
//     {
//         num = num/10;
//     }
//     Console.Write(Math.Abs(num = num%10));
// }