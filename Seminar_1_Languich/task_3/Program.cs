//int number = int.Parse(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number *= -1; // number = number * (-1)

int number2 = number * (-1);

while (number2 <= number)
{
    Console.Write(number2 + " ");
    number2++;
}