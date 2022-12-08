// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (b > a)
max = b;
if (c > b)
max = c;
Console.WriteLine(max);