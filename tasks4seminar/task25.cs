/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
 */

Console.Write("Введите число A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = int.Parse(Console.ReadLine());

int pow = Power();
Console.Write($"Число {number1} в натуральной степени {number2} = {pow}");

int Power()
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

