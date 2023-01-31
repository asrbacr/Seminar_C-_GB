// Решение в группах задач:
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

//Fn = Fn–2 + Fn–1, где F0=0, F1=1


System.Console.WriteLine("кол-во: ");
int array = 8;

int[] CopyArray(int[] array)
{
    int copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}
GenArray(array);
int[] Copyarray = CopyArray(array);
PrintArray(Copyarray);

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

/*
printArr(array);
printArr(CopyArray(array));
*/

//________-- 4

System.Console.WriteLine();
int[] Fibonach(int number)
{
    int[] arrayFib = new int[number];
    arrayFib[0] = 0;
    arrayFib[1] = 1;
    for (int i = 2; i < number; i++)
    {
        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
    }
    return arrayFib;
}

int num = 8;
int[] NewArray = GenArray(num, 1, 100);
PrintArray(Fibonach(num));
// Fibonach(NewArray);

int[] GenArray(int a, int min, int max)
{
    if (max < min) //я решил вынести проверку мин и макс в формулу, чтобы не писать её каждый раз
    {
        int b = max;
        max = min;
        min = b;
    }
    int[] RandomArray = new int[a];
    int count = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
        if (RandomArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return RandomArray;
}

//-----------

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.
/*
System.Console.WriteLine("Введите число: ");
int input = 0;
int.TryParse(Console.ReadLine(), out input);

int[] FiboArray(int input) {
    int[] result = new int[input];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < input; i++) {
        result[i] = result[i-1] + result[i-2];
    }

    return result;
}

void printArr(int[] nums){
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

printArr(FiboArray(input));

//  Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] inpArr) {
    int[] result = new int[inpArr.Length];
    for(int i = 0; i < result.Length; i++) {
        result[i] = inpArr[i];
    }
    return result;
}

int[] GenerateArray(int array_Size) {
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for(int i = 0; i < array_Size; i++) {
        result[i] = tmp.Next(100, 1000);
    }

    return result;
} 

void printArr(int[] nums){
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

System.Console.WriteLine("Введите размер массива");
int input = 0; 
int.TryParse(Console.ReadLine(), out input);
int[] arr1 = GenerateArray(input);
System.Console.WriteLine("Исходный массив");
printArr(arr1);
int[] copy = CopyArray(arr1);
System.Console.WriteLine("Копия массива");
printArr(copy);

//----
Console.WriteLine("Enter the number of Fibonacci numbers to generate: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, c;

Console.Write(a + ", ");
Console.Write(b + ", ");

for (int i = 2; i < n; i++)
{
    c = a + b;
    Console.Write(c + ", ");

    a = b;
    b = c;
}

System.Console.Write("\n");