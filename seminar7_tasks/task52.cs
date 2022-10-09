﻿/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

 
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m,n];
Fillarray(array);
PrintArray(array);
Console.Write($"Среднее арифметическое каждого столбца: ");
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    Console.Write($"{sum / array.GetLength(0):f1}");
    Console.Write("; ");
    }

void Fillarray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,20);

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
    Console.WriteLine();
}



