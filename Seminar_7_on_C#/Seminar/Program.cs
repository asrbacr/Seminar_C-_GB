// string str = "Hello world!";
// var result = str.Split(" ");

// foreach (var item in collection)
// {

// }

// double[] numbers = str.Split(' ', ',', '.', ':', ';').Select(double.Parse).ToArray();

//тут есть счётчик
Console.WriteLine("Введите массив целых чисел через пробел:");
string input = Console.ReadLine()!;
string[] numberStrings = input.Split(" ");
int[] numbers = new int[numberStrings.Length];

for (int i = 0; i < numbers.Length; i++)
    numbers[i] = int.Parse(numberStrings[i]);

PrintArray(numbers);

// тут нет счётчика
string[] numbers = input.Split(' ');
foreach (string number in numbers)
{
    if (double.TryParse(number, out double value))
    {
        ...
        }
}


//LINQ - это к select

// ?? - оператор null-объединение
string input = System.Console.WriteLine() ?? "";

int? maybe = 25;
int i = maybe ?? 5; // если null? то вернуть 5.

//______ 46 задать 2-ух мерный масив МхN и вернуть

int[,] GenerateArray(int m, int n, int min, int max) //генерация
{
    int[,] arrNum = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < arrNum.GetLength(0); i++) {
        for (int j = 0; j < arrNum.GetLength(1); j++) {
            GenerateArray[i, j] = random.Next(min, max + 1);
        }
    }
}

void PrintArray2D(int[,] array) //вывод
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i,j]);
        }
        System.Console.WriteLine();
    }
}

// 47 float   rnd.NextSingle() - генерирует число 0.1 десятичное
float randNum = rnd.NextSingle() * (max - min) + min;


// 52 из 2-ух мерного -> одномерный вернуть