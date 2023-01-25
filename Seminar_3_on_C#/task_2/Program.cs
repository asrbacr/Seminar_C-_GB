// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//AB = √((xb - xa)2 + (yb - ya)2)



int xa, xb, ya, yb;
Console.Write("Введите координату X точки А: ");
while (!Int32.TryParse(Console.ReadLine(), out xa))
{
    Console.Write("Вы ввели не число! Повторите попытку: ");
}
Console.Write("Введите координату Y точки А: ");
while (!Int32.TryParse(Console.ReadLine(), out ya))
{
    Console.Write("Вы ввели не число! Повторите попытку: ");
}
Console.Write("Введите координату X точки B: ");
while (!Int32.TryParse(Console.ReadLine(), out xb))
{
    Console.Write("Вы ввели не число! Повторите попытку: ");
}
Console.Write("Введите координату Y точки B: ");
while (!Int32.TryParse(Console.ReadLine(), out yb))
{
    Console.Write("Вы ввели не число! Повторите попытку: ");
}

double Distance(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
}

double res = Distance(xa, ya, xb, yb);
Console.WriteLine($"Растояние между точками {res}");