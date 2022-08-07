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
// if (num2 < num1 && num3 < num1){
//     Console.Write("max = " + num1);
// }
// else{
//     if (num3 < num2 && num1 < num2){
//         Console.Write("max = " + num2);
//     }
//     else {
//         Console.Write("max = " + num3);
//     }
// }

// Задача 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0){
    Console.Write(num + " - четное число");
}
else {
    Console.Write(num + " - нечетное число");
}