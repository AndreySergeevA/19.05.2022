/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

bool IsNumberPosition(int number)
{
    return number > 0;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetSumnFromOneToNumber(int number)
{
    int sumn = 1;
    for(int x = 1; x <= number; x++)
    {
        sumn *= x;
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
