

// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
//  (можно использовать готовую функцию)



// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, m];
// FillArray(array);
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);
// NumbersMaxToMin(array);

// void FillArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             array[j, i] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[j, i] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }
// void NumbersMaxToMin(int[,] array)
// {
//   for (int j = 0; j < array.GetLength(0); j++)
//   {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[j, k] < array[j, k + 1])
//         {
//           int temp = array[j, k + 1];
//           array[j, k + 1] = array[j, k];
//           array[j, k] = temp;
//         }
//       }
//     }
//   }
// }

// Console.WriteLine();
// Console.WriteLine("Упорядоченный массив:");
// PrintArray(array);  



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.


// int[,] array = new int[6, 5];
// FillArray(array);
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);
// MaxLineSumm(array);

// void FillArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             array[j, i] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[j, i] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }
// void MaxLineSumm(int[,]array)
// {
//     int min = Int32.MaxValue;
//     int minline = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         int summ = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             summ +=array[j,i];
//         }
//         Console.WriteLine($"Сумма элементов в строке {j+1} = ({summ})");
//         if(min > summ)
//         {
//             min = summ;
//             minline = j+1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Минимальная сумма элементов в строке {minline} ({min})");
// }





// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// int[,] firstMartrix = new int[5, 5];
// FillArray(firstMartrix);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[5, 10];
// FillArray(secomdMartrix);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] matrixResult = new int[5,10];

// MatrixProduct(firstMartrix, secomdMartrix, matrixResult);
// Console.WriteLine("Произведение матриц:");
// PrintArray(matrixResult);

// void FillArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             array[j, i] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[j, i] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// void MatrixProduct(int[,] firstMartrix, int[,] secomdMartrix, int[,] matrixResult)
// {
//   for (int j = 0; j < matrixResult.GetLength(0); j++)
//   {
//     for (int i = 0; i < matrixResult.GetLength(1); i++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[j,k] * secomdMartrix[k,i];
//       }
//       matrixResult[j,i] = sum;
//     }
//   }
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


// Console.WriteLine("Введите размер массива X  Y  Z:");
// Console.WriteLine("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] array3D = new int[x, y, z];
// Fill3DArray(array3D);
// PrintArray(array3D);

// void PrintArray (int[,,] array3D)
// {
//   for (int j = 0; j < array3D.GetLength(0); j++)
//   {
//     for (int i = 0; i < array3D.GetLength(1); i++)
//     {
//       Console.Write($"X({j}) Y({i}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[j,i,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void Fill3DArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int j = 0; j < temp.GetLength(0); j++)
//   {
//     temp[j] = new Random().Next(10, 100);
//     number = temp[j];
//     if (j >= 1)
//     {
//       for (int i = 0; i < j; i++)
//       {
//         while (temp[j] == temp[i])
//         {
//           temp[i] = new Random().Next(10, 100);
//           i = 0;
//           number = temp[j];
//         }
//           number = temp[j];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }




// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.


// int n = 9;
// int[,] SpiralMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
// {
//   SpiralMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(SpiralMatrix);

// void PrintArray (int[,] array)
// {
//   for (int j = 0; j < array.GetLength(0); j++)
//   {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//       if (array[j,i] / 10 <= 0)
//       Console.Write($" {array[j,i]} ");

//       else Console.Write($"{array[j,i]} ");
//     }
//     Console.WriteLine();
//   }
// }