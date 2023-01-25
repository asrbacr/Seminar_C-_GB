Console.WriteLine("Введите число для опредения разряда единиц");
int number = int.Parse(Console.ReadLine());


if (number < 1000)
{
    int a = number % 10;
    Console.WriteLine("Разряд единиц числа " + number + " равен " + a);
}
else
{
    Console.WriteLine("Введите трёхзначное число");
}

//if (number % 1000 > 0)

