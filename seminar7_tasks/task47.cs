/* Задача 47. Задайте двумерный массив 
размером m×n, заполненный случайными 
вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9
 */

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m,n];
Fillarray(array);
PrintArray(array);



void Fillarray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rand.NextDouble() * 10, 2);

        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
