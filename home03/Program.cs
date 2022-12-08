// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int resalt = number%2;

if (resalt == 0)
{
    Console.WriteLine("Число четное");
}

else
{
    Console.WriteLine("Число нечетное");
}
