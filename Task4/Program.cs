﻿// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число >");
string value;
value = Console.ReadLine();
int N = Convert.ToInt32(value);
int num = 2;

while (num <= N)
{
    if (num % 2 == 0)
    {
        System.Console.WriteLine(num);
    }
    num+=2;
}
