// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.Write("Введите длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 )
// {
//     Console.Write("Массив не может быть меньше 1-цы. Введите большую длину массива: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int[] array = new int[n];
// FillArrayRandomNumbers(array);
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);
// void FillArrayRandomNumbers(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("["+array[i]+"] ");
//     }
// }
// int CountPosNum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//         CountPosNum++; 
// }
// Console.WriteLine();
// Console.WriteLine("Количество четных чисел в массиве = "+CountPosNum);





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 )
// {
//     Console.Write("Массив не может быть меньше 1-цы. Введите большую длину массива: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int[] array = new int[n];
// FillArrayRandomNumbers(array);
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Элементы массива с нечетной позицией:");
// PrintNotEvenPos(array);
// void FillArrayRandomNumbers(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }
// }
// Console.WriteLine();
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write("["+array[i]+"] ");
//     }
// }
// void PrintNotEvenPos(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     if (i % 2 != 0)
//         Console.Write("["+array[i]+"] ");
//     }
// }
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//      if (i % 2 != 0)
//         sum = sum + array[i];
// }
// Console.WriteLine();
// Console.WriteLine("Сумма элементов с нечетной позицией = "+sum);





// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->100


// Console.Write("Введите длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 )
// {
//     Console.Write("Массив не может быть меньше 1-цы. Введите большую длину массива: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// double[] array = new double[n];
// FillArrayRandomNumbers(array);
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//         {
//             max = array[i];
//         }
//     if (array[i] < min)
//         {
//             min = array[i];
//         }
// }
// Console.WriteLine();
// Console.WriteLine("Минимальный элемент = ["+min+"]");
// Console.WriteLine("Максимальный элемент = ["+max+"]");
// Console.WriteLine("Их сумма = "+(min+max));
// void FillArrayRandomNumbers(double[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToDouble(new Random().Next(1, 100));
// }
// }
// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write("["+array[i]+"] ");
//     }
// }

