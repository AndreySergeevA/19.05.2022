/* Задача:
Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

bool IsNumberPosition(int number)
{
    return number > 0;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetSumnFromOneToNumber(int number)
{
    int sumn = 0;
    for(int x = 1; x <= number; x++)
    {
        sumn += x;
    }
    return sumn;
}

if(IsNumberPosition(number))
{
    int sumn = GetSumnFromOneToNumber(number);
    Console.WriteLine($"{number} -> {sumn}");
}
else
{
    Console.WriteLine("Неккоректное число");
}

