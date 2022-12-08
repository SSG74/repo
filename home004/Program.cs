// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;


while (b <= a)
{
    Console.WriteLine(b);
    b+=2;
}