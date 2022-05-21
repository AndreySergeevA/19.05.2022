/* Напишите цикл, который принимает на вход два числа
(А и В) и возводит число А в натуральную степень В.
3,5 -> 243 (3^5)
2,4 -> 16 (2^4)
*/

bool IsNumberPosition(int number)
{
    return number > 0;
}

Console.WriteLine("Введите число, которое хотите возвести степень: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int exponent = int.Parse(Console.ReadLine());

int GetSumnFromOneToNumber(int number)
{
    int result = number;
    for(int x = 1; x < exponent; x++)
    {
        result = result * number;
    }
    return result;
}

if(IsNumberPosition(number))
{
    int result = GetSumnFromOneToNumber(number);
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("Неккоректное число");
}


