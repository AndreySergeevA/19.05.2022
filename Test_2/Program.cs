/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
// Первый способ

string GetNumber1()
{
    return Console.ReadLine();
}

int CountNum1(string str)
{
    return str.Length;
}
Console.WriteLine("Введите число: ");
int countNum1 = CountNum1(GetNumber1());
Console.WriteLine(countNum1);


// Второй способ

string GetNumber2()
{
    return Console.ReadLine();
}

int CountNum2(string str)
{
    int num = int.Parse(str);
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите число: ");
int countNum2 = CountNum2(GetNumber2());
Console.WriteLine(countNum2);