/* Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
RecursionOfSumNumbers(m, n, 0);

void RecursionOfSumNumbers(int m, int n, int sum)
{
    int temp = 0;
    if(m > n)
	{
        temp = n;
        n = m;
	    m = temp;
    }
    sum = sum + n;
    if (n <= m)
    {
    Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum} ");
    return;
    }
    RecursionOfSumNumbers(m, n - 1, sum);
}
