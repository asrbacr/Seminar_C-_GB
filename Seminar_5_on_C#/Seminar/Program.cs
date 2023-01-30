// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int SumPositiveElements(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0)
            result += array[i];
    }

    return result;
}

int SumNegativeElements(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] < 0)
            result += array[i];
    }

    return result;
}


int[] array = GenerateArr(12, -9, 9);
PrintArray(array);

int positiveSum = SumPositiveElements(array);
int negativeSum = SumNegativeElements(array);

Console.WriteLine($"Сумма положительных элементов в массиве: {positiveSum}");
Console.WriteLine($"Сумма отрицательных элементов в массиве: {negativeSum}");

//_______ДЗ

//34 задача, заполнить случ.числами и счётчик по условию

//36 в цикле считать -1. или +2

//38 разницу между мин и макс эл-тами. вещественные числа.