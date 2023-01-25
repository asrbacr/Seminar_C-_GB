// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == 0 || number2 == 0)
// {
//     Console.WriteLint("Одно из чисел 0");
//     return;
// }

// if (number1 * number1 == number2 || number2 / number1 == number1)
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("Нет");

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0 || number2 == 0)
{
    System.Console.WriteLine("Одно из чисел является нулём");
    return;
}

if (number1 * number1 == number2 || number2 / number1 == number1) Console.WriteLine("Да");
else Console.WriteLine("Нет");

// Console.Write("Введите первое число: ");
// int numOne = Convert.ToInt32( Console.ReadLine() );  

// Console.Write("Введите второе число: ");
// int numTwo = Convert.ToInt32( Console.ReadLine() );  

// double sqrtNumOne = Math.Sqrt(numOne);
// double sqrtnumTwo = Math.Sqrt(numTwo);

// System.Console.WriteLine(sqrtNumOne == Math.Abs(numTwo) || sqrtnumTwo == Math.Abs(numOne) ? "Да" : "Нет");

// // -------------------- // 

// double powNumOne = Math.Pow(numOne, 2);
// double pownumTwo = Math.Pow(numTwo, 2);

// System.Console.WriteLine(powNumOne == numTwo || pownumTwo == numOne ? "Да" : "Нет");