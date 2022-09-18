/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9 */

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
    Console.WriteLine($"min = {number2}");
} 
else
{
    Console.WriteLine($"max = {number2}");
    Console.WriteLine($"min = {number1}");
}