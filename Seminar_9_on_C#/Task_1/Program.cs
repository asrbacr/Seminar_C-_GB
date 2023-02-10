// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


//63
/*
int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}
System.Console.Write("Введите число: ");
int n = UserInput();

int PrintNumbers(int n)
{
    int[] array = new int[n];
    // array[0] = 1;
    array[n] = array[n - 1] + 1;
    return array;
}

int[] result = PrintNumbers(n);

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write(arr[arr.Length - 1]);
    // Console.WriteLine();
}

PrintArray(result);
*/

void PrintNumbers(int N)
{
    if (N <= 0)
    {
        return;
    }
    if (N == 1)
    {
        System.Console.WriteLine($"{N}");
    }
    else
    {
        PrintNumbers(N - 1);
        System.Console.WriteLine($", {N}");
    }
}

//2 задача
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void PrintNumber(int M, int N)
{
    if (M > N)
    {
        PrintNumber(M - 1, N);
        Console.Write($", {M}");
    }
    else if (M < N)
    {
        PrintNumber(M, N - 1);
        Console.Write($", {N}");
    }
    else if (M == N)
    {
        Console.Write($"{M}");
    }
}

int GetNumber()
{
    Console.Write($"Введите значение числа: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

int M = GetNumber();
int N = GetNumber();
PrintNumber(M, N);

