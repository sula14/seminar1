﻿// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число >");
string value;
value = Console.ReadLine();
int a = Convert.ToInt32(value);

if (a % 2 == 0)
{
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");