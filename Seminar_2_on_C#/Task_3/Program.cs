// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число для проверки на кратность 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Вы ввели 0");
    return;
}

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");