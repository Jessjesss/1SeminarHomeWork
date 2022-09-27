/* 19. Напишите программу, 
которая принимает на вход 
пятизначное число и проверяет, 
является ли оно палиндромом. */

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string numInd = Convert.ToString(number);

if (number < 10000 | number > 100000)
{
  Console.WriteLine("Некорректное число!");
}
else if (numInd[0] == numInd[4] && numInd[1] == numInd[3])
  {
  Console.WriteLine("Это палиндром!");
  }
else
  {
  Console.WriteLine("Это не палиндром!");
  }

