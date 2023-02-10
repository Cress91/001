// Напишите программу, которая принимает число 
// N и выдает таблицу кубов чисел от 1 до N

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    System.Console.WriteLine(i * i * i);
}
