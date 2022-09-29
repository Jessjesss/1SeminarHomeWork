/* Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов
 и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. 
Только в основном блоке кода или в функции вывода */


int[] array = CreateArray();
FillArray(array);
PrintArray(array);

int[] CreateArray()
{
    int[] array = new int [8];
    return array;
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
while (index < length)
{
    Random rnd = new Random();
    array[index] = rnd.Next(99);
    index ++;
}
}

void PrintArray(int[] array)
{
    
    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine();
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
{
    Console.Write(array[i]);
if (i == count - 1)
    Console.WriteLine("]");
else
    Console.Write(", ");
}
}



