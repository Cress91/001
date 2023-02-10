// Напишите программу, которая принимает 5-значное
// число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num / 10000 != num % 10)
{
    System.Console.WriteLine("No");
}
   if ((num / 1000) % 10 != (num % 100) / 10)
   {
    System.Console.WriteLine("No");
   }
else
{
    System.Console.WriteLine("Yes");
}