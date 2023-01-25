// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то 
//программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0 || number2 == 0)
{
    Console.WriteLint("Одно из чисел 0");
    return;
}

if (number1 % number2 == 0)
    Console.WriteLine("кратно");
else
{
    int ostatok = number1 % number2;
    Console.WriteLine("не кратно, остаток " + ostatok);
    // Console.WriteLine("не кратно, остаток " + number1 % number2);
}
else