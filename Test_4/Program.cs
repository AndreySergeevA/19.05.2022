/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void FillArray(int[] collection)
{
    Random randomaiser = new Random();
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = randomaiser.Next(0, 2);
    }
}

int[] array = new int[8];
FillArray(array);

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
