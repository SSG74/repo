// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} является большим, число {b} является меньшим");
}

else
{
    Console.WriteLine($"Число {b} является большим, число {a} является меньшим");
}