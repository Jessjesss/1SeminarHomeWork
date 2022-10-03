/* /* 
Задача 34: Задайте массив,
заполненный случайными положительными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве. */

/* [345, 897, 568, 234] -> 2 */ 

 
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.Write($"Количество четных чисел в массиве = {Amount(array)}");

int[] CreateArray()
{
    int[] array = new int [8];
    return array;
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
while (index < length)
{
    Random rnd = new Random();
    array[index] = rnd.Next(100,999);
    index ++;
}
}

int Amount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    {
        count ++; 
    }
    }
    return count;
}


void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
{
    Console.Write(array[i]);
if (i == count - 1)
    Console.WriteLine("]");
else
    Console.Write(", ");
}
}

