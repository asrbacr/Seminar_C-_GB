// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] RevertArray(int[] array) {
    int[] result = new int[array.Length];

    for(int i = 0; i < array.Length; i++) {
        result[array.Length - i - 1] = array[i];
    }

    return result;
}


int[] array = GenerateArr(12, -9, 9);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);

int[] result = RevertArray(array);
Console.WriteLine("Перевёрнутый массив");
PrintArray(result);


//----
//41 сколько больше 0?  ввести со строки. попробовать

//43 расстояние между точками
// (int, bool) func() {
//     return (9, true);
// }

// int a;
// bool b;

// (a, b) = func();

(int, bool) func() {
    return (9, true);
}

(int a, bool b) = func();
