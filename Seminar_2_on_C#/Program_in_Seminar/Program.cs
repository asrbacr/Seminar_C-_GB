// int number = new Random().Next(10, 100);

// Console.WriteLine("Сгенерированное число " + number);
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit = 0;

// // if (firstDigit > secondDigit)
// //     maxDigit = firstDigit;
// // else
// //     maxDigit = secondDigit;

// // Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);

// //тернарный оператор
// Console.WriteLine("Наибольшая цифра в числе " + number + ": " + (firstDigit > secondDigit ? firstDigit : secondDigit));

//надо добавлять ошибку от дурака
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number);

//Лучший способ для ввода с защитой от дурака
if (int.TryParse(Console.ReadLine(), out int number))
    Console.WriteLine("Прочитано число: " + number);
else
    Console.WriteLine("Введено не верное число");