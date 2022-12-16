// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа через пробел: ");
// int[] array = StringToNum(Console.ReadLine());
// PrintArray(array);
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество чисел больше 0 = "+sum);

// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ' ')
//         {
//             count++;
//         }
//     }

//     int[] array = new int[count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ' ')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         array[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("[ "+array[i] + " ]"+" ");
//     }
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// double b1 = ReadTerminal("Введите b1: ");
// double k1 = ReadTerminal("Введите k1: ");
// double b2 = ReadTerminal("Введите b2: ");
// double k2 = ReadTerminal("Введите k2: ");
 
// double x = (b2-b1)/(k1-k2);
// double y = k1*(b2-b1)/(k1-k2)+b1;
 
// x = Math.Round(x, 1);
// y = Math.Round(y, 1);
 
// Console.WriteLine("Точка пересечения на X: "+x +"  Y: "+y);

// double ReadTerminal(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToDouble(Console.ReadLine());
// }