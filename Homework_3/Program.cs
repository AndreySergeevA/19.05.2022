/* Напишите программу, которая задает массив
из 8 элементов и выводит их на экран.
1,2,5,7,19 -> [1,2,5,7,19]
6,1,33 -> [6,1,33]
*/

void FillArray(int[] collection)
{
    Random randomaiser = new Random();
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = randomaiser.Next(0, 99);
    }
}

int[] array = new int[8];
FillArray(array);

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}