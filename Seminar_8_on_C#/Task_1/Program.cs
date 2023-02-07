// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



void PrintArray2D(int[,] array) //вывод
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateArray(int m, int n, int min, int max) //генерация
{
    int[,] arrNum = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < arrNum.GetLength(0); i++)
    {
        for (int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = random.Next(min, max + 1);
        }
    }
    return arrNum;
}

int[,] array = GenerateArray(3, 4, 1, 9);
PrintArray2D(array);
System.Console.WriteLine();
//1 2 3
//4 5 6
//7 8 9

/*
void ReplaceRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int arr = array[0, j];
            array[0, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = arr;
        }
    }
}

ReplaceRows(array);
PrintArray2D(array);
// int t = array[i] 
*/

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] array = GenerateArray(3, 4, 1, 9);


int[,] SwapArray2d(int[,] oldArray)
{
    int[,] newArray = new int[oldArray.GetLength(1), oldArray.GetLength(0)];
    for (int i = 0; i < oldArray.GetLength(1); i++)
    {
        for (int j = 0; j < oldArray.GetLength(0); j++)
        {
            newArray[i, j] = oldArray[j, i];
        }
    }
    return newArray;
}

