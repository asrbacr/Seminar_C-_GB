// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int N = getVar();
System.Console.WriteLine(multipler(N));

// --- FUNCs --- //
int multipler(int N)
{
    int outNum = 1;
    for (int i = 1; i < N + 1; i++)
    {
        outNum *= i;
    }

    return outNum;
}

int getVar()
{
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric)
    {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        if (varValue < 0)
        {
            isNumeric = false;
        }
    }

    return varValue;
}

//верхнее значение !13
