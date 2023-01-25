// 11. Напишите программу, которая выводит случайное трёхзначное число и 
//удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

Console.WriteLine(number);
//987
int firstDigit = number / 100;
int secondDigit = (number / 10) % 10;
int thirdDigit = number % 10;
Console.WriteLine($"{firstDigit}{thirdDigit}"); //не получили число, но вывели 2 рядом.

//  result = firstDigit * 10 + thirdDigit; //Получили одно число.
