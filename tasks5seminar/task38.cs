/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] array = CreateArray();
FillArray(array);
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max)
        {
            max = array[i];
        }
    else if (array[i] < min)
        {
            min = array[i];
        }
    }
PrintArray(array);



double[] CreateArray()
{
    double[] array = new double [8];
    return array;
}

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
while (index < length)
{
    array[index] = Convert.ToDouble(new Random().Next(1,1000));
    index ++;
}
}

void PrintArray(double[] array)
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
    Console.WriteLine(" ");
    Console.WriteLine($"Макс = {max} / Мин = {min}");
    Console.Write($"Разница между максимальным и минимальным элементами массива = {max - min}");
}