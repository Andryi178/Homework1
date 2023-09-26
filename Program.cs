// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//System.Console.WriteLine("Введите первое число");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите воторое число");
//int b = Convert.ToInt32(Console.ReadLine());

//if(a > b)
//{
//    System.Console.WriteLine("Большее число: + a + Меньшее число: + b");
//}
//else
//System.Console.WriteLine($"Большее число: {b}, меньшее число:{a}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите воторое число");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;

// System.Console.Write("max = ");
// System.Console.WriteLine(max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// делится ли оно на два без остатка.
// 4 -> да
// -3 -> нет
// 7 -> нет


// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if ( n % 2 == 0)
// {
//    System.Console.WriteLine("Введенное число являетяс четным");
// }
// else
// {
//   System.Console.WriteLine("Введенное число является нечетным");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System.Collections.Concurrent;

System.Console.WriteLine("Вводим число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
m = 1;
while (m <= n)
{
    if (m % 2 == 0)
    System.Console.WriteLine("Вывести четные числа");
}

// я не смог решить эту задачу.