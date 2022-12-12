

// №19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет,
//  является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());


// while (n<10000 || n>99999) 
// {
//     if (n<10000)
//         Console.WriteLine("Ваше число меньше, введите пятизначное число");
//     if (n>99999)
//         Console.WriteLine("Ваше число больше, введите пятизначное число");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// string num = n.ToString();

// char [] array = num.ToCharArray();
// if (array[0]==array[4] && array[1]==array[3])
// {
//     Console.WriteLine(n+" является палиндромом");
// }
// else 
// {
// Console.WriteLine(n+" не является палиндромом");
// }




// №23
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i=0;i<n+1;i++)
// {
//     array[i] = n -(n-(i+1));
//     Console.WriteLine(array[i]*array[i]*array[i]);
// }




// №21
// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// double Solution(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
// }
// double segmentLength =  Math.Round (Solution(x1, x2, y1, y2, z1, z2), 2 );
// Console.WriteLine($"Расстояние между точками = {segmentLength}");