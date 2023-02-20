// Пользователь вводит с клавиатуры М чисел. Посчитайте,
// сколько чисел больше 0 ввел пользователь.

System.Console.WriteLine("Amount of numbers:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] a = new int[n];

for(int i = 0; i < n; i++)
{
    System.Console.WriteLine($"A[{i + 1}] = ");
    a[i] = Convert.ToInt32(Console.ReadLine());

    if (a[i] > 0)
    {
        sum++;
    }
}
System.Console.WriteLine($"Amount of positive numbers: {sum}");