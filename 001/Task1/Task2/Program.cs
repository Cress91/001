// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}

int num2 = (num / 100) % 10;

System.Console.WriteLine(num2);
