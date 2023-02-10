// Напишите программу, которая принимает 2 точек
// и находит расстояние между ними в 3д

System.Console.WriteLine("Введите число");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

 Console.WriteLine(d); 