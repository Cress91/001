// Напишите цикл, который принимает 2 числа А и В
// и возводит число А в натуральную степень В.

System.Console.WriteLine(("Введите число А"));
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число В");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine(Expon(num, num1));


int Expon(int a, int x)
{
    int result = 1;
    for (int i = 0; i < x; i++)
    {
        result *= a;
    }

}