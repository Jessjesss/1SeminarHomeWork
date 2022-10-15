/* Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. 
 Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
RecursionOfNaturalNumbers(n);

void RecursionOfNaturalNumbers(int n)
{
    int num = n;
    if (num == 0)
    {
        return;
    }
    if (n < 0) 
    {
        Console.Write($"{n} не натуральное число");
    }
    else
    {
        Console.Write($"{num} ");
        num = n - 1;
        RecursionOfNaturalNumbers(n-1);
    }
}