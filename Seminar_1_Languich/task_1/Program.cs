Console.Write("Введите 2 числа, для проверки является ли первое квадратом второго ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

a = a / b;

if (a == b)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}