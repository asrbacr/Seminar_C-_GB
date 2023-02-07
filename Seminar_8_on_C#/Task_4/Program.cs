//треугольник Паскаля
// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника



int[,] array = new int[8, 11];
{
    array[i, array.GetLength(1) / 2] = 1;
    System.Console.Write(array[i, array.GetLength(1) / 2]);
    array[i + 1, array.GetLength(1) / 2 - 1] = 1;
    array[i + 1, array.GetLength(1) / 2 + 1] = 1;

    for (int i = 2; i < array.GetLength(0); i++)
    {

        for (int j = array.GetLength(1) / 2 - i; j < array.GetLength(1); j++)
        {

            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
        for (int j = array.GetLength(1) / 2 + i; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}

//_____ из чата

// Рисуем треугольник паскаля

int row = 10;
int[,] triangle = new int[row, row];
const int cellWidth = 5;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    int col = cellWidth * row; 
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i +1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j], cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i+1);
        Console.WriteLine();
    }
}

FillTriangle();
PrintTriangle();

//____это актавиуса


//ДЗ
// 54