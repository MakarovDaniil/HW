

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.


// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// SumOfRangeElements(m,n);
// int SumOfRangeElements(int m, int n)
// {
// 	int start = m;
// 	int end = n;
// 	if(m > n)
// 	{
// 		start = n;
// 		end = m;
// 	}
// 	return (end + start)*(end - start + 1)/2;
// }
// Console.WriteLine($"Сумма натуральных элементов в диапазоне от {m} до {n} = {SumOfRangeElements(m,n)}");






// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Вычисление функции Аккермана");
// Console.WriteLine();
// Console.WriteLine("Введите первое число в диапазоне от 0 до 3: ");
// int m = Convert.ToInt32(Console.ReadLine());
// while(m<0 ||m>3)
// {
//     Console.WriteLine("Недопустимое число. Введите число в диапазоне от 0 до 3: ");
//     m = Convert.ToInt32(Console.ReadLine());
// }
// int n = 0;
// if (m < 2)
// {
//     Console.WriteLine("Введите второе число в диапазоне от 0 до 19269: ");    ///Дальше переполняется стек
//     n = Convert.ToInt32(Console.ReadLine());
//         while(n<0 || n>19269)
//     {
//         Console.WriteLine("Недопустимое число. Введите число в диапазоне от 0 до 19269: ");
//         n = Convert.ToInt32(Console.ReadLine());
//     }
// }

// if (m == 2)
// {
//     Console.WriteLine("Введите второе число в диапазоне от 0 до 9632: ");
//     n = Convert.ToInt32(Console.ReadLine());
//         while(n<0 || n>9632)
//     {
//         Console.WriteLine("Недопустимое число. Введите число в диапазоне от 0 до 9632: ");
//         n = Convert.ToInt32(Console.ReadLine());
//     }
// }
// if (m == 3)
// {
//     Console.WriteLine("Введите второе число в диапазоне от 0 до 11: ");
//     n = Convert.ToInt32(Console.ReadLine());
//     while(n<0 || n>11)
//     {
//         Console.WriteLine("Недопустимое число. Введите число в диапазоне от 0 до 11: ");
//         n = Convert.ToInt32(Console.ReadLine());
//     }
// }

// AkkermanFunction(m,n);

// Console.WriteLine($"A(m,n) = {AkkermanFunction(m,n)}");

// int AkkermanFunction(int m, int n)	
// {
// 	if(m == 0)
// 	{
// 		return n + 1;
// 	}
// 	if(m > 0 && n == 0)
// 	{
// 		return AkkermanFunction(m - 1, 1);
// 	}
// 	return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }
		



