/*
Решение в группах задач:
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
System.Console.WriteLine("Введите сторону AC");
int AC = UserInput();
System.Console.WriteLine("Введите сторону AB");
int AB = UserInput();
System.Console.WriteLine("Введите сторону BC");
int BC = UserInput();
// AC <= AB + BC
// AB <= AC + BC
// BC <= AB + AC

Console.WriteLine($"Данный треугольник {(checkTreangle(AC, AB, BC)? "" : "не ")}может существовать");

bool checkTreug( int AC, int AB, int BC)
{
    if((AC <= AB + BC) && (AB <= AC + BC) && (BC <= AB + AC))
    {
        return true;
    }
    return false;
}

//AC <= AB * BC
*/
//_____func

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
System.Console.Write("Введите десятичное число: ");
int num = getVar();
int tmpNum = num;
int count = 0;

while (tmpNum > 0) {   
    count++;
    tmpNum /= 2;
}

tmpNum = num;
int[] arrNum = new int[count];
for (int i = arrNum.Length; i > 0; i--) {
    arrNum[i-1] = tmpNum % 2;
    tmpNum /= 2;
}

printArr(num, arrNum);

// --- FUNCs --- //
int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);
        
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}

void printArr(int num, int[] nums){
    System.Console.Write($"{num} -> {String.Join("", nums)}\n");
}
*/