/* Задача 41: Пользователь вводит с клавиатуры
число M, потом вводит M чисел ЧЕРЕЗ ENTER.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3 */


Console.Write("Введите число М: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа через ENTER: ");
int[] array = new int[numberM];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"{Counter(array)} чисел больше 0");


int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        count++;
        }
        }
    return count;
}
