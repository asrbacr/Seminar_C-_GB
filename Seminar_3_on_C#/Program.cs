// int CalclateQuarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     else if (x < 0 && y > 0)
//         return 2;
//     else if (x < 0 && y < 0)
//         return 3;
//     else if (x > 0 && y < 0)
//         return 4;
//     else
//         return -1;
// }


// Console.WriteLine("Программа для вычисления номера четверти точки на плоскости");
// Console.WriteLine("Введите координату X: ");

// if (!int.TryParse(Console.ReadLine(), out var x)){
//     Console.Write("Введите не целое число");
//     return;
// }

// Console.WriteLine("Введите координату Y: ");
// if (!int.TryParse(Console.ReadLine(), out var y))
//     Console.Write("Введите не целое число");

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Точка не должна лежать на оси");
// }

// var result = CalclateQuarter(x, y);

// if (result != -1)
// Console.WriteLine($"Точка ({x}, {y}) находится в четверти {result}");
// else
// Console.WriteLine("Ошибка при вычислении, входные данные не верные");

//___
//проверка на полиндром (зеркальное число) 5-ти значное. через функцию

//task 2, только 3D

//task 3, только куб