
//№25

// Console.WriteLine("Введите первое число");
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите второе число");
// int n2 = Convert.ToInt32(Console.ReadLine());
// while (n2<1)
// {
//     if (n==0)
//         Console.WriteLine("Ваше первое число 0, введите другое число");
//         n = Convert.ToInt32(Console.ReadLine());
//     if (n2<1)
//         Console.WriteLine("Ваше второе число меньше 1-цы, введите другое число");    
//         n2 = Convert.ToInt32(Console.ReadLine());
// }
// int x = n;
// for (int i=1; i < n2; i++)
// {
//     n=n*x;
// }
// Console.WriteLine("1-е число в натуральной степени 2-го = "+n);    




//№27

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int SumNumber(int n)
// {
//     int counter = Convert.ToString(n).Length;
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++)
//     {
//         advance = n - n % 10;
//         result = result + (n - advance);
//         n = n / 10;
//     }
//    return result;
// }
// int sumnumber = SumNumber(n);
// Console.WriteLine("Сумма цифр в числе = "+ sumnumber);



//№29

// Console.WriteLine("Случайно заполненый массив из 8 элементов");
// int[] array = new int[8];
// Console.WriteLine("Определите диапазон для генерации чисел в массив");
// Console.Write(" ОТ: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write(" ДО: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Массив: ");
// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(x, y);
//     Console.Write("["+array[i]+"]"+" ");       
// }

