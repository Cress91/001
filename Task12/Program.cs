// Напишите программу, которая найдет точку пересечения 2х прямых,
// заданных уравнениями у = к1 * х + в1, у = к2 * х + в2;
// значения в1, к1, в2, к2 задаются пользователем.
// в1 = 2, к1 = 5, в2 = 4, к2 = 9 ->(-0,5; -0,5)

System.Console.WriteLine("The aquation is y = kx + b");

System.Console.WriteLine("Enter k1");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter b1");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter k2");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter b2");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    System.Console.WriteLine("The lines are parallel");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x + b1;

    System.Console.WriteLine($"The solvation is ({x}; {y})");
}