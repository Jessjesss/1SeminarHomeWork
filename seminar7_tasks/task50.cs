/* Задача 50. Напишите программу, 
которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1
7 -> такого числа в массиве нет */

int[,] array = new int[6,7];
Console.Write("Введите позицию строки: ");
int rowsPosition = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца: ");
int columsPosition = int.Parse(Console.ReadLine()!);
Fillarray(array);
PrintArray(array);

if (rowsPosition > 6 && columsPosition > 7)
    {
        Console.Write("Такого числа в массиве нет(");
    }
    else
    {
    Console.WriteLine($"Значение элемента: {array[rowsPosition-1, columsPosition-1]}");
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

