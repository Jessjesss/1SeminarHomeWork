/* Задача 36: Задайте одномерный массив,
заполненный случайными числами. 
Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.Write($"Сумма нечетных элементов массива = {Sum(array)}");

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
    array[index] = rnd.Next(1,100);
    index ++;
}
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 != 0)
    {
        sum += array[i]; 
    }
    }
    return sum;
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
