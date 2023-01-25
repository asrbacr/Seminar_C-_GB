// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumFromOneToN(int n)
{
    if (n < 1)
        return -1;

    int result = 0;

    int counter = 1;

    while(counter <= n) {
        result += counter;
        counter++;
    }

    return result;  
}

Console.WriteLine("Программа вычисления суммы чисел от 1 до N:");
Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine(), out int n);

if (n < 1) {
    Console.WriteLine("Число должно быть положительным");
    return;
}

int result = SumFromOneToN(n);
Console.WriteLine($"Результат: {result}");