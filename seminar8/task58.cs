/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет
 находить произведение двух матриц.
Например, даны 2 матрицы:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49

 */

int[,] matrix1 = new int[5,5];
int[,] matrix2 = new int[5,5];
int[,] matrixResult = new int [matrix1.GetLength(0),matrix2.GetLength(1)];
Fillarray(matrix1);
Fillarray(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
                 matrixResult[i,j] = matrix1[i,j] * matrix2[i,j];   
        }
    }

Console.WriteLine($"Произведение двух матриц: ");
PrintArray(matrixResult);

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
        Console.WriteLine();
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

