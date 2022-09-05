// void FillArray(int[,] array, int min = 1, int max = 10)
// {
//      Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = rnd.Next(min, max + 1);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }    
// }

// Задача 54
// int[,] FormatArray(int[,] array)
// {
//     int indexMax = 0;
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int columns = 0; columns < array.GetLength(1); columns++)
//         {
//             indexMax = columns;
//             for (int j = columns; j < array.GetLength(1); j++)
//             {
//                 if (array[row, j] > array[row, indexMax])
//                 {
//                     indexMax = j;
//                 }
//             }

//             if (array[row, indexMax] == array[row, columns])
//                 continue;

//             int temp = array[row, columns];
//             array[row, columns] = array[row, indexMax];
//             array[row, indexMax] = temp;
//         }
//     }
//     return array;
// }
// int[,] array = new int[3,4];
// FillArray(array, 1, 10);
// PrintArray(array);
// FormatArray(array);
// Console.WriteLine();
// PrintArray(array);

// Задача 56
// int[] FindSums(int[,] array)
// {   
//     int sum = 0;
//     int[] sums = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         sums[i] = sum;
//     }
//     return sums;
// }

// int FindStringMinSum (int[]array)
// {
//     int min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < min) min = array[i];
//     }
//     return min;
// }

// int[,] array = new int[4,4];
// FillArray(array, 1, 10);
// PrintArray(array);
// int[] sumsArray = FindSums(array);
// int min = FindStringMinSum(sumsArray);
// for (int i = 0; i < sumsArray.Length; i++)
// {
//     if (sumsArray[i] == min)
//     {
//         Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i + 1}");
//     }
// }

// Задача 58
// int[,] MultipleMatrix(int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0 ; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixB.GetLength(0); k++)
//             {
//                 matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
//             }
//         }
//     }
//     return matrixC;
// }

// int[,] matrixA = new int[2,2];
// int[,] matrixB = new int[2,2];
// FillArray(matrixA);
// PrintArray(matrixA);
// Console.WriteLine();
// FillArray(matrixB);
// PrintArray(matrixB);
// Console.WriteLine();
// PrintArray(MultipleMatrix(matrixA, matrixB));

// Задача 60

// void FillThreeDimensionalArray(int[,,] myArray, int min = 1, int max = 10)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < myArray.GetLength(2); k++)
//             {
//                 myArray[i,j,k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
// }

// void PrintThreeDimensionalArray(int[,,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < myArray.GetLength(2); k++)
//             {
//                 Console.Write($"{myArray[i,j,k]} ({i}, {j}, {k})\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] myArray = new int[2,2,2];
// FillThreeDimensionalArray(myArray);
// PrintThreeDimensionalArray(myArray);