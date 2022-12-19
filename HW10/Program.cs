

// Задача 47. Задайте двумерный массив (вручную)
// размером m×n, заполненный вещественными числами

// double[,] array = new double[2,10];
// FillArray (array);
// PrintArray(array);
// void FillArray (double[,]array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i  = 0; i < array.GetLength(1); i++)
//         {
//             array[j,i] = Convert.ToDouble(new Random().Next(-99, 100))/10;
//         }
//     }
// }
// void PrintArray(double[,] array)
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


// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном 
// массиве, и возвращает индекс этого элемента или же указание, что такого элемента нет.
//  Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.

// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [3,10];
// FillArray(array);

// if (n > array.GetLength(0) || m > array.GetLength(1))
// {
//     Console.WriteLine("нет такого элемента");
// }
// else
// {
//     Console.WriteLine($"Искомый элемент = {array[n-1,m-1]}");
// }

// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//         {        
//             for (int i = 0; i < array.GetLength(1); i++)
//             {
//                 array [j,i] = new Random().Next(-100, 100);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[j,i] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(); 
//     }
// }



// Задача 52. Задайте двумерный массив (вручную) из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.



// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [n,m];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine("Среднеарифметическое столбцов: ");
// FindAvgValOfColumns(array);
// void FillArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//         {        
//             for (int i = 0; i < array.GetLength(1); i++)
//             {
//                 array [j,i] = new Random().Next(1, 10);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Console.Write("[ ");
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             Console.Write(array[j,i] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(); 
//     }
// }
// void FindAvgValOfColumns(int[,]array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double average = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             average = (average+array[i,j]);
//         }
//         average = average/n;  
//         average = Math.Round(average, 1);
//         Console.Write(average+ "   ");
//     }
// }