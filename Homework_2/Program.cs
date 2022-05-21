/* Напишите программу, которая принимает на вход число
и выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sumDigit = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}

Console.WriteLine(sumDigit);