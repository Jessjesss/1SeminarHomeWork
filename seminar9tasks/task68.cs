/* Задача 68: Напишите программу вычисления
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
    if (m >= 0 && n >= 0)
    {
    Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {RecursionAkkerman(m, n)}");
    }
    else
    {
    Console.WriteLine("Число не натуральное");
    }


int RecursionAkkerman(int m,int n)
{
if (m == 0)
{
    return n + 1;
}
else if ((m != 0) && (n == 0))
{
    return RecursionAkkerman(m - 1, 1);
}
else
{
    return RecursionAkkerman(m - 1, RecursionAkkerman(m, n - 1));
}
}