// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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



int[,] array = GenerateArray(3, 4, 0, 8);
PrintArray2D(array);
System.Console.WriteLine();
CountElements(array);

void CountElements(int[,] array)
{
    for (int k = 0; k < array.Length - 1; k++)
    {
        int countK = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == k)
                {
                    countK += 1;
                }
            }
        }
        if (countK == 0) continue;

        Console.WriteLine($"{k} повторяется {countK} раз");
    }
}

//foreach
foreach (var i in array)
{
    System.Console.Write($"{i}, ");    
}