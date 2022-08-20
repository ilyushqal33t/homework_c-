int[] FillArray(int[] array, int min, int max)  //Функция написана для задач, находящихся ниже
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// Задача 34
// int[] array = new int[4];
// FillArray(array, 100, 999);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.Write($"В массиве {count} четных чисел(ла)");

// Задача 36
// int[] array = new int[4];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int sum = 0;
// for(int i = 1; i < array.Length; i+=2)
// {
//     sum += array[i];
// }
// Console.Write($"Сумма элементов, стоящих на нечетных позициях равна {sum}");

// Задача 38
// int[] array = new int[8];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int min = 0;
// int max = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.Write($"Разница между максимальным и минимальным элементом массива равна {max - min}");