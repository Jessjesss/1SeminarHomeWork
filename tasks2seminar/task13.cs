/* Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 999)
{
    int result = number % 10;
    Console.Write($"Третьим числом является: {result}");
}
else if (number > 999 && number < 9999)
{
    int result = number % 100 / 10;
    Console.Write($"Третьим числом является: {result}");
}
else if (number > 9999 && number < 99999)
{
    int result = (number / 10) % 100 / 10;
    Console.Write($"Третьим числом является: {result}");
}
else
    Console.Write("Третьей цифры нет!");