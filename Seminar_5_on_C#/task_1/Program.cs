// Решение в группах задач:
// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

int SumPositiveElements(int[] array)
{
    for (int i = 0; i <= array.Length; i++)
    {
        array[i] *= (-1);
    }
    return int[] array;
}

int[] Array = { 8, 2, -4, -4 };

//__________

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int[] ReverseSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

void PrintArray(int[] array1)
{
    System.Console.Write($"[{String.Join(",", array1)}]\n");
}

int[] array = GenerateArr(20, -9, 9);
PrintArray(array);
int[] reversedArray = ReverseSign(array);
PrintArray(reversedArray);


//______2 задача

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int checkNum = getVar();
int[] chekerNumsArr = generateArr(10, 0, 5);
bool flag = checkArr(checkNum, chekerNumsArr);

System.Console.WriteLine($"Число {checkNum} в массиве {arrToStr(chekerNumsArr)} {(flag ? "" : "не ")}встречается");

// -- FUNCs -- //
int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число от 0 до 5: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);
        
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}
bool checkArr(int checkNum, int[] chekerNumsArr) {
    foreach (var item in chekerNumsArr) {
        if (item == checkNum) {
            return true;
        }
    }
    
    return false;
}

int[] generateArr(int n, int min, int max) {
    int[] arrNum = new int[n];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

string  arrToStr(int[] nums){
    return $"[{String.Join(",", nums)}]";
}




