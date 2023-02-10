// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SummNum(int n)
{
    if (n < 10) return n;

    //if (n == 0 || n == 1) return 1;

    return n += SummNum(n) % 10;
}
int n = 7;
System.Console.WriteLine($"Сумма {n}: ");

// Задача 67. Находим сумму цифр


Console.WriteLine("Введите число N");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}


int SumsOfNumbers(int n)
{
    if (n < 1) return 0;
    return n = (n % 10) + SumsOfNumbers(n / 10);
}

Console.WriteLine(SumsOfNumbers(n));

//69 тело степень числа через 

int AinB(int a, int b)
{
    if (b == 1) return a;
    if (b == 0) return 1;
    return AinB(a, b - 1) * a;
}

//с отрицательной степенью
double PowNumbers(double numA, double numB)
{
    if (numB == 1)
    {
        return numA;
    }
    else if (numB == 0)
    {
        return 1;
    }
    else if (numB < 0)
    {
        return 1 / PowNumbers(numA, Math.Abs(numB));
    }
    else
    {
        return numA * PowNumbers(numA, numB - 1);
    }
}
