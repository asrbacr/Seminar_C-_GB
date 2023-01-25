Console.WriteLine("Введите день недели числом ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Это понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Это вторник");
}
else if (day == 3)
{
    Console.WriteLine("Это среда");
}
else if (day == 4)
{
    Console.WriteLine("Это четверг");
}
else if (day == 5)
{
    Console.WriteLine("Это пятница");
}
else if (day == 6)
{
    Console.WriteLine("Это суббота");
}
else if (day == 7)
{
    Console.WriteLine("Это воскресенье");
}
else
{
    Console.WriteLine("Вы ввели число отличное от 1 до 7");
}