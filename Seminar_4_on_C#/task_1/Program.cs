// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Программа для вычисления кол-ва символов:");
Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine(), out int n);

int NumberSymbol (int n)
{
    int count = 0;
    while (n > 10)
    {
        n %= 10;
        count++;
    }
}

// int count = NumberSymbol(n);
// Console.WriteLine(count);

// Console.WriteLine();

// int NumberDigits(int num)
// {
//     if (num < 1)
//         return -1;
//     int ind = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         ind++;
//     }
//     return ind;
// }

// Console.WriteLine("Программа показывает количество цифр в ведённом числе.");
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//     Console.WriteLine("Введено число меньше 1. Выполнение программы прервано.");
//     return;
// }

// Console.WriteLine(NumberDigits(num));

// с логарифмом
// int CountNumbersN(int n)
// {
//      if (n == 0)
//          return 1;

//     int result = 0;

//     result = (int)Math.Log10(Math.Abs(n)) + 1;

//     //  while(n / 10 == 0) {
//     //         n /= 10;
//     //         result++;
//     //  } 

//     return result;  
// }

// Console.WriteLine("Программа вычисления количества цифр в числе:");
// Console.WriteLine("Введите число:");
// int.TryParse(Console.ReadLine(), out int n);
