// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.WriteLine();
void Quarter(int number)
{
    if (number == 1)
    {
        Console.WriteLine("Первая четвертью. X > 0, Y > 0");
    }
    else if (number == 2)
    Console.WriteLine("Первая четвертью. X < 0, Y > 0");
    else if (number == 3)
    Console.WriteLine("Первая четвертью. X < 0, Y < 0");
    else if (number == 4)
    Console.WriteLine("Первая четвертью. X > 0, Y < 0");
    else
    Console.WriteLine("Введён не верный диапозон")
}

while(!int.TryParse(Console.ReadLine(), out var number))
{    Console.Write("Введите не целое число, повторите попытку: ");
}
    Quarter(number);

//_______
Console.Write("Введите число от 1 до 4: ");

int number;
while(!Int32.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Вы ввели не число! Повторите попытку: ");
}

Quarter(number);

void Quarter(int number)
{
    if (number == 1)
    {
        Console.WriteLine("Первая четверть. X > 0, Y > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("Вторая четверть. X < 0, Y > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("Третья четверть. X < 0, Y < 0");
    }
    else if (number == 4)
    {
        Console.WriteLine("Четвертая четверть. X > 0, Y < 0");
    }
    else
        Console.WriteLine("Введен неверный диапазон!");
}