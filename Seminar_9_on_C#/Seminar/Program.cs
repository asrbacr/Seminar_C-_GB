//Тема Рекурсия

// Функция  - это выполнение действия. Рекурсия это действие 
// принт Н + принт Н до Н-1

// задача на факториал

int Factorial(int n)
{
    if (n < 0) return -1;

    if (n == 0 || n == 1) return 1;

    return n * Factorial(n - 1);
}
int n = 7;

System.Console.WriteLine($"Факториал {n}: {Factorial(n)}");

//ДЗ функция аккермана