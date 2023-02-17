// Задайте массив, заполненный случайными положительными 3х-значными числами.
// Напишите программу, которая покажет кол-во четных чисел в массиве.
// 
System.Console.WriteLine("Задайте массив");
int size = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        int element = array[i];
        if (element % 2 == 0)
        {
            sum += 1;
        }
    }
    return array;
}
System.Console.WriteLine(String.Join(",", array));
System.Console.WriteLine($"Sum of even numbers:" {sum});
