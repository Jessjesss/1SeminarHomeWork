/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] matrix = new int[5,4];
Fillarray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinSumRow(matrix);

void MinSumRow(int[,] matrix)
{
int sumRow = 0;
int minRow = 0;
int numberRow = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i,j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            numberRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberRow + 1} ");
}

void Fillarray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,10);

        }
    }
}

void PrintArray(int[,] array)
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

