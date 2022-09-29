/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвращает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Write("Введите число: ");
string number = Console.ReadLine();
int result = Return();
Console.Write($"Сумма чисел {number} = {result}");

int Return()
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
        {
        sum += int.Parse(Convert.ToString(number[i]));
        }
    return sum;
}