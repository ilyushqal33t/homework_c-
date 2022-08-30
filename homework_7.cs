void FillArray(int[,] array, int min, int max)
{
     Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }    
}
// Задача 47
// int[,] array = new int[3,4];
// FillArray(array, -10, 10);
// PrintArray(array);

// Задача 50
// bool CheckPosition(int[,] array, int row, int column)
// {
//     return row >= 0 && row < array.GetLength(0) && 
//         column >= 0 && column < array.GetLength(1);
// }

// int[,] array = new int[3,4];
// FillArray(array, -10, 10);
// PrintArray(array);
// Console.Write("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine() ?? "0") - 1; // Вычитаем 1, чтобы прейти от индекса 0 к 1
// Console.Write("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine() ?? "0") - 1; // Вычитаем 1, чтобы прейти от индекса 0 к 1
// if (CheckPosition(array, row, column)) 
//     Console.WriteLine($"Элемент на введенной позиции имеет значение {array[row,column]}");
// else 
//     Console.WriteLine("Введена позиция несуществующего элемента!");

// Задача 52
// int[,] array = new int[3,4];
// FillArray(array, -10, 10);
// PrintArray(array);
// Console.Write(String.Join("     ", CalculateAverage(array)));

// double[] CalculateAverage(int[,] array)
// {
//     double[] avrg = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i,j];    
//         }
//         avrg[j] = (double)sum/array.GetLength(0);
//     }
//     return avrg;
// }