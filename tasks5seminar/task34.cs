/* /* 
Задача 34: Задайте массив,
заполненный случайными положительными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве. */

/* [345, 897, 568, 234] -> 2 */ 

 
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.Write($"Количество четных чисел в массиве = {Amount(array)}");

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
    array[index] = rnd.Next(100,999);
    index ++;
}
}

int Amount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    {
        count ++; 
    }
    }
    return count;
}


void PrintArray(int[] array)
{
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



/* if( != sArray.Length)
{
Console.Write("Массивы неравноразмерны!!!!11!");
}
else
{
int[] res = SumOfArray(fArray, sArray);
Console.Write(String.Join(", ", res));
} */
/* 
int[] ParseToArray(string str1, string str2)

{
string str = str1 + ' ' + str2;
string[] stringArray = str.Split(" ");
int[] result = new int[stringArray.Length];

for (int i = 0; i < stringArray.Length; i++)
{
result[i] = int.Parse(stringArray[i]);
}

return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstArray, secondArray);

Console.WriteLine(String.Join(", ", newArray));


int[] ConcatArray(int[] array1, int[] array2)
{
int[] resultArray = new int[array1.Length + array2.Length];
int counter = 0;

for (int i = 0; i < array1.Length; i++)
{
resultArray[counter] = array1[i];
counter++;
}
for (int i = 0; i < array2.Length; i++)
{
resultArray[counter] = array2[i];
counter++;
}

return resultArray;
} */ 