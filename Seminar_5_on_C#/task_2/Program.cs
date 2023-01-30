// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
//  элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = GenerateArr(5, -9, 9);

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

PrintArray(array);

int[] MultiArray(int[] array)
{
    int[] result = new int[array.Length / 2 + 1];
    for (int i = 0, j = array.Length - 1; i <= array.Length / 2; i++, j--)
    {
        if (array.Length % 2 == 0)
            result[i] = array[i] * array[j];
            // System.Console.WriteLine(result[i]);
        else if (i != array.Length / 2 + 1)
            result[i] = array[i] * array[j];
        // else (i == array.Length / 2 + 1)
        else
            result[result.Length] = array[i];
    }
    return result;
}

PrintArray(MultiArray(array));

//_______

int[] numsArr = generateArr(6, 1, 9);
int outArrLength = numsArr.Length / 2 + numsArr.Length % 2;
int[] outNumsArr = new int[outArrLength];

printArr(numsArr);
for (int i = 0; i < outArrLength; i++) {
    int j = numsArr.Length-i-1;
    if (i < outArrLength-1){
       outNumsArr[i] = numsArr[i] * numsArr[j];
    } else {
       outNumsArr[i] = numsArr[i];
    }
}
printArr(outNumsArr);