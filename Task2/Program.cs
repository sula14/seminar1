// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите числа >");
string value;
value = Console.ReadLine();
int a = Convert.ToInt32(value);
string value2;
value2 = Console.ReadLine();
int b = Convert.ToInt32(value2);
string value3;
value3 = Console.ReadLine();
int с = Convert.ToInt32(value3);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

System.Console.Write("max = ");
System.Console.Write(max);

