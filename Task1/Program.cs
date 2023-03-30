// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите числа >");
string value;
value = Console.ReadLine();
int a = Convert.ToInt32(value);
string value2;
value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);

if (a > b)
{
    System.Console.Write("max = ");
    System.Console.Write(a);
}
else
    System.Console.Write("max = ");
    System.Console.Write(b);